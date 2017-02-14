[CmdletBinding()]
Param(
)

$body = @{
    DeviceId  = 123
    DeviceName = "Testerstation, Tikkakoski."
    TimeStamp = 1487069547
    MetaDataTest1 = "Something really meta"
} | ConvertTo-Json

Invoke-RestMethod "http://localhost:5000/v1/data" -Method Post -Body $body -ContentType "application/json"