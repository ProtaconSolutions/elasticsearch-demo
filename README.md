# Setup

```
docker-compose up
```

Now elastic runs on `http://localhost:9200` and grafana on `http://localhost:3000`. 

On windows grafana is on hyperv moby image, ip address of docker machine can be found with

```
Get-VM | ?{$_.ReplicationMode -ne “Replica”} | Select -ExpandProperty NetworkAdapters | Select VMName, IPAddresses, Status
```

# Commands
Add data to elastic search (windows):
```powershell
Invoke-RestMethod "http://localhost:9200/data/bestdevice/" -Body (@{ "@value" = (Get-Random -Maximum 1000); "@timestamp" = ([int][double]::Parse((Get-Date -UFormat %s)))} | ConvertTo-Json) -Method Post
```

# Contributing & issues & questions
Please see the [CONTRIBUTING.md](.github/CONTRIBUTING.md) file for guidelines.

# LICENSE
[The MIT License (MIT)](LICENSE)

Copyright (c) 2017 Protacon Solutions