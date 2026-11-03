# TecnoStore (frontend)

Tienda en línea hecha con Blazor (.NET 10, modo servidor). Consume la API del repositorio commerce-app: https://github.com/JairoAranyaH/commerce-app

## Requisitos
- .NET 10 SDK
- La API de commerce-app corriendo en http://localhost:9999 (Docker Desktop y `.\mvnw`)

## Ejecutar
    cd TecnoStore
    dotnet run --launch-profile https

Abre la dirección que indique la consola (por ejemplo https://localhost:7015).

## Configuración
La dirección de la API está en `TecnoStore/appsettings.json`, sección `Api:BaseUrl`.

## Imágenes
Las fotos de productos no se incluyen en el repositorio. Van en `TecnoStore/wwwroot/Image/Productos/{Categoria}/{Marca}/`. Sin ellas la tienda funciona y muestra un icono en lugar de la foto.
