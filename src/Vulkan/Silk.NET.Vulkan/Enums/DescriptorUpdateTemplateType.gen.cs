// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDescriptorUpdateTemplateType")]
    public enum DescriptorUpdateTemplateType : int
    {
        [NativeName("Name", "VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_DESCRIPTOR_SET")]
        DescriptorSet = 0,
        [NativeName("Name", "VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS_KHR")]
        PushDescriptorsKhr = 1,
        [NativeName("Name", "VK_DESCRIPTOR_UPDATE_TEMPLATE_TYPE_PUSH_DESCRIPTORS")]
        PushDescriptors = 1,
    }
}
