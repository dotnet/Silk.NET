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
}
