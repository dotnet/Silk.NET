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
    [NativeName("Name", "VkPhysicalDeviceMaintenance10PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance10PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMaintenance10PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMaintenance10PropertiesKhr,
            void* pNext = null,
            Bool32? rgba4OpaqueBlackSwizzled = null,
            Bool32? resolveSrgbFormatAppliesTransferFunction = null,
            Bool32? resolveSrgbFormatSupportsTransferFunctionControl = null
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

            if (rgba4OpaqueBlackSwizzled is not null)
            {
                Rgba4OpaqueBlackSwizzled = rgba4OpaqueBlackSwizzled.Value;
            }

            if (resolveSrgbFormatAppliesTransferFunction is not null)
            {
                ResolveSrgbFormatAppliesTransferFunction = resolveSrgbFormatAppliesTransferFunction.Value;
            }

            if (resolveSrgbFormatSupportsTransferFunctionControl is not null)
            {
                ResolveSrgbFormatSupportsTransferFunctionControl = resolveSrgbFormatSupportsTransferFunctionControl.Value;
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
        [NativeName("Name", "rgba4OpaqueBlackSwizzled")]
        public Bool32 Rgba4OpaqueBlackSwizzled;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "resolveSrgbFormatAppliesTransferFunction")]
        public Bool32 ResolveSrgbFormatAppliesTransferFunction;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "resolveSrgbFormatSupportsTransferFunctionControl")]
        public Bool32 ResolveSrgbFormatSupportsTransferFunctionControl;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMaintenance10PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
