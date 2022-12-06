@echo off
@title 使用 dotnet cli 自动创建解决方案和各项目

set basedir="%~dp0"
set basedir
cd /d %basedir%



@echo.
@echo.
@echo.
@echo\&echo  ---------- 创建解决方案 ----------
dotnet new sln -n GSA2TENET4StarTrek.dotNetFoundationTouch

@echo\&echo  ---------- 创建控制台测试应用程序 ----------
dotnet new console -lang "C#" -f net5.0 -n DebuggerOfConsoleAPP -o DebuggerOfConsoleAPP/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add --in-root DebuggerOfConsoleAPP/src

@echo\&echo  ---------- 窗体测试应用程序 ----------
dotnet new winforms -lang "C#" -f net5.0 -n DebuggerOfFormAPP -o DebuggerOfFormAPP/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add --in-root DebuggerOfFormAPP/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- WebView2Touch ----------
dotnet new winforms -lang "C#" -f net5.0 -n WebView4App01 -o WebView2Touch/WebView4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s WebView2Touch WebView2Touch/WebView4App01/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- DotNetBarTouch ----------
dotnet new winforms -lang "C#" -f net5.0 -n DotNetBar4App01 -o DotNetBarTouch/DotNetBar4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s DotNetBarTouch DotNetBarTouch/DotNetBar4App01/src

dotnet new winforms -lang "C#" -f net5.0 -n DotNetBar4App02 -o DotNetBarTouch/DotNetBar4App02/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s DotNetBarTouch DotNetBarTouch/DotNetBar4App02/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- AspNetCoreTouch ----------
dotnet new web -lang "C#" -f net5.0 --exclude-launch-settings --no-https -n AspNetCore4Empty -o AspNetCoreTouch/AspNetCore4Empty/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreTouch AspNetCoreTouch/AspNetCore4Empty/src

dotnet new mvc -lang "C#" -f net5.0 --exclude-launch-settings --no-https -n AspNetCore4MVC -o AspNetCoreTouch/AspNetCore4MVC/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreTouch AspNetCoreTouch/AspNetCore4MVC/src

dotnet new webapp -lang "C#" -f net5.0 --exclude-launch-settings --no-https -n AspNetCore4WebApp -o AspNetCoreTouch/AspNetCore4WebApp/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreTouch AspNetCoreTouch/AspNetCore4WebApp/src

dotnet new webapi -lang "C#" -f net5.0 --exclude-launch-settings --no-https -n AspNetCore4WebApi -o AspNetCoreTouch/AspNetCore4WebApi/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreTouch AspNetCoreTouch/AspNetCore4WebApi/src

dotnet new grpc -lang "C#" -F net5.0 --exclude-launch-settings -n AspNetCore4gRPC -o AspNetCoreTouch/AspNetCore4gRPC/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreTouch AspNetCoreTouch/AspNetCore4gRPC/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- AspNetCoreNet7Touch ----------
dotnet new web -lang "C#" -f net7.0 --exclude-launch-settings --no-https -n AspNetCore4Empty -o AspNetCoreNet7Touch/AspNetCore4Empty/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreNet7Touch AspNetCoreNet7Touch/AspNetCore4Empty/src

dotnet new mvc -lang "C#" -f net7.0 --exclude-launch-settings --no-https -n AspNetCore4MVC -o AspNetCoreNet7Touch/AspNetCore4MVC/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreNet7Touch AspNetCoreNet7Touch/AspNetCore4MVC/src

dotnet new webapp -lang "C#" -f net7.0 --exclude-launch-settings --no-https -n AspNetCore4WebApp -o AspNetCoreNet7Touch/AspNetCore4WebApp/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreNet7Touch AspNetCoreNet7Touch/AspNetCore4WebApp/src

dotnet new webapi -lang "C#" -f net7.0 --exclude-launch-settings --no-https -n AspNetCore4WebApi -o AspNetCoreNet7Touch/AspNetCore4WebApi/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreNet7Touch AspNetCoreNet7Touch/AspNetCore4WebApi/src

dotnet new grpc -lang "C#" -F net7.0 --exclude-launch-settings -n AspNetCore4gRPC -o AspNetCoreNet7Touch/AspNetCore4gRPC/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s AspNetCoreNet7Touch AspNetCoreNet7Touch/AspNetCore4gRPC/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- GenericHostTouch ----------
dotnet new console -lang "C#" -f net5.0 -n GenericHost4App01 -o GenericHostTouch/GenericHost4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4App01/src

dotnet new winforms -lang "C#" -f net5.0 -n GenericHost4App02 -o GenericHostTouch/GenericHost4App02/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4App02/src

dotnet new classlib -lang "C#" -f net5.0 -n GenericHost4Lib01 -o GenericHostTouch/GenericHost4Lib01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4Lib01/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- SignalRTouch ----------



@echo.
@echo.
@echo.
@echo\&echo  ---------- WPFTouch ----------
dotnet new wpf -lang "C#" -f net5.0 -n WPF4App01 -o WPFTouch/WPF4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s WPFTouch WPFTouch/WPF4App01/src



@echo.
@echo.
@echo.
@echo\&echo  ---------- Temporary ----------





::@echo\&echo 所有项目自动创建工作已结束，600 秒后将自动退出本自动创建程序。
::timeout /t 600

@echo.
@echo.
@echo.
@echo.
@echo.
@echo\&echo 自动创建所有项目完毕，请按任意键退出。
pause>nul 
exit