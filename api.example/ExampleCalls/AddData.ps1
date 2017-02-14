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

Invoke-RestMethod "http://localhost:5000/v1/data" -Method Post -Body $body -ContentType "application/json"