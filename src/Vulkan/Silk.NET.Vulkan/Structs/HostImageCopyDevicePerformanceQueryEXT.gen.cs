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
    [NativeName("Name", "VkHostImageCopyDevicePerformanceQueryEXT")]
    public unsafe partial struct HostImageCopyDevicePerformanceQueryEXT : IExtendsChain<ImageFormatProperties2>, IExtendsChain<ImageFormatProperties2KHR>
    {
        public HostImageCopyDevicePerformanceQueryEXT
        (
            StructureType? sType = StructureType.HostImageCopyDevicePerformanceQueryExt,
            void* pNext = null,
            Bool32? optimalDeviceAccess = null,
            Bool32? identicalMemoryLayout = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (optimalDeviceAccess is not null)
            {
                OptimalDeviceAccess = optimalDeviceAccess.Value;
            }

            if (identicalMemoryLayout is not null)
            {
                IdenticalMemoryLayout = identicalMemoryLayout.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "optimalDeviceAccess")]
        public Bool32 OptimalDeviceAccess;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "identicalMemoryLayout")]
        public Bool32 IdenticalMemoryLayout;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.HostImageCopyDevicePerformanceQueryExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
