#!/bin/bash

docker exec -it mssqlamazon /opt/mssql-tools/bin/sqlcmd -S 127.0.0.1 -U sa -P "1Secure*Password1"