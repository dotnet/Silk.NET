// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV
{
    [NativeName("Name", "SpvMemoryModel_")]
    public enum MemoryModel : int
    {
        [NativeName("Name", "SpvMemoryModelSimple")]
        Simple = 0x0,
        [NativeName("Name", "SpvMemoryModelGLSL450")]
        Glsl450 = 0x1,
        [NativeName("Name", "SpvMemoryModelOpenCL")]
        OpenCL = 0x2,
        [NativeName("Name", "SpvMemoryModelVulkan")]
        Vulkan = 0x3,
        [NativeName("Name", "SpvMemoryModelVulkanKHR")]
        VulkanKhr = 0x3,
        [NativeName("Name", "SpvMemoryModelMax")]
        Max = 0x7FFFFFFF,
    }
}
