# Mvc_CRUD


_CRUD ASP.NET Core 5 Médicos_


### Pre-requisitos 📋

_Tener instalado:_

* [.NET CORE 5 SDK](https://dotnet.microsoft.com/download)

* [SQL Server Express](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)

* [SQL Server Management Studio](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

* [Visual Studio Code](https://code.visualstudio.com/)

* [Extensión de C# VSC](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)


### Instalación 🔧

1. Clonar el repositorio:

```
git clone git@github.com:Andres620/Mvc_CRUD.git
```

2. Cambiar de directorio

```
cd Mvc_CRUD
```

3. Restaurar dependencias y herramientas del proyecto

```
dotnet restore
```


## Preparar Ejecución ⚙️

1. _Si se esta ejecutando por primera vez, instala el certificado de desarrollo usando  el comando_

```
dotnet dev-certs https --trust
```


2. _En el archivo **appsettings.json** modificar la cadena de conexión **"ConnectionStrings"** agregando sus datos de conexión_

* _Cambiar ID="Usuario SQL Server"_ y Password="Contraseña usuario SQL server" (sin comillas)
```
"DefaultConnectionSQLServer": "Server=localhost\\SQLEXPRESS;Database=MvcCRUD_MDC;User ID="Usuario SQL Server";Password="Contraseña usuario SQL server";Trusted_Connection=false;MultipleActiveResultSets=true"
```


3. _Migracion a la base de datos_

* Ejecutar los siguientes comandos:
```
dotnet tool install --global dotnet-ef
```
```
dotnet ef migrations add yourMigrationName
```
```
dotnet ef database update
```

_Si se tienen problemas al mirgrar a la base de datos, ejecutar los siguientes comandos_
```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
```
dotnet add package Microsoft.EntityFrameworkCore.tools
```


## Ejecución 🚀

_Ejecuta el comando_

```
dotnet run
```


## Autores ✒️

* **Andrés Felipe Castrillón Parra** - https://github.com/Andres620

