// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineSDLJob(this SilkTouchHost host) =>
        host.DefineJob(
            "SDL",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/SDL/SDL/Silk.NET.SDL.csproj",
                TestProject = "tests/SDL/SDL/Silk.NET.SDL.UnitTests.csproj",
                DefaultLicenseHeader = "eng/silktouch/header.txt",
            },
            context =>
                context
                    .WithDefaultFunctionTransformers(
                        new() { BoolTypes = new() { ["SDL_bool"] = null } }
                    )
                    .WithMods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles = ["eng/silktouch/sdl/**/generate.rsp"],
                                    InputSourceRoot = "sources/SDL",
                                    InputTestRoot = "tests/SDL",
                                }
                            )
                            .MarkNativeNames()
                            .ExtractHandles()
                            .ExtractNestedTypes()
                            .ExtractEnumConstants()
                            .ExtractFunctionPointers()
                            .TransformHandles(new() { UseDsl = true })
                            .TransformFunctions()
                            .TransformProperties(
                                new() { BoolTypes = new() { ["SDL_bool"] = null } }
                            )
                            .IdentifySharedPrefixes(new() { GlobalPrefixHints = ["SDL"] })
                            .PrettifyNames(
                                new()
                                {
                                    Affixes = new() { ["SharedPrefix"] = new() { Remove = true } },
                                }
                            )
                            .TransformEnums(
                                new() { AddNoneMemberToFlags = true, RewriteMemberValues = true }
                            )
                            .AddVTables(new())
                            .StripAttributes(
                                new() { Remove = ["NativeTypeName", "NameAffix", "Transformed"] }
                            )
                    )
        );
}
