ECHO OFF

@ SET OUTDIR=bin
@ SET DEBUGSAMPLE=/debug+
@ IF "%1"=="-r" SET DEBUGSAMPLE=/debug-
@ IF "%1"=="-R" SET DEBUGSAMPLE=/debug-
SET DOTNETFRAMEWORKPATH=C:\Windows\Microsoft.NET\Framework\v4.0.30319\
IF "%DOTNETFRAMEWORKPATH%" == "" goto Error
SET DOTNETFRAMEWORKSDKPATH=C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\

SET PATH=%DOTNETFRAMEWORKSDKPATH%/bin;%DOTNETFRAMEWORKPATH%;%PATH%;D:\UCML7662_HR\;

CD /D Y:\EMS_New\BPObject\Module\sln_Tran\

IF EXIST %OUTDIR% GOTO compile
MKDIR bin
:compile

:compile2
csc  /warn:1 /target:library %DEBUGSAMPLE% /d:BuildBat /out:%OUTDIR%/sln_Tran.dll  /r:Y:\EMS_New/UCMLBase/bin/UCMLBase.dll /r:Y:\EMS_New\SysDBModel\bin\SysDBModel.dll  /r:Y:\EMS_New\Common\bin\WorkFlow.dll  /r:Y:\EMS_New/DBModel/bin/DBLayer.dll /r:System.Data.dll  /r:System.dll /r:System.Xml.dll  /r:System.Web.dll /r:System.Web.Services.dll  /r:System.EnterpriseServices.dll  /r:Y:\EMS_New\BPObject\bin\UCMLSystemWeb.dll   /r:..\DBLayer\DBLayer_Tran\bin\DBLayer_Tran.dll  /r:..\..\bin\PulicFunction.dll  /r:..\..\bin\DBLayer_Pub.dll  /r:..\..\bin\DBLayer_Cus.dll  /r:..\..\bin\Newtonsoft.Json.dll   Business\*.cs 
@IF NOT EXIST %OUTDIR%/sln_Tran.dll GOTO CompileError
copy bin\sln_Tran.dll Y:\EMS_New\BPObject\bin\
goto end
:Error
ECHO .Net环境变量设置不当，请重新设置
goto end
:CompileError
ECHO 程序编译出错
goto end
:end
ECHO 结束
