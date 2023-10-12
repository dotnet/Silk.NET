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
    [NativeName("Name", "VkPhysicalDeviceMaintenance5PropertiesKHR")]
    public unsafe partial struct PhysicalDeviceMaintenance5PropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceMaintenance5PropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceMaintenance5PropertiesKhr,
            void* pNext = null,
            Bool32? earlyFragmentMultisampleCoverageAfterSampleCounting = null,
            Bool32? earlyFragmentSampleMaskTestBeforeSampleCounting = null,
            Bool32? depthStencilSwizzleOneSupport = null,
            Bool32? polygonModePointSize = null,
            Bool32? nonStrictSinglePixelWideLinesUseParallelogram = null,
            Bool32? nonStrictWideLinesUseParallelogram = null
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

            if (earlyFragmentMultisampleCoverageAfterSampleCounting is not null)
            {
                EarlyFragmentMultisampleCoverageAfterSampleCounting = earlyFragmentMultisampleCoverageAfterSampleCounting.Value;
            }

            if (earlyFragmentSampleMaskTestBeforeSampleCounting is not null)
            {
                EarlyFragmentSampleMaskTestBeforeSampleCounting = earlyFragmentSampleMaskTestBeforeSampleCounting.Value;
            }

            if (depthStencilSwizzleOneSupport is not null)
            {
                DepthStencilSwizzleOneSupport = depthStencilSwizzleOneSupport.Value;
            }

            if (polygonModePointSize is not null)
            {
                PolygonModePointSize = polygonModePointSize.Value;
            }

            if (nonStrictSinglePixelWideLinesUseParallelogram is not null)
            {
                NonStrictSinglePixelWideLinesUseParallelogram = nonStrictSinglePixelWideLinesUseParallelogram.Value;
            }

            if (nonStrictWideLinesUseParallelogram is not null)
            {
                NonStrictWideLinesUseParallelogram = nonStrictWideLinesUseParallelogram.Value;
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
        [NativeName("Name", "earlyFragmentMultisampleCoverageAfterSampleCounting")]
        public Bool32 EarlyFragmentMultisampleCoverageAfterSampleCounting;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "earlyFragmentSampleMaskTestBeforeSampleCounting")]
        public Bool32 EarlyFragmentSampleMaskTestBeforeSampleCounting;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthStencilSwizzleOneSupport")]
        public Bool32 DepthStencilSwizzleOneSupport;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "polygonModePointSize")]
        public Bool32 PolygonModePointSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nonStrictSinglePixelWideLinesUseParallelogram")]
        public Bool32 NonStrictSinglePixelWideLinesUseParallelogram;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nonStrictWideLinesUseParallelogram")]
        public Bool32 NonStrictWideLinesUseParallelogram;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceMaintenance5PropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
