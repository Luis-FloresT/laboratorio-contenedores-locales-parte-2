# Laboratorio de Contenedores Locales - Parte 2

Solución en .NET 10 y Aspire con una API ASP.NET Core, Redis y PostgreSQL orquestados por AppHost.

## Estructura

- `infra/Laboratorio.AppHost`: definición de los recursos y sus dependencias.
- `src/Laboratorio.Api`: API web con el endpoint de ejemplo `/weatherforecast`.
- `src/Laboratorio.ServiceDefaults`: configuración compartida de telemetría, descubrimiento y salud.
- `docs/capturas/01_aspire_dashboard.png`: panel con los recursos en ejecución.

## Ejecución

Requisitos: SDK .NET 10, Aspire CLI y Docker en ejecución.

```sh
dotnet restore
dotnet build
dotnet run --project infra/Laboratorio.AppHost
```

Abrir el enlace del panel que aparece en la consola y esperar a que los recursos estén en estado **Running**. La API espera a que Redis y PostgreSQL estén disponibles; Aspire proporciona sus cadenas de conexión. El endpoint `/health` informa el estado de la API.
