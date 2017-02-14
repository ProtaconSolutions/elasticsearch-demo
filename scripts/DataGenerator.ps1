[CmdletBinding()]
Param()

while ($true) {
    . $PSScriptRoot\AddData.ps1 -Device "A"
    . $PSScriptRoot\AddData.ps1 -Device "B"
    . $PSScriptRoot\AddData.ps1 -Device "C"
    Start-Sleep 1
}