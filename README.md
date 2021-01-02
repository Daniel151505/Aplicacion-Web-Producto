# Aplicacion-Web-Producto
Aplicación Web Producto - Estructura MVC - ASP.NET Core



# Creación de proyecto 

1. dotnet new mvc -au Individual
2. Agregar la cadena de conexión
3. Modificar el Startup

# Creación de la migraciones

4. Eliminamos los 3 archivos que aparecen en Migrations
5. Instalamos el paquete de Npgsql.EntityFrameworkCore.PostgreSQL
https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/3.1.4
6. Instalamos el dotnet -ef 
https://docs.microsoft.com/en-us/ef/core/cli/dotnet
7. Ejecutamos la siquiente instrucción :
dotnet ef migrations add CreateIdentitySchema --context El nombre de la carpeta donde esta alojado el proyecto.Data.ApplicationDbContext -o "Ubicación de la carpeta Migrations"
8. dotnet ef update database
9. Ejecutamos el proyecto
10. Aplicar Migrations



# Instalar Paquetes
https://www.nuget.org/packages/dotnet-aspnet-codegenerator/3.1.4

https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/3.1.4

https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/3.1.4

https://www.nuget.org/packages/Npgsql.EntityFrameworkCore.PostgreSQL/3.1.4

# Si descargas el proyecto y no quieres instalar los paquetes

Ejecuta en la consola: dotnet restore
Para que se te instalen automaticamente
# Despues de instalar paquetes (Vistas de Login, ForgotPassword, etc)

Ejecutar la siguiente instrucción: 
dotnet aspnet-codegenerator identity -dc AplicacionWebProducto.Data.ApplicationDbContext --files "Account.vista que quieren"

# Instalar herramienta (dotnet ef)

https://docs.microsoft.com/en-us/ef/core/cli/dotnet











