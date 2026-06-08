// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class ExtractFunctionPointersTests
{
    static ExtractFunctionPointersTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
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
                // TODO: ExtractFunctionPointers requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractFunctionPointers = new ExtractFunctionPointers(
            NullLogger<ExtractFunctionPointers>.Instance
        );

        await extractFunctionPointers.ExecuteAsync(context);

        // The function pointer should be extracted as both a struct and a delegate
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
