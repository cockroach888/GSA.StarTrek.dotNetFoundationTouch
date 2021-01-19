@echo off
@title 使用 dotnet cli 自动创建解决方案和各项目

set basedir="%~dp0"
set basedir
cd /d %basedir%



@echo.
@echo.
@echo.
@echo\&echo  ---------- 临散项目创建 ----------





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