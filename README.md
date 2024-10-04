# CityTalk.UserService
Сервис пользователей. Отвечает за функционал, связанный с пользователями системы (регистрация, логин, сообщения и т.д.).

## Техологии и библиотеки:
- ASP Net 8
- EF 8 - ORM
- MediatR - Messaging
- SignalR - Real-time interaction
- Aws SDK - S3 SDK
- YandexObjectStorage - Cloud storage used as s3 storage
- Docker, Docker-compose - Containerization
- Mapster - Mapping
- ...

## Развертывание

### Docker
To pull a docker image, run the following command:
```
Описать
```

### Docker-compose
Описать
```
docker-compose up -d
```

### Структура appsettings.json:
```json
{
  "ConnectionStrings": {
      "DbConnection": "your_npgsql_connection_string"
  },
  "AllowedHosts": "*"
}
```
