# Silk.NET.Maths.Tests
These are the tests covering Silk.NET.Maths, they are written in F#, using [expecto](https://github.com/haf/expecto)

## Writing Tests
For all types besides `Scalar` covering one code path (preferably `<float>`) should be enough, as these should only use `Scalar` to perform their operations.

## Code Coverage
[altcover](https://github.com/SteveGilham/altcover/) is used to produce code coverage, use 
```
dotnet test ./Silk.NET.Maths.Tests.fsproj --configuration Release /p:AltCover=true /p:AltCoverCobertura="cobertura.xml"
```

CI will also produce code coverage, and upload it to [codecov](https://codecov.io/) for viewing code coverage either the [altcover](https://github.com/SteveGilham/altcover/) visualizer or [sourcegraph](https://sourcegraph.com/github.com/Ultz/Silk.NET@feature/maths/-/blob/src/Maths/) with the [codecov extension](https://sourcegraph.com/extensions/sourcegraph/codecov) are recommended.