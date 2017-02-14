[CmdletBinding()]
Param()

while ($true) {
    . $PSScriptRoot\AddData.ps1 -Device 1
    . $PSScriptRoot\AddData.ps1 -Device 2
    . $PSScriptRoot\AddData.ps1 -Device 3
    Start-Sleep 1
}