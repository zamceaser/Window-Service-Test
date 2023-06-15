echo off
set "PSFILE=C:\Users\Semi Ravitisai\Desktop\services\WebServicePersonal\WebServicePersonal\bin\Debug\serviceStop.ps1"

REM Check if running with administrative privileges
NET FILE 1>NUL 2>NUL
if '%errorlevel%' == '0' (
    goto :RunScript
) else (
    echo Requesting elevation...
    powershell.exe -ExecutionPolicy Bypass -Command "Start-Process '%~dpnx0' -Verb RunAs"
    exit /b
)

:RunScript
powershell.exe -ExecutionPolicy Bypass -File "%PSFILE%"