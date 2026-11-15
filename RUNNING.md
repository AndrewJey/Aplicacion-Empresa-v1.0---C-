

<!-- local-development:start -->
# Desarrollo local

Puedes abrir este repositorio en VS Code, Antigravity o Sublime Text. El compilador y los servicios necesarios dependen del componente indicado abajo.

## Visual Studio 2022 / .NET Framework

Instala la carga de trabajo de escritorio .NET y el paquete de destino indicado en la tabla. Los proyectos ASP.NET también requieren la carga web e IIS Express. Abre la solución `.sln` correspondiente y selecciona el proyecto de aplicación para iniciar.

```powershell
# Ejecutar desde Developer PowerShell de Visual Studio 2022
$solutionDir = (Resolve-Path 'AplicacionEmpresa').Path + '\'
MSBuild.exe 'AplicacionEmpresa/AplicacionEmpresa/AplicacionEmpresa.csproj' /restore /p:RestorePackagesConfig=true /p:Configuration=Debug /p:DeployOnBuild=false "/p:SolutionDir=$solutionDir"
```

## Bases de datos

Revisa los scripts de esquema y crea una base de datos de prueba separada. SSMS 20 y pgAdmin 4 son clientes; SQL Server y PostgreSQL son motores distintos. Los scripts SQL Server no se ejecutan directamente en PostgreSQL. Las restauraciones deben hacerse sobre una base de prueba nueva. PostgreSQL 17 y 18 requieren comprobarse por separado.

## Componentes y validación

Inventario y compilaciones locales del 2026-11-15. Una compilación correcta no acredita todavía interacción, compatibilidad de base de datos, instalador ni despliegue.

| Componente | Tipo / destino | Validación |
| --- | --- | --- |
| [AplicacionEmpresa/AplicacionEmpresa.sln](<AplicacionEmpresa/AplicacionEmpresa.sln>) | solution | Sin ejecutar |
| [AplicacionEmpresa/AplicacionEmpresa/AplicacionEmpresa.csproj](<AplicacionEmpresa/AplicacionEmpresa/AplicacionEmpresa.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [AplicacionEmpresa/CapaDatos/CapaDatos.csproj](<AplicacionEmpresa/CapaDatos/CapaDatos.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [AplicacionEmpresa/CapaNegocio/CapaNegocio.csproj](<AplicacionEmpresa/CapaNegocio/CapaNegocio.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [AplicacionEmpresa/CapaPresentacion/CapaPresentacion.csproj](<AplicacionEmpresa/CapaPresentacion/CapaPresentacion.csproj>) | dotnet / v4.8.1 | Compila; prueba funcional pendiente |
| [Aplicación-Empresa.csproj](<Aplicación-Empresa.csproj>) | dotnet / v4.8.1 | Bloqueado: CS2001 |
| [Aplicación-Empresa.sln](<Aplicación-Empresa.sln>) | solution | Sin ejecutar |
| [Aplicación-Empresa1.csproj](<Aplicación-Empresa1.csproj>) | dotnet / v4.8.1 | Bloqueado: CS2001 |

## Archivos ignorados

`.gitignore` excluye credenciales locales, estado del editor y salidas de las herramientas detectadas. No deja de versionar archivos que ya estaban en Git. Los manifiestos, archivos de bloqueo, recursos fuente y scripts de esquema forman parte del código.
<!-- local-development:end -->

<!-- source-findings:start -->
## Hallazgos en los archivos fuente

Hallazgos de inspección estática; deben revisarse aunque otro componente compile.

| Hallazgo | Archivo |
| --- | --- |
| Fuente/recurso faltante | `Aplicación-Empresa.csproj → AplicacionEmpresa\AplicacionEmpresa\obj\Release\.NETFramework,Version=v4.5.1.AssemblyAttributes.cs` |
| Fuente/recurso faltante | `Aplicación-Empresa.csproj → AplicacionEmpresa\CapaPresentacion\BDEmpresaDataSet1.Designer.cs` |
| Fuente/recurso faltante | `Aplicación-Empresa1.csproj → AplicacionEmpresa\AplicacionEmpresa\obj\Release\.NETFramework,Version=v4.5.1.AssemblyAttributes.cs` |
| Fuente/recurso faltante | `Aplicación-Empresa1.csproj → AplicacionEmpresa\CapaPresentacion\BDEmpresaDataSet1.Designer.cs` |
<!-- source-findings:end -->
