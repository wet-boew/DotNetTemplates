# DotNetTemplates Change Log

## v2.6.1

### Fixes

- Fixing a Cross Site Scripting issue

## v2.6.0

### New features and improvements

- Fixing a memory leak issue by passing an IConfiguration interface in the ModelAccessor
- Adding an interface for WebTemplateSettings classes
- Added an acronym parameter to the custom menu allowing users to provide a description for an abbreviation.
- Updating social media sites that can be displayed as part of the share modal
- Updating static fallback files
- [CDTS](https://gccode.ssc-spc.gc.ca/iitb-dgiit/nw-ws/sgdc-cdts) v4.0.45 & [wet-boew](https://github.com/wet-boew/wet-boew) v4.0.50.1
- Internal changes and bug fixes

## v2.5.0

### New features and improvements

- Fixing compatibility issue with .NET Framework
- Adding an interface for Model and ModelAccessor classes
- Updating static fallback files
- [CDTS](https://gccode.ssc-spc.gc.ca/iitb-dgiit/nw-ws/sgdc-cdts) v4.0.44 & [wet-boew](https://github.com/wet-boew/wet-boew) v4.0.44.5
- Internal changes and bug fixes

## v2.4.0

### New features and improvements

- Adding a targetWarning parameter for the exitScript allowing users to be warned that link will open in a new window
- Adding a displayModalForNewWindow parameter for the exitScript allowing users to not show a modal if link opens in a new window
- Adding a footerPath parameter allowing users to provide a custom footer link for the GCIntranet template
- Updating static fallback files
- [CDTS](https://gccode.ssc-spc.gc.ca/iitb-dgiit/nw-ws/sgdc-cdts) v4.0.43 & [wet-boew](https://github.com/wet-boew/wet-boew) v4.0.43

## v2.3.3

### Fixes

- Fixing the issue of the search bar showing even when set to false

## v2.3.2

### Fixes

- Fixing the issue of the search bar showing even when set to false

## v2.3.1

### Fixes

- Package error

## v2.3.0

### New features and improvements

- Adds support for Adobe Analytics Version 3

## v2.2.0

### New features and improvements

- Adds support for .NET Core 3.1 !253
- Packages now upload to Nuget.org by default #330
- Adds `WebTemplateActionFilter` as alternative to `WebTemplateBaseController` in CoreMVC and MVC !252

## v2.1.2

### Fixes

- CSS link in static file !215
- Splash page not loading in french #172

## v2.1.1

### Fixes

- Persistent language switching #363
  `Startup.cs` needs modification to implment fix; see [Instalation - Core ToDo](https://gccode.ssc-spc.gc.ca/iitb-dgiit/sds/GOCWebTemplates/DotNetTemplates/-/wikis/Documentation/installation#core-todo)

## v2.1.0

### New features and improvements

- Adds GCToolsModal control #316

### Fixes

- Refresh with session timeout #361

## v2.0.2

### Fixes

- Menu and Search not hiding in Transactional template #359

## v2.0.1

### Fixes

- Target framework for Framewok project #355

## v2.0.0

### Breaking changes

- Adds implementation and support for .NET Core 2.1 & 3.0 [See Migration Wiki](https://gccode.ssc-spc.gc.ca/iitb-dgiit/sds/GOCWebTemplates/DotNetTemplates/-/wikis/Documentation/2.0-Migration)

### New features and improvements

- Implements [CDTS](https://gccode.ssc-spc.gc.ca/iitb-dgiit/nw-ws/sgdc-cdts) v4.0.32 with [wet-boew](https://github.com/wet-boew/wet-boew) v4.0.32
