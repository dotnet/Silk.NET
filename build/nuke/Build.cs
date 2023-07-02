using Nuke.Common;
using Nuke.Common.Execution;

partial class Build : NukeBuild
{
    // Welcome to the Silk.NET Build Infrastructure, powered by NUKE!
    // --------------------------------------------------------------
    // The build system has been split up into a number of files, with this file containing some shorthands for command
    // line usage.
    // --------
    // Building
    // --------
    // - Build.Core.cs       - core .NET build, uses the dotnet CLI to build the solution.
    // - Build.Generation.cs - a target for running our bespoke code generator BuildTools to generate all the .gen.cs
    //                         files.
    // - Native/*.cs         - builds the native (C/C++) components used by Silk.NET.
    // ---------
    // Packaging
    // ---------
    // - Build.Packaging.cs   - targets for producing NuGet packages and other artifacts for Silk.NET.
    // - Build.CodeSigning.cs - targets for signing those artifacts using Authenticode and the .NET Foundation code
    //                          signing service.
    // ----------
    // Deployment
    // ----------
    // - Build.NuGet.cs - targets for pushing NuGet packages to the NuGet Gallery (or some other feed).
    // -------------
    // Miscellaneous
    // -------------
    // - Build.ReviewHelpers.cs - targets used by CI jobs to help us automatically validate whether a PR is up to our
    //                            standards and hasn't missed anything out.
    // - Build.Support.cs       - support code used throughout the NUKE project.

    Target FullCompile => CommonTarget
    (
        x => x.DependsOn(BuildLibSilkDroid, RegenerateBindings, Compile)
    );

    Target FullPack => CommonTarget
    (
        x => x.DependsOn(BuildLibSilkDroid, RegenerateBindings, Pack)
    );

    Target FullPushToNuGet => CommonTarget
    (
        x => x.DependsOn(FullPack, PushToNuGet)
    );
}
