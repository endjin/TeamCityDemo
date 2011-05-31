@echo off
setlocal
set msbuildemitsolution=1
%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe build-web.proj /m /v:m /flp:verbosity=diagnostic;logfile=Logs\build-web.log %1 %2 %3

pause