while($true) 
{
    . $PSScriptRoot\AddData.ps1 -DeviceId 1 -DeviceName "Randomreader, Tikkakoski" -Value (Get-Random -Minimum 1 -Maximum 255)
    . $PSScriptRoot\AddData.ps1 -DeviceId 2 -DeviceName "Temperature, Jkl" -Value (Get-Random -Minimum 15 -Maximum 17)
    . $PSScriptRoot\AddData.ps1 -DeviceId 3 -DeviceName "Something, Jkl" -Value (Get-Random -Minimum 0 -Maximum 100)
    
    Start-Sleep -Seconds 1
}