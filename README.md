# Window-Service-Test
Description: This windows service simply logs the current date every 5 seconds onto a txt file


# Installing a Windows Service
Open the command prompt and fire the below command and press ENTER.

1. cd C:\Windows\Microsoft.NET\Framework\v4.0.30319 

Syntax
2. InstallUtil.exe + Your copied path + \your service name + .exe

**Open services by following the below steps:**
Press the Window key + R.
Type services.msc
Find your Service.

# Uninstalling a Windows Service
If you want to uninstall your service, fire the below command.

Syntax InstallUtil.exe -u + Your copied path + \your service name + .exe
Our path InstallUtil.exe -u C:\Users\Faisal-Pathan\source\repos\MyFirstService\MyFirstService\bin\Debug\MyFirstService.exe
