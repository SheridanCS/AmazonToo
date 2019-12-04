#!/bin/bash

docker run -e 'ACCEPT_EULA=Y' -e 'MSSQL_SA_PASSWORD=P@ssw0rd!' -p 1433:1433 -v mssql-volume:/var/opt/mssql -d mcr.microsoft.com/mssql/server:2017-latest