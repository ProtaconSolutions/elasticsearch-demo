[CmdletBinding()]
Param($Index = "data", $Device = "A")

$body = @{ 
    "value" = (Get-Random -Maximum 1000)
    "time" = [DateTime]::UtcNow.ToString("o")
    "device" = $Device
} | ConvertTo-Json -Depth 30

Invoke-RestMethod "http://localhost:9200/$Index/$device/" `
    -Body $body `
    -Method Post `
    -ContentType "application/json"