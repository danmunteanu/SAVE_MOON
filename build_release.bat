@echo off
set "CONFIG=Release"
set "PLATFORM=Any CPU"

for %%f in (*.sln) do (
    echo Building solution: %%f
    dotnet build "%%f" ^
        /property:GenerateFullPaths=true ^
        /consoleloggerparameters:NoSummary ^
        /p:Configuration=%CONFIG% ^
        /p:Platform="%PLATFORM%"
)

pause
