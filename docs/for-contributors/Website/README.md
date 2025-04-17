# dotnet.github.io/Silk.NET

We use Docusaurus to build our website, however our usage of it is a bit esoteric.

The website is built using the following command:

```
nuke website
```

Alternatively, one of the build scripts can be used in place of the `nuke` global tool. For more information, see the
[build system](../build-system.md) documentation.

In its simplest form, Docusaurus is used with the following details:
- The content at the `docs` URL is kept in the `docs` directory in the repository root.
- The rest of the website files are at [`sources/Website`](../../../sources/Website).
-
