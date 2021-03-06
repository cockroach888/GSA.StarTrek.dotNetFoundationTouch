[TOC]

# 各个工程的源文件目录

- 解决方案
```
dotnet new sln -n GSA2TENET4StarTrek.dotNetFoundationTouch
```

- 控制台测试应用程序
```
dotnet new console -lang "C#" -f net5.0 -n DebuggerOfConsoleAPP -o DebuggerOfConsoleAPP/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add --in-root DebuggerOfConsoleAPP/src
```

- 窗体测试应用程序
```
dotnet new winforms -lang "C#" -f net5.0 -n DebuggerOfFormAPP -o DebuggerOfFormAPP/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add --in-root DebuggerOfFormAPP/src
```

- WebView2Touch
```
dotnet new winforms -lang "C#" -f net5.0 -n WebView4App01 -o WebView2Touch/WebView4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s WebView2Touch WebView2Touch/WebView4App01/src
```

- DotNetBarTouch
```
dotnet new winforms -lang "C#" -f net5.0 -n DotNetBar4App01 -o DotNetBarTouch/DotNetBar4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s DotNetBarTouch DotNetBarTouch/DotNetBar4App01/src

dotnet new winforms -lang "C#" -f net5.0 -n DotNetBar4App02 -o DotNetBarTouch/DotNetBar4App02/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s DotNetBarTouch DotNetBarTouch/DotNetBar4App02/src
```

- AspNetCoreTouch
```
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
```

- GenericHostTouch
```
dotnet new console -lang "C#" -f net5.0 -n GenericHost4App01 -o GenericHostTouch/GenericHost4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4App01/src

dotnet new winforms -lang "C#" -f net5.0 -n GenericHost4App02 -o GenericHostTouch/GenericHost4App02/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4App02/src

dotnet new classlib -lang "C#" -f net5.0 -n GenericHost4Lib01 -o GenericHostTouch/GenericHost4Lib01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s GenericHostTouch GenericHostTouch/GenericHost4Lib01/src
```

- SignalRTouch
```

```

- WPFTouch
```
dotnet new wpf -lang "C#" -f net5.0 -n WPF4App01 -o WPFTouch/WPF4App01/src
dotnet sln GSA2TENET4StarTrek.dotNetFoundationTouch.sln add -s WPFTouch WPFTouch/WPF4App01/src
```

- Temporary
```

```
