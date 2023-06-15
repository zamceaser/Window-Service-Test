$serviceName = "Service1"

$status = Get-Service -Name $serviceName
if($status.Status -eq "Stopped")
{
	Write-Output "The service is already stopped"
}
else
{
	Stop-Service -Name $serviceName
	Write-Output "The service has been Stopped"
}