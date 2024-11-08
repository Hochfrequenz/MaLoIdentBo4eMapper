![Nuget Package](https://badgen.net/nuget/v/MaLoIdentBo4eMapper)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

# MaLoIdentBo4eMapper

`MaLoIdentBo4eMapper` is a .NET Library that maps models used in the "Marktlokation Identifikations-Prozess" ("MaLo Ident") to Business Objects for Energy (BO4E / BOneyCombs).
It is based on the [`MaLoIdentModels`](https://github.com/Hochfrequenz/malo-ident-net-models) and [BO4E.NET](https://github.com/Hochfrequenz/BO4E-dotnet/).

## Installation and Use

Install it from nuget [MaLoIdentBo4eMapper](https://www.nuget.org/packages/MaLoIdentBo4eMapper):

```bash
dotnet add package MaLoIdentBo4eMapper
```

Use it in your code:

```csharp
using MaLoIdentBo4eMapper;
using MaLoIdentBo4eMapper.Models;
using MaLoIdentModels;
...
var maloIdentRequest = new MaLoIdentRequestAndQueryParameters
        {
            IdentificationParameter = ...,
            TransactionId = ...,
            CreationDateTime = ...,
        };
var mapper = new MaLoIdentRequestMapper();
var boneyComb = mapper.MapRequestToBo4e(maloIdentRequest);
```

## Documentation

Todo: Add documentation here, ideally as mermaid diagram.

```mermaid

```

## Code Quality

The code is automatically checked with unit tests.
The package uses strict nullability.

## Release Workflow

Create a new release [in Github](https://github.com/Hochfrequenz/MaLoIdentBo4eMapper/releases/new).
Use a leading `v` with semantic versioning (e.g. `v1.2.3`).

## Contributing

You are very welcome to contribute to this template repository by opening a pull request against the main branch.

## Hochfrequenz

[Hochfrequenz Unternehmensberatung GmbH](https://www.hochfrequenz.de) is a consulting company with offices in Berlin, Leipzig, Köln and Bremen.
We're not only the main contributor to open source in the field of German utilities but, according to [Kununu ratings](https://www.kununu.com/de/hochfrequenz-unternehmensberatung1), also among the most attractive employers within the German energy market.
Applications of talented developers are welcome at any time!
Please consider visiting our [career page](https://www.hochfrequenz.de/index.php/karriere/aktuelle-stellenausschreibungen/full-stack-entwickler) (German only).
