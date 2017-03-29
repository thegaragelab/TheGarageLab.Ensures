@echo off

REM Programs
set RUNNER="..\packages\xunit.runner.console.2.2.0\tools\xunit.console.exe"
set COVERAGE="..\packages\OpenCover.4.6.519\tools\OpenCover.Console.exe"
set REPORTING="..\packages\ReportGenerator.2.5.6\tools\ReportGenerator"
set ASSEMBLY=TheGarageLab.Ensures
set TESTFILE=%ASSEMBLY%.Results.xml

REM Generate the test results
%COVERAGE% -register:user -target:%RUNNER% -targetargs:"%ASSEMBLY%.Test.dll" -targetdir:"bin/debug" -filter:"+%ASSEMBLY%.* +%ASSEMBLY%.Test.*" -excludebyattribute:*.ExcludeFromCodeCoverage* -mergebyhash -output:%TESTFILE%

REM Generate the report
%REPORTING% -reports:"%TESTFILE%" -targetdir:"CodeCoverage"
