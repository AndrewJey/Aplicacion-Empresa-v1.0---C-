# Aplicacion-Empresa-v1.0---C-

<!-- local-development:start -->
## Desarrollo local

Consulta [RUNNING.md](RUNNING.md) para ubicar cada componente, abrirlo en su IDE, compilarlo y conocer las comprobaciones realizadas y los requisitos pendientes.
<!-- local-development:end -->

<!-- build-repairs-20261115:start -->
## Reparación y comprobación — 2026-11-15

- Los dos proyectos de la raíz ahora agregan las cuatro capas reales mediante ProjectReference. Se eliminó la compilación accidental de copias de obj/bin y de fuentes generadas ausentes.

Comprobado:

- Los seis proyectos .NET compilan con MSBuild de Visual Studio 2022.

Comandos:

```powershell
msbuild 'AplicacionEmpresa/AplicacionEmpresa.sln' /restore /t:Build
```

Alcance pendiente:

- La operación con datos requiere configurar SQL Server y cargar el esquema del proyecto; no se validó un flujo completo con su base original.

<!-- build-repairs-20261115:end -->
