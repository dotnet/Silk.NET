// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.Logging.Abstractions;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class TransformHandlesTests
{
    static TransformHandlesTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task SuccessfullyTransformsHandleType_NoDsl()
    {
        var inputDocName = "Vk.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public struct VkInstance_T { }

                public class Vk
                {
                    public static extern VkResult vkCreateInstance(
                        VkInstance_T* pInstance,
                        VkInstance_T** pInstance
                    );
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformHandles = new TransformHandles(
            new DummyOptions<TransformHandles.Config>(
                new TransformHandles.Config() { UseDsl = false }
            ),
            NullLogger<TransformHandles>.Instance
        );

        await transformHandles.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task SuccessfullyTransformsHandleType_WithDsl()
    {
        var inputDocName = "Vk.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public struct VkInstance_T { }

                public class Vk
                {
                    public static extern VkResult vkCreateInstance(
                        VkInstance_T* pInstance,
                        VkInstance_T** pInstance
                    );
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformHandles = new TransformHandles(
            new DummyOptions<TransformHandles.Config>(
                new TransformHandles.Config() { UseDsl = true }
            ),
            NullLogger<TransformHandles>.Instance
        );

        await transformHandles.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }

    [Test]
    public async Task DoesNotTransform_WhenNotAllReferencesAreThroughPointers()
    {
        var inputDocName = "Vk.gen.cs";
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                inputDocName,
                """
                public struct VkInstance_T { }

                public class Vk
                {
                    public static extern VkResult vkCreateInstance(
                        VkInstance_T pInstance,
                        VkInstance_T* pInstance,
                        VkInstance_T** pInstance
                    );
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var transformHandles = new TransformHandles(
            new DummyOptions<TransformHandles.Config>(
                new TransformHandles.Config() { UseDsl = true }
            ),
            NullLogger<TransformHandles>.Instance
        );

        await transformHandles.ExecuteAsync(context);

        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
