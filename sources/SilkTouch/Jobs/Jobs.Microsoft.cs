// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineMicrosoftJob(this SilkTouchHost host) =>
        host.DefineJob(
            "Microsoft",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/Win32/Win32/Silk.NET.Win32.csproj",
                TestProject = "tests/Win32/Win32/Silk.NET.Win32.UnitTests.csproj",
                DefaultLicenseHeader = "eng/silktouch/header.txt",
            },
            context =>
                context.Mods(mods =>
                    mods.AddIncludes(new())
                        .ClangScraper(
                            new()
                            {
                                ClangSharpResponseFiles =
                                [
                                    "eng/submodules/terrafx.interop.windows/generation/**/generate.rsp",
                                ],
                                ManualOverrides = new()
                                {
                                    ["sources/Windows/um/icm/Windows.gen.cs"] =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Windows/um/icm/Windows.cs",
                                    ["sources/Gdiplus/um/gdiplustypes/GpRect.gen.cs"] =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpRect.cs",
                                    ["sources/Gdiplus/um/gdiplustypes/GpRectF.gen.cs"] =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpRectF.cs",
                                    ["sources/Gdiplus/um/gdiplustypes/GpPathData.gen.cs"] =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpPathData.cs",
                                    ["sources/Windows/shared/strsafe/Windows.gen.cs"] =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Windows/shared/strsafe/Windows.gen.cs",
                                },
                                InputSourceRoot =
                                    "eng/submodules/terrafx.interop.windows/sources/Interop/Windows",
                                InputTestRoot =
                                    "eng/submodules/terrafx.interop.windows/tests/Interop/Windows",
                                SkipScrapeIf = ["!win"],
                            }
                        )
                        .ChangeNamespace(
                            new() { Mappings = new() { ["TerraFX.Interop.(.*)"] = "Silk.NET.$1" } }
                        )
                )
        );
}
