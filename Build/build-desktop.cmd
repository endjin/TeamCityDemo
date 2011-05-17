@echo off
setlocal
set msbuildemitsolution=1
%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe build-desktop.proj /m /v:m /flp:verbosity=diagnostic;logfile=build-desktop.log %1 %2 %3

pause