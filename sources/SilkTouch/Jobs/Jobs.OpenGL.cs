// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineOpenGLJob(this SilkTouchHost host) =>
        host.DefineJob(
            "OpenGL",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/OpenGL/OpenGL/Silk.NET.OpenGL.csproj",
                DefaultLicenseHeader = "eng/silktouch/header.txt",
            },
            context =>
                context.Mods(mods =>
                    mods.AddIncludes(new())
                        .ClangScraper(
                            new()
                            {
                                ClangSharpResponseFiles = ["eng/silktouch/opengl/**/generate.rsp"],
                                InputSourceRoot = "sources/OpenGL",
                                InputTestRoot = "tests/OpenGL",
                            }
                        )
                        .MarkNativeNames()
                        .AddApiProfiles(
                            new()
                            {
                                Profiles =
                                [
                                    new() { Profile = "gl", SourceSubdirectory = "glcompat" },
                                    new()
                                    {
                                        Profile = "glcore",
                                        SourceSubdirectory = "glcore",
                                        MinVersion = "3.2",
                                    },
                                    new()
                                    {
                                        Profile = "gles1",
                                        SourceSubdirectory = "gles1",
                                        MaxVersion = "2.0",
                                    },
                                    new()
                                    {
                                        Profile = "gles2",
                                        SourceSubdirectory = "gles2",
                                        MinVersion = "2.0",
                                    },
                                ],
                            }
                        )
                        .BakeSourceSets(
                            new()
                            {
                                SourceSets = new()
                                {
                                    ["glcompat"] = "gl",
                                    ["glcore"] = "gl",
                                    ["gles1"] = "gl",
                                    ["gles2"] = "gl",
                                },
                            }
                        )
                        .AddOpaqueStructs(new() { Names = ["GLsync"] })
                        .MixKhronosData(
                            new()
                            {
                                SpecPath = "eng/submodules/opengl-registry/xml/gl.xml",
                                Namespace = "Silk.NET.OpenGL",
                                TypeMap = new()
                                {
                                    ["GLenum"] = "uint",
                                    ["TraceMaskMESA"] = "uint",
                                    ["PathRenderingTokenNV"] = "byte",
                                    ["PathCoordType"] = "byte",
                                },
                                IdentifyFunctionDataTypes = true,
                                IdentifyEnumTypeNonExclusiveVendors = true,
                                IdentifyEnumMemberImpliedVendors = true,
                            }
                        )
                        .TransformHandles(new() { UseDsl = true })
                        .TransformFunctions(new() { BoolTypes = new() { ["GLboolean"] = null } })
                        .TransformProperties(new() { BoolTypes = new() { ["GLboolean"] = null } })
                        .IdentifySharedPrefixes(
                            new()
                            {
                                GlobalPrefixHints = ["gl"],
                                PrefixOverrides = new()
                                {
                                    ["SyncObjectMask"] = "GL_SYNC",
                                    ["OcclusionQueryParameterNameNV"] = "GL",
                                    ["TexStorageAttribs"] = "GL",
                                    ["ContainerType"] = "GL",
                                    ["SeparableTargetEXT"] = "GL",
                                },
                            }
                        )
                        .PrettifyNames(
                            new()
                            {
                                Affixes = new()
                                {
                                    ["HandleType"] = new() { Order = 1 },
                                    ["FunctionPointerDelegateType"] = new() { Order = 1 },
                                    ["KhronosVendor"] = new() { Order = -1 },
                                    ["KhronosFunctionDataType"] = new() { IsDiscriminator = true },
                                    ["KhronosImpliedVendor"] = new() { Remove = true },
                                    ["KhronosNonExclusiveVendor"] = new() { Remove = true },
                                    ["SharedPrefix"] = new() { Remove = true },
                                },
                            }
                        )
                        .TransformEnums(
                            new() { AddNoneMemberToFlags = true, RewriteMemberValues = true }
                        )
                        .AddVTables(
                            new()
                            {
                                VTables =
                                [
                                    new AddVTables.DllImport(),
                                    new AddVTables.StaticWrapper(),
                                    new AddVTables.ThisThread()
                                    {
                                        IsDefault = true,
                                        GenerateMakeCurrentPartial = true,
                                    },
                                ],
                            }
                        )
                        .StripAttributes(
                            new() { Remove = ["NativeTypeName", "NameAffix", "Transformed"] }
                        )
                )
        );
}
