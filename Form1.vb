Imports System.Net
Imports System.Net.Http
Imports System.Text.Json
Imports System.Text.Json.Serialization

Public Class Form1

    Private Shared ReadOnly _http As New HttpClient()

    Private Const GEO_URL As String =
        "https://geocoding-api.open-meteo.com/v1/search?name="

    Private Const WEATHER_URL As String =
        "https://api.open-meteo.com/v1/forecast"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim city = txtCity.Text.Trim()
        If city = "" Then Return
        btnSearch.Enabled = False
        lblStatus.Text = "🔍 Geocoding city..."
        Try
            ' Step 1 — geocode city name → lat/lon
            Dim geoJson = Await _http.GetStringAsync(GEO_URL & Uri.EscapeDataString(city) & "&count=1")
            Dim geoResp = JsonSerializer.Deserialize(Of GeoResponse)(geoJson)
            If geoResp.Results Is Nothing OrElse geoResp.Results.Length = 0 Then
                lblStatus.Text = "City not found." : Return
            End If
            Dim loc = geoResp.Results(0)
            lblStatus.Text = $"📍 {loc.Name}, {loc.Country} — fetching weather..."

            ' Step 2 — fetch weather by lat/lon
            Dim weatherUrl = $"{WEATHER_URL}?latitude={loc.Latitude}&longitude={loc.Longitude}&current=temperature_2m,relative_humidity_2m,wind_speed_10m&timezone=auto"
            Dim wJson = Await _http.GetStringAsync(weatherUrl)
            Dim w = JsonSerializer.Deserialize(Of WeatherResponse2)(wJson)
            Dim c = w.Current

            ' Step 3 — update UI (safe: Await already returned to UI thread)
            lblCity.Text = $"🌍 {loc.Name}, {loc.Country}"
            lblTemp.Text = $"🌡 {c.Temperature:F1} °C"
            lblHumid.Text = $"💧 {c.Humidity}% humidity"
            lblWind.Text = $"💨 {c.WindSpeed:F1} km/h"
            lblStatus.Text = $"Updated {DateTime.Now:HH:mm:ss}"
        Catch ex As HttpRequestException
            lblStatus.Text = $"Network error: {ex.Message}"
        Catch ex As TaskCanceledException
            lblStatus.Text = "Request timed out — check your connection."
        Finally
            btnSearch.Enabled = True
        End Try

    End Sub
End Class
' Represents the geocoding API response
Public Class GeoResponse

    <JsonPropertyName("results")>
    Public Property Results As GeoLocation()

End Class


' Represents one city/location result
Public Class GeoLocation

    <JsonPropertyName("name")>
    Public Property Name As String

    <JsonPropertyName("country")>
    Public Property Country As String

    <JsonPropertyName("latitude")>
    Public Property Latitude As Double

    <JsonPropertyName("longitude")>
    Public Property Longitude As Double

End Class


' Represents the weather API response
Public Class WeatherResponse2

    <JsonPropertyName("current")>
    Public Property Current As CurrentWeather

End Class


' Represents the current weather data
Public Class CurrentWeather

    <JsonPropertyName("temperature_2m")>
    Public Property Temperature As Double

    <JsonPropertyName("relative_humidity_2m")>
    Public Property Humidity As Integer

    <JsonPropertyName("wind_speed_10m")>
    Public Property WindSpeed As Double

End Class
