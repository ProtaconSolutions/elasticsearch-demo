[CmdletBinding()]
Param($Index = "data", $Device = 1)

$body = @{ 
    "Value" = (Get-Random -Minimum 1 -Maximum 255)
    "TimeStamp" = [DateTime]::UtcNow.ToString("o")
    "Device" = $Device
} | ConvertTo-Json -Depth 30

Invoke-RestMethod "http://localhost:9200/$Index/$device/" `
    -Body $body `
    -Method Post `
    -ContentType "application/json"