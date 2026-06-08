// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class ExtractHandlesTests
{
    static ExtractHandlesTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task SuccessfullyExtractsHandleType()
    {
        var inputDocName = "Vk.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public struct VkAllocationCallbacks;
                public struct VkInstanceCreateInfo;

                public class Vk
                {
                    public static extern VkResult vkCreateInstance(
                        VkInstanceCreateInfo* pCreateInfo,
                        VkAllocationCallbacks* pAllocator,
                        VkInstance_T** pInstance
                    );
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var extractHandles = new ExtractHandles(NullLogger<ExtractHandles>.Instance);

        await extractHandles.ExecuteAsync(context);

        // There should be an empty struct named VkInstance_T in a new file
        await TestUtils.VerifyDocumentsAsync(
            [context.SourceProject.Documents.Single(x => x.Name != inputDocName)]
        );
    }
}
