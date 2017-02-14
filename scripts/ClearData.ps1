[CmdletBinding()]
Param($Index = "data")

Invoke-RestMethod "http://localhost:9200/$Index/" `
    -Method Delete