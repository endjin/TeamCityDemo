@echo off
setlocal
set msbuildemitsolution=1
%windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe publish-package.proj /m /v:m /flp:verbosity=diagnostic;logfile=publish-package.log %1 %2 %3

pause