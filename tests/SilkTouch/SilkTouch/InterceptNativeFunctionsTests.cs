// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.UnitTests;

public class InterceptNativeFunctionsTests
{
    static InterceptNativeFunctionsTests()
    {
        if (!VerifyDiffPlex.Initialized)
        {
            VerifyDiffPlex.Initialize();
        }
    }

    [Test]
    public async Task SuccessfullyInterceptsRequestedFunction()
    {
        var project = TestUtils
            .CreateTestProject()
            .AddDocument(
                "Vk.gen.cs",
                """
                public class Vk
                {
                    [DllImport("vulkan", ExactSpelling = true)]
                    public static extern VkResult vkCreateInstance(
                        VkInstanceCreateInfo* pCreateInfo,
                        VkAllocationCallbacks* pAllocator,
                        VkInstance_T** pInstance
                    );

                    [DllImport("vulkan", ExactSpelling = true)]
                    public static extern VkResult vkCreateDevice(
                        VkPhysicalDevice_T physicalDevice,
                        VkDeviceCreateInfo* pCreateInfo,
                        VkAllocationCallbacks* pAllocator,
                        VkDevice_T* pDevice
                    );
                }
                """
            )
            .Project;

        var context = new DummyModContext() { SourceProject = project };

        var interceptNativeFunctions = new InterceptNativeFunctions(
            new DummyOptions<InterceptNativeFunctions.Configuration>(
                new InterceptNativeFunctions.Configuration()
                {
                    NativeFunctionNames = ["vkCreateInstance"],
                }
            )
        );

        await interceptNativeFunctions.ExecuteAsync(context);

        // vkCreateInstance should be intercepted by suffixing the original with -Internal
        // and by adding a replacement that makes use of the partial keyword
        await TestUtils.VerifyDocumentsAsync(context.SourceProject.Documents);
    }
}
