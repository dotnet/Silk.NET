// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceDataGraphProcessingEngineARM")]
    public unsafe partial struct PhysicalDeviceDataGraphProcessingEngineARM
    {
        public PhysicalDeviceDataGraphProcessingEngineARM
        (
            PhysicalDeviceDataGraphProcessingEngineTypeARM? type = null,
            Bool32? isForeign = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (isForeign is not null)
            {
                IsForeign = isForeign.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceDataGraphProcessingEngineTypeARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphProcessingEngineTypeARM")]
        [NativeName("Name", "type")]
        public PhysicalDeviceDataGraphProcessingEngineTypeARM Type;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "isForeign")]
        public Bool32 IsForeign;
    }
}
