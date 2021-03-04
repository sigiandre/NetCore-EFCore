# NetCore-EFCore
Entity Framework Core y SQL Server

## Crear  un nuevo archivo solución. 
- dotnet new sln
- mkdir LeerData
- dotnet new console

## ejecutar console
- dotnet run --project LeerData


## db4free.net
- Base de datos: andrediaz001us
- Nombre de usuario: andrediaz
- Correo electrónico: andretsubasa2019@gmail.com
- contraseña: ************

## migración 
- dotnet ef migrations add MySQLMigration --project LeerData
## correr la migración
- dotnet run --project LeerData

—————————————————————————————————
## código:
- using(var db = new AppVentaCursosContext()){
-                Console.WriteLine("Iniciar la migracion a MySQL");
-                db.Database.SetCommandTimeout(400);
-                db.Database.Migrate();
-}
