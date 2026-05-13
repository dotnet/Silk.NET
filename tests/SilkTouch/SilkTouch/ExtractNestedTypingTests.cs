// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class ExtractNestedTypingTests
{
    static ExtractNestedTypingTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task SuccessfullyExtractsNestedInlineArray()
    {
        var inputDocName = "VkPerformanceCounterDescriptionARM.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                namespace Silk.NET.Vulkan;

                public struct VkPerformanceCounterDescriptionARM
                {
                    [NativeTypeName("char[256]")]
                    public _name_e__FixedBuffer name;

                    [InlineArray(256)]
                    public struct _name_e__FixedBuffer
                    {
                        public sbyte e0;
                    }
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The nested struct should be extracted and named as VkPerformanceCounterDescriptionARMname
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsFunctionPointer()
    {
        var inputDocName = "VkDebugReportCallbackCreateInfoEXT.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct VkDebugReportCallbackCreateInfoEXT
                {
                    [NativeTypeName("PFN_vkDebugReportCallbackEXT")]
                    public delegate* unmanaged<
                        uint,
                        VkDebugReportObjectTypeEXT,
                        ulong,
                        nuint,
                        int,
                        sbyte*,
                        sbyte*,
                        void*,
                        uint> pfnCallback;
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The function pointer should be extracted as both a struct and a delegate
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsCStyleEnumConstants_Field()
    {
        var inputDocName = "Sdl.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct Sdl
                {
                    [NativeTypeName("#define SDL_BLENDMODE_NONE 0x00000000u")]
                    public const uint SDL_BLENDMODE_NONE = 0x00000000U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND 0x00000001u")]
                    public const uint SDL_BLENDMODE_BLEND = 0x00000001U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u")]
                    public const uint SDL_BLENDMODE_BLEND_PREMULTIPLIED = 0x00000010U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD 0x00000002u")]
                    public const uint SDL_BLENDMODE_ADD = 0x00000002U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD_PREMULTIPLIED 0x00000020u")]
                    public const uint SDL_BLENDMODE_ADD_PREMULTIPLIED = 0x00000020U;

                    [NativeTypeName("#define SDL_BLENDMODE_MOD 0x00000004u")]
                    public const uint SDL_BLENDMODE_MOD = 0x00000004U;

                    [NativeTypeName("#define SDL_BLENDMODE_MUL 0x00000008u")]
                    public const uint SDL_BLENDMODE_MUL = 0x00000008U;

                    [NativeTypeName("#define SDL_BLENDMODE_INVALID 0x7FFFFFFFu")]
                    public const uint SDL_BLENDMODE_INVALID = 0x7FFFFFFFU;
                }

                public class Test
                {
                    [NativeTypeName("SDL_BlendMode")]
                    public uint Blend;
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"SDL3/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The constants should have been moved from the Sdl clas to the SDL_BlendMode enum
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsCStyleEnumConstants_MethodParameter()
    {
        var inputDocName = "Sdl.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct Sdl
                {
                    [NativeTypeName("#define SDL_BLENDMODE_NONE 0x00000000u")]
                    public const uint SDL_BLENDMODE_NONE = 0x00000000U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND 0x00000001u")]
                    public const uint SDL_BLENDMODE_BLEND = 0x00000001U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u")]
                    public const uint SDL_BLENDMODE_BLEND_PREMULTIPLIED = 0x00000010U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD 0x00000002u")]
                    public const uint SDL_BLENDMODE_ADD = 0x00000002U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD_PREMULTIPLIED 0x00000020u")]
                    public const uint SDL_BLENDMODE_ADD_PREMULTIPLIED = 0x00000020U;

                    [NativeTypeName("#define SDL_BLENDMODE_MOD 0x00000004u")]
                    public const uint SDL_BLENDMODE_MOD = 0x00000004U;

                    [NativeTypeName("#define SDL_BLENDMODE_MUL 0x00000008u")]
                    public const uint SDL_BLENDMODE_MUL = 0x00000008U;

                    [NativeTypeName("#define SDL_BLENDMODE_INVALID 0x7FFFFFFFu")]
                    public const uint SDL_BLENDMODE_INVALID = 0x7FFFFFFFU;

                    [DllImport("SDL3", ExactSpelling = true)]
                    [return: NativeTypeName("bool")]
                    public static extern byte SDL_SetSurfaceBlendMode(
                        SDL_Surface* surface,
                        [NativeTypeName("SDL_BlendMode")] uint blendMode
                    );
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"SDL3/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The constants should have been moved from the Sdl clas to the SDL_BlendMode enum
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsCStyleEnumConstants_Pointer()
    {
        var inputDocName = "Sdl.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct Sdl
                {
                    [NativeTypeName("#define SDL_BLENDMODE_NONE 0x00000000u")]
                    public const uint SDL_BLENDMODE_NONE = 0x00000000U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND 0x00000001u")]
                    public const uint SDL_BLENDMODE_BLEND = 0x00000001U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u")]
                    public const uint SDL_BLENDMODE_BLEND_PREMULTIPLIED = 0x00000010U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD 0x00000002u")]
                    public const uint SDL_BLENDMODE_ADD = 0x00000002U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD_PREMULTIPLIED 0x00000020u")]
                    public const uint SDL_BLENDMODE_ADD_PREMULTIPLIED = 0x00000020U;

                    [NativeTypeName("#define SDL_BLENDMODE_MOD 0x00000004u")]
                    public const uint SDL_BLENDMODE_MOD = 0x00000004U;

                    [NativeTypeName("#define SDL_BLENDMODE_MUL 0x00000008u")]
                    public const uint SDL_BLENDMODE_MUL = 0x00000008U;

                    [NativeTypeName("#define SDL_BLENDMODE_INVALID 0x7FFFFFFFu")]
                    public const uint SDL_BLENDMODE_INVALID = 0x7FFFFFFFU;

                    [DllImport("SDL3", ExactSpelling = true)]
                    [return: NativeTypeName("bool")]
                    public static extern byte SDL_GetSurfaceBlendMode(
                        SDL_Surface* surface,
                        [NativeTypeName("SDL_BlendMode *")] uint* blendMode
                    );
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"SDL3/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The constants should have been moved from the Sdl clas to the SDL_BlendMode enum
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsCStyleEnumConstants_ReturnType()
    {
        var inputDocName = "Sdl.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct Sdl
                {
                    [NativeTypeName("#define SDL_BLENDMODE_NONE 0x00000000u")]
                    public const uint SDL_BLENDMODE_NONE = 0x00000000U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND 0x00000001u")]
                    public const uint SDL_BLENDMODE_BLEND = 0x00000001U;

                    [NativeTypeName("#define SDL_BLENDMODE_BLEND_PREMULTIPLIED 0x00000010u")]
                    public const uint SDL_BLENDMODE_BLEND_PREMULTIPLIED = 0x00000010U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD 0x00000002u")]
                    public const uint SDL_BLENDMODE_ADD = 0x00000002U;

                    [NativeTypeName("#define SDL_BLENDMODE_ADD_PREMULTIPLIED 0x00000020u")]
                    public const uint SDL_BLENDMODE_ADD_PREMULTIPLIED = 0x00000020U;

                    [NativeTypeName("#define SDL_BLENDMODE_MOD 0x00000004u")]
                    public const uint SDL_BLENDMODE_MOD = 0x00000004U;

                    [NativeTypeName("#define SDL_BLENDMODE_MUL 0x00000008u")]
                    public const uint SDL_BLENDMODE_MUL = 0x00000008U;

                    [NativeTypeName("#define SDL_BLENDMODE_INVALID 0x7FFFFFFFu")]
                    public const uint SDL_BLENDMODE_INVALID = 0x7FFFFFFFU;

                    [DllImport("SDL3", ExactSpelling = true)]
                    [return: NativeTypeName("SDL_BlendMode")]
                    public static extern uint SDL_ComposeCustomBlendMode(
                        SDL_BlendFactor srcColorFactor,
                        SDL_BlendFactor dstColorFactor,
                        SDL_BlendOperation colorOperation,
                        SDL_BlendFactor srcAlphaFactor,
                        SDL_BlendFactor dstAlphaFactor,
                        SDL_BlendOperation alphaOperation
                    );
                }
                """,
                // ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"SDL3/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTyping(NullLogger<ExtractNestedTyping>.Instance);

        await extractNestedTyping.ExecuteAsync(context);

        // The constants should have been moved from the Sdl clas to the SDL_BlendMode enum
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
