// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Vulkan;

[SupportedApiProfile(
    "vulkan",
    ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
    MinVersion = "1.1"
)]
public unsafe partial struct VkPhysicalDeviceGroupProperties_physicalDevices
{
    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e0;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e1;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e2;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e3;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e4;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e5;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e6;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e7;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e8;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e9;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e10;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e11;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e12;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e13;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e14;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e15;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e16;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e17;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e18;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e19;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e20;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e21;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e22;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e23;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e24;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e25;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e26;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e27;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e28;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e29;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e30;

    [SupportedApiProfile("vulkan")]
    public VkPhysicalDevice_T* e31;

    [SupportedApiProfile("vulkan")]
    public ref VkPhysicalDevice_T* this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (VkPhysicalDevice_T** pThis = &e0)
            {
                return ref pThis[index];
            }
        }
    }
}
