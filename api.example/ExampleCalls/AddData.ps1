[CmdletBinding()]
Param(
    $DeviceId = 123,
    $DeviceName = "DefaultName",
    $Value = 33
)

$body = @{
    DeviceId  = $DeviceId
    DeviceName = $DeviceName
    TimeStamp = [DateTimeOffset]::Now.ToUnixTimeMilliSeconds()
    Value = $Value
} | ConvertTo-Json

$uri = "http://localhost:5000/v1/data"

Invoke-RestMethod $uri -Method Post -Body $body -ContentType "application/json" -ErrorAction Stop

Write-Host "Uri '$uri' with data: $body"
