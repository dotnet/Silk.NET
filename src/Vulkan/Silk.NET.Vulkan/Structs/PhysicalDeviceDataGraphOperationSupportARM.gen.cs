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
    [NativeName("Name", "VkPhysicalDeviceDataGraphOperationSupportARM")]
    public unsafe partial struct PhysicalDeviceDataGraphOperationSupportARM
    {
        public PhysicalDeviceDataGraphOperationSupportARM
        (
            PhysicalDeviceDataGraphOperationTypeARM? operationType = null,
            uint? version = null
        ) : this()
        {
            if (operationType is not null)
            {
                OperationType = operationType.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPhysicalDeviceDataGraphOperationTypeARM")]
        [NativeName("Type.Name", "VkPhysicalDeviceDataGraphOperationTypeARM")]
        [NativeName("Name", "operationType")]
        public PhysicalDeviceDataGraphOperationTypeARM OperationType;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[128];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "version")]
        public uint Version;
    }
}
