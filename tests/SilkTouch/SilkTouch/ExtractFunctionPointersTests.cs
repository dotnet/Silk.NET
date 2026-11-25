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
                // ExtractFunctionPointers requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var documentFactories = new DummyDocumentFactories();

        var extractFunctionPointers = new ExtractFunctionPointers(
            NullLogger<ExtractFunctionPointers>.Instance,
            documentFactories
        );

        await extractFunctionPointers.ExecuteAsync(context);

        // The function pointer should be extracted as both a struct and a delegate
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task UpdatesReferences()
    {
        var inputDocName = "VkEnumerateInstanceExtensionPropertiesChain.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public unsafe partial struct VkEnumerateInstanceExtensionPropertiesChain
                {
                    [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceExtensionPropertiesChain *, const char *, uint32_t *, VkExtensionProperties *)")]
                    public delegate* unmanaged<VkEnumerateInstanceExtensionPropertiesChain*, sbyte*, uint*, VkExtensionProperties*, VkResult> pfnNextLayer;

                    [NativeName("CallDown")]
                    public readonly VkResult CallDown([NativeTypeName("const char *")] sbyte* pLayerName, [NativeTypeName("uint32_t *")] uint* pPropertyCount, VkExtensionProperties* pProperties)
                    {
                        return pfnNextLayer(pNextLink, pLayerName, pPropertyCount, pProperties);
                    }
                }
                """,
                // ExtractFunctionPointers requires the file path to be set and that the document is under a subfolder
                filePath: $"Vulkan/{inputDocName}"
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };
        var documentFactories = new DummyDocumentFactories();

        var extractFunctionPointers = new ExtractFunctionPointers(
            NullLogger<ExtractFunctionPointers>.Instance,
            documentFactories
        );

        await extractFunctionPointers.ExecuteAsync(context);

        // The reference in the CallDown method should be updated to point to pfnNextLayer.Handle
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
