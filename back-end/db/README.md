```
docker network create oneclassnetwork
docker run --network oneclassnetwork -d -p 3306:3306 --env-file configmap-dev.env --name onclass-db-mysql mysql:8.0.27
```