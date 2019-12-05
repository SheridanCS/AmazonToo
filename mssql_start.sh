#!/bin/bash

docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=1Secure*Password1' -e 'MSSQL_PID=Express' -p 1433:1433 -v mssqlvolume:/var/opt/mssql --name mssqlamazon -d mcr.microsoft.com/mssql/server:2017-latest