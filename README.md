# RSM.HCD.CSharp

![build status](https://github.com/rsm-hcd/RSM.HCD.CSharp/actions/workflows/build.yaml/badge.svg)
[![codecov](https://codecov.io/gh/rsm-hcd/RSM.HCD.CSharp/branch/main/graph/badge.svg)](https://codecov.io/gh/rsm-hcd/RSM.HCD.CSharp) <!-- ALL-CONTRIBUTORS-BADGE:START - Do not remove or modify this section -->
[![All Contributors](https://img.shields.io/badge/all_contributors-18-orange.svg?style=flat-square)](#contributors-)

<!-- ALL-CONTRIBUTORS-BADGE:END -->

[Supplemental Documentation](https://andculturecode.github.io/RSM.HCD.CSharp)

## Deploying Supplemental Documentation

```shell
$: cd documentation
$: npx cross-env CURRENT_BRANCH=main USE_SSH=true GIT_USER={GITHUB_USERNAME} GIT_PASS={GITHUB_PASSWORD} docusaurus deploy
```

## Packages

### AndcutlureCode.CSharp.Core

Commonly used interfaces, patterns and utilities by andculture engineering

#### Getting Started (AndcutlureCode.CSharp.Core)

This package is installed via NuGet

```shell
dotnet add [<PROJECT>] package RSM.HCD.CSharp.Core
```

#### Documentation (AndcutlureCode.CSharp.Core)

[Full API Documentation](src/Core/Core.md)

### RSM.HCD.CSharp.Extensions

Commonly used CSharp extension methods used at andculture.

#### Getting Started (RSM.HCD.CSharp.Extensions)

This package is installed via NuGet

```shell
dotnet add [<PROJECT>] package RSM.HCD.CSharp.Extensions
```

After installation, simply import the extensions namespace to gain access
to all of the available extension methods

```csharp
using System;
using System.Collection.Generic;
using RSM.HCD.CSharp.Extensions;

public class Program
{
    public static int Main(string[] args)
    {
        new List<string>().IsEmpty(); // returns true
    }
}
```

#### Documentation (RSM.HCD.CSharp.Extensions)

[Full API Documentation](src/Extensions/Extensions.md)

### RSM.HCD.CSharp.Testing

Commonly used CSharp testing code used at andculture.

#### Getting Started (RSM.HCD.CSharp.Testing)

This package is installed via NuGet

```shell
dotnet add [<PROJECT>] package RSM.HCD.CSharp.Testing
```

#### Documentation (RSM.HCD.CSharp.Testing)

[Full API Documentation](src/Testing/Testing.md)

### RSM.HCD.CSharp.Conductors

Commonly used interfaces, patterns and utilities for writing conductors by andculture engineering.

#### Getting Started (RSM.HCD.CSharp.Conductors)

This package is installed via NuGet

```shell
dotnet add [<PROJECT>] package RSM.HCD.CSharp.Conductors
```

#### Documentation (RSM.HCD.CSharp.Conductors)

[Full API Documentation](src/Conductors/Conductors.md)

#### Features

##### Factories

TODO: In-depth documentation on test factories

##### Configuration

Using the `FactorySettings` singleton class you can configure test factories. To access properties use the singleton instance `FactorySettings.Instance.{property|method};`

##### Debug (default: false)

To enable debug output set the `Debug` setting to `true`. Now warnings will be output via standard out for troubleshooting purposes. By default, only exceptional cases will be output.

## Development Setup

-   Install Dotnet Core 3.1
-   Install the `and-cli` tooling found at [AndcultureCode.Cli](https://github.com/rsm-hcd/AndcultureCode.Cli)

Below are a few basics to get you started, but there are many more commands and options for managing this and other projects found in the `and-cli`.

### Building project

-   Run the build command

    ```shell
    and-cli dotnet --build
    ```

### Running tests

-   Run the test command

    ```shell
    and-cli dotnet-test
    ```

### Running tests along with code coverage

-   Run the test command

    ```shell
    and-cli dotnet-test --coverage
    ```

-   Open the `coverage.opencover.xml` file in your browser

### Publishing a new version

-   Run the publish command with the next version number ([See semver package versioning](https://docs.microsoft.com/en-us/nuget/concepts/package-versioning))

    ```shell
    and-cli nuget --publish <version>
    ```

## Contributing

Information on contributing to this repo is in the [Contributing Guide](CONTRIBUTING.md)

### Contributors ✨

Thanks goes to these wonderful people ([emoji key](https://allcontributors.org/docs/en/emoji-key)):

<!-- ALL-CONTRIBUTORS-LIST:START - Do not remove or modify this section -->
<!-- prettier-ignore-start -->
<!-- markdownlint-disable -->
<table>
  <tr>
    <td align="center"><a href="http://www.winton.me/"><img src="https://avatars.githubusercontent.com/u/48424?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Winton DeShong</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=wintondeshong" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=wintondeshong" title="Tests">⚠️</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=wintondeshong" title="Documentation">📖</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Awintondeshong" title="Reviewed Pull Requests">👀</a></td>
    <td align="center"><a href="https://github.com/brandongregoryscott"><img src="https://avatars.githubusercontent.com/u/11774799?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Brandon Scott</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=brandongregoryscott" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=brandongregoryscott" title="Tests">⚠️</a> <a href="#maintenance-brandongregoryscott" title="Maintenance">🚧</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Abrandongregoryscott" title="Reviewed Pull Requests">👀</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=brandongregoryscott" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/Stefanie899"><img src="https://avatars.githubusercontent.com/u/37462028?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Stefanie Leitch</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=Stefanie899" title="Code">💻</a></td>
    <td align="center"><a href="http://jebediahelliott.com"><img src="https://avatars.githubusercontent.com/u/26680652?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Jeb</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=jebediahelliott" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=jebediahelliott" title="Tests">⚠️</a></td>
    <td align="center"><a href="https://github.com/jhugs"><img src="https://avatars.githubusercontent.com/u/14300627?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Joshua Hughes</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=jhugs" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Ajhugs" title="Reviewed Pull Requests">👀</a></td>
    <td align="center"><a href="http://resume.dylanjustice.com"><img src="https://avatars.githubusercontent.com/u/22502365?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Dylan Justice</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dylanjustice" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dylanjustice" title="Tests">⚠️</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dylanjustice" title="Documentation">📖</a></td>
    <td align="center"><a href="https://www.saidshah.com"><img src="https://avatars.githubusercontent.com/u/19719299?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Said B Shah</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=SaidShah" title="Documentation">📖</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=SaidShah" title="Code">💻</a> <a href="#maintenance-SaidShah" title="Maintenance">🚧</a></td>
  </tr>
  <tr>
    <td align="center"><a href="http://www.snsavage.com"><img src="https://avatars.githubusercontent.com/u/6299224?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Scott Savage</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=snsavage" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=snsavage" title="Tests">⚠️</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=snsavage" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/HeyKos"><img src="https://avatars.githubusercontent.com/u/5178698?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Mike Koser</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=HeyKos" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=HeyKos" title="Tests">⚠️</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3AHeyKos" title="Reviewed Pull Requests">👀</a></td>
    <td align="center"><a href="https://github.com/joshuapeters"><img src="https://avatars.githubusercontent.com/u/9259962?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Joshua Peters</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=joshuapeters" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=joshuapeters" title="Tests">⚠️</a></td>
    <td align="center"><a href="https://mjones.network"><img src="https://avatars.githubusercontent.com/u/8648891?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Mat Jones</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=mrjones2014" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=mrjones2014" title="Tests">⚠️</a></td>
    <td align="center"><a href="https://dev.to/fluffynuts"><img src="https://avatars.githubusercontent.com/u/4669340?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Davyd McColl</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=fluffynuts" title="Tests">⚠️</a></td>
    <td align="center"><a href="https://github.com/kamal-mansouri"><img src="https://avatars.githubusercontent.com/u/31888169?v=4?s=100" width="100px;" alt=""/><br /><sub><b>kamal-mansouri</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=kamal-mansouri" title="Tests">⚠️</a></td>
    <td align="center"><a href="https://github.com/jstevenson"><img src="https://avatars.githubusercontent.com/u/91424?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Jim Stevenson</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Ajstevenson" title="Reviewed Pull Requests">👀</a></td>
  </tr>
  <tr>
    <td align="center"><a href="http://www.ralphjmcintyre.com"><img src="https://avatars.githubusercontent.com/u/8047934?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Ralph J McIntyre</b></sub></a><br /><a href="#maintenance-ralphjmcintyre" title="Maintenance">🚧</a></td>
    <td align="center"><a href="https://www.davidezoccarato.cloud/"><img src="https://avatars.githubusercontent.com/u/9533250?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Davide Zoccarato</b></sub></a><br /><a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dzoccarato" title="Code">💻</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dzoccarato" title="Tests">⚠️</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/commits?author=dzoccarato" title="Documentation">📖</a></td>
    <td align="center"><a href="https://github.com/klauffer"><img src="https://avatars.githubusercontent.com/u/32967525?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Kyle Lauffer</b></sub></a><br /><a href="#maintenance-klauffer" title="Maintenance">🚧</a> <a href="#projectManagement-klauffer" title="Project Management">📆</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Aklauffer" title="Reviewed Pull Requests">👀</a></td>
    <td align="center"><a href="http://mytydev.com"><img src="https://avatars.githubusercontent.com/u/37794?v=4?s=100" width="100px;" alt=""/><br /><sub><b>Michael Tyson</b></sub></a><br /><a href="#maintenance-myty" title="Maintenance">🚧</a> <a href="#projectManagement-myty" title="Project Management">📆</a> <a href="https://github.com/rsm-hcd/RSM.HCD.CSharp/pulls?q=is%3Apr+reviewed-by%3Amyty" title="Reviewed Pull Requests">👀</a></td>
  </tr>
</table>

<!-- markdownlint-restore -->
<!-- prettier-ignore-end -->

<!-- ALL-CONTRIBUTORS-LIST:END -->

This project follows the [all-contributors](https://github.com/all-contributors/all-contributors) specification. Contributions of any kind welcome!
