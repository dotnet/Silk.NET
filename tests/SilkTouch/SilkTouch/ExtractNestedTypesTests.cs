// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class ExtractNestedTypesTests
{
    static ExtractNestedTypesTests()
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
                // TODO: ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTypes();

        await extractNestedTyping.ExecuteAsync(context);

        // The nested struct should be extracted and named as VkPerformanceCounterDescriptionARMname
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyExtractsNestedStructs()
    {
        var inputDocName = "Test.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public struct A
                {
                    public struct B
                    {
                        public struct C
                        {
                        }
                    }
                }
                """,
                // TODO: ExtractNestedTyping requires the file path to be set and that the document is under a subfolder
                filePath: $"Tests/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractNestedTyping = new ExtractNestedTypes();

        await extractNestedTyping.ExecuteAsync(context);

        // There should be 3 structs in separate documents named A, AB, and ABC
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
