[CmdletBinding()]
Param($Index = "data")

$body = @{ 
    "value" = (Get-Random -Maximum 1000)
    "time" = [DateTime]::UtcNow.ToString("o")
} | ConvertTo-Json -Depth 30

Invoke-RestMethod "http://localhost:9200/data/device/" `
    -Body $body `
    -Method Post `
    -ContentType "application/json"