$serviceName = "Service1"

$status = Get-Service -Name $serviceName
if($status.Status -eq "Running")
{
	Write.Output "The is already Running"
}
else
{
	Start-Service -Name $serviceName
	Write.Output "The Service was Started Successfully"
}