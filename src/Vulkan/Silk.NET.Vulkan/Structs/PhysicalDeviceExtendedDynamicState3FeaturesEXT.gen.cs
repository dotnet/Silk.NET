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
    [NativeName("Name", "VkPhysicalDeviceExtendedDynamicState3FeaturesEXT")]
    public unsafe partial struct PhysicalDeviceExtendedDynamicState3FeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceExtendedDynamicState3FeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceExtendedDynamicState3FeaturesExt,
            void* pNext = null,
            Bool32? extendedDynamicState3TessellationDomainOrigin = null,
            Bool32? extendedDynamicState3DepthClampEnable = null,
            Bool32? extendedDynamicState3PolygonMode = null,
            Bool32? extendedDynamicState3RasterizationSamples = null,
            Bool32? extendedDynamicState3SampleMask = null,
            Bool32? extendedDynamicState3AlphaToCoverageEnable = null,
            Bool32? extendedDynamicState3AlphaToOneEnable = null,
            Bool32? extendedDynamicState3LogicOpEnable = null,
            Bool32? extendedDynamicState3ColorBlendEnable = null,
            Bool32? extendedDynamicState3ColorBlendEquation = null,
            Bool32? extendedDynamicState3ColorWriteMask = null,
            Bool32? extendedDynamicState3RasterizationStream = null,
            Bool32? extendedDynamicState3ConservativeRasterizationMode = null,
            Bool32? extendedDynamicState3ExtraPrimitiveOverestimationSize = null,
            Bool32? extendedDynamicState3DepthClipEnable = null,
            Bool32? extendedDynamicState3SampleLocationsEnable = null,
            Bool32? extendedDynamicState3ColorBlendAdvanced = null,
            Bool32? extendedDynamicState3ProvokingVertexMode = null,
            Bool32? extendedDynamicState3LineRasterizationMode = null,
            Bool32? extendedDynamicState3LineStippleEnable = null,
            Bool32? extendedDynamicState3DepthClipNegativeOneToOne = null,
            Bool32? extendedDynamicState3ViewportWScalingEnable = null,
            Bool32? extendedDynamicState3ViewportSwizzle = null,
            Bool32? extendedDynamicState3CoverageToColorEnable = null,
            Bool32? extendedDynamicState3CoverageToColorLocation = null,
            Bool32? extendedDynamicState3CoverageModulationMode = null,
            Bool32? extendedDynamicState3CoverageModulationTableEnable = null,
            Bool32? extendedDynamicState3CoverageModulationTable = null,
            Bool32? extendedDynamicState3CoverageReductionMode = null,
            Bool32? extendedDynamicState3RepresentativeFragmentTestEnable = null,
            Bool32? extendedDynamicState3ShadingRateImageEnable = null
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

            if (extendedDynamicState3TessellationDomainOrigin is not null)
            {
                ExtendedDynamicState3TessellationDomainOrigin = extendedDynamicState3TessellationDomainOrigin.Value;
            }

            if (extendedDynamicState3DepthClampEnable is not null)
            {
                ExtendedDynamicState3DepthClampEnable = extendedDynamicState3DepthClampEnable.Value;
            }

            if (extendedDynamicState3PolygonMode is not null)
            {
                ExtendedDynamicState3PolygonMode = extendedDynamicState3PolygonMode.Value;
            }

            if (extendedDynamicState3RasterizationSamples is not null)
            {
                ExtendedDynamicState3RasterizationSamples = extendedDynamicState3RasterizationSamples.Value;
            }

            if (extendedDynamicState3SampleMask is not null)
            {
                ExtendedDynamicState3SampleMask = extendedDynamicState3SampleMask.Value;
            }

            if (extendedDynamicState3AlphaToCoverageEnable is not null)
            {
                ExtendedDynamicState3AlphaToCoverageEnable = extendedDynamicState3AlphaToCoverageEnable.Value;
            }

            if (extendedDynamicState3AlphaToOneEnable is not null)
            {
                ExtendedDynamicState3AlphaToOneEnable = extendedDynamicState3AlphaToOneEnable.Value;
            }

            if (extendedDynamicState3LogicOpEnable is not null)
            {
                ExtendedDynamicState3LogicOpEnable = extendedDynamicState3LogicOpEnable.Value;
            }

            if (extendedDynamicState3ColorBlendEnable is not null)
            {
                ExtendedDynamicState3ColorBlendEnable = extendedDynamicState3ColorBlendEnable.Value;
            }

            if (extendedDynamicState3ColorBlendEquation is not null)
            {
                ExtendedDynamicState3ColorBlendEquation = extendedDynamicState3ColorBlendEquation.Value;
            }

            if (extendedDynamicState3ColorWriteMask is not null)
            {
                ExtendedDynamicState3ColorWriteMask = extendedDynamicState3ColorWriteMask.Value;
            }

            if (extendedDynamicState3RasterizationStream is not null)
            {
                ExtendedDynamicState3RasterizationStream = extendedDynamicState3RasterizationStream.Value;
            }

            if (extendedDynamicState3ConservativeRasterizationMode is not null)
            {
                ExtendedDynamicState3ConservativeRasterizationMode = extendedDynamicState3ConservativeRasterizationMode.Value;
            }

            if (extendedDynamicState3ExtraPrimitiveOverestimationSize is not null)
            {
                ExtendedDynamicState3ExtraPrimitiveOverestimationSize = extendedDynamicState3ExtraPrimitiveOverestimationSize.Value;
            }

            if (extendedDynamicState3DepthClipEnable is not null)
            {
                ExtendedDynamicState3DepthClipEnable = extendedDynamicState3DepthClipEnable.Value;
            }

            if (extendedDynamicState3SampleLocationsEnable is not null)
            {
                ExtendedDynamicState3SampleLocationsEnable = extendedDynamicState3SampleLocationsEnable.Value;
            }

            if (extendedDynamicState3ColorBlendAdvanced is not null)
            {
                ExtendedDynamicState3ColorBlendAdvanced = extendedDynamicState3ColorBlendAdvanced.Value;
            }

            if (extendedDynamicState3ProvokingVertexMode is not null)
            {
                ExtendedDynamicState3ProvokingVertexMode = extendedDynamicState3ProvokingVertexMode.Value;
            }

            if (extendedDynamicState3LineRasterizationMode is not null)
            {
                ExtendedDynamicState3LineRasterizationMode = extendedDynamicState3LineRasterizationMode.Value;
            }

            if (extendedDynamicState3LineStippleEnable is not null)
            {
                ExtendedDynamicState3LineStippleEnable = extendedDynamicState3LineStippleEnable.Value;
            }

            if (extendedDynamicState3DepthClipNegativeOneToOne is not null)
            {
                ExtendedDynamicState3DepthClipNegativeOneToOne = extendedDynamicState3DepthClipNegativeOneToOne.Value;
            }

            if (extendedDynamicState3ViewportWScalingEnable is not null)
            {
                ExtendedDynamicState3ViewportWScalingEnable = extendedDynamicState3ViewportWScalingEnable.Value;
            }

            if (extendedDynamicState3ViewportSwizzle is not null)
            {
                ExtendedDynamicState3ViewportSwizzle = extendedDynamicState3ViewportSwizzle.Value;
            }

            if (extendedDynamicState3CoverageToColorEnable is not null)
            {
                ExtendedDynamicState3CoverageToColorEnable = extendedDynamicState3CoverageToColorEnable.Value;
            }

            if (extendedDynamicState3CoverageToColorLocation is not null)
            {
                ExtendedDynamicState3CoverageToColorLocation = extendedDynamicState3CoverageToColorLocation.Value;
            }

            if (extendedDynamicState3CoverageModulationMode is not null)
            {
                ExtendedDynamicState3CoverageModulationMode = extendedDynamicState3CoverageModulationMode.Value;
            }

            if (extendedDynamicState3CoverageModulationTableEnable is not null)
            {
                ExtendedDynamicState3CoverageModulationTableEnable = extendedDynamicState3CoverageModulationTableEnable.Value;
            }

            if (extendedDynamicState3CoverageModulationTable is not null)
            {
                ExtendedDynamicState3CoverageModulationTable = extendedDynamicState3CoverageModulationTable.Value;
            }

            if (extendedDynamicState3CoverageReductionMode is not null)
            {
                ExtendedDynamicState3CoverageReductionMode = extendedDynamicState3CoverageReductionMode.Value;
            }

            if (extendedDynamicState3RepresentativeFragmentTestEnable is not null)
            {
                ExtendedDynamicState3RepresentativeFragmentTestEnable = extendedDynamicState3RepresentativeFragmentTestEnable.Value;
            }

            if (extendedDynamicState3ShadingRateImageEnable is not null)
            {
                ExtendedDynamicState3ShadingRateImageEnable = extendedDynamicState3ShadingRateImageEnable.Value;
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
        [NativeName("Name", "extendedDynamicState3TessellationDomainOrigin")]
        public Bool32 ExtendedDynamicState3TessellationDomainOrigin;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3DepthClampEnable")]
        public Bool32 ExtendedDynamicState3DepthClampEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3PolygonMode")]
        public Bool32 ExtendedDynamicState3PolygonMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3RasterizationSamples")]
        public Bool32 ExtendedDynamicState3RasterizationSamples;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3SampleMask")]
        public Bool32 ExtendedDynamicState3SampleMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3AlphaToCoverageEnable")]
        public Bool32 ExtendedDynamicState3AlphaToCoverageEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3AlphaToOneEnable")]
        public Bool32 ExtendedDynamicState3AlphaToOneEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3LogicOpEnable")]
        public Bool32 ExtendedDynamicState3LogicOpEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ColorBlendEnable")]
        public Bool32 ExtendedDynamicState3ColorBlendEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ColorBlendEquation")]
        public Bool32 ExtendedDynamicState3ColorBlendEquation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ColorWriteMask")]
        public Bool32 ExtendedDynamicState3ColorWriteMask;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3RasterizationStream")]
        public Bool32 ExtendedDynamicState3RasterizationStream;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ConservativeRasterizationMode")]
        public Bool32 ExtendedDynamicState3ConservativeRasterizationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ExtraPrimitiveOverestimationSize")]
        public Bool32 ExtendedDynamicState3ExtraPrimitiveOverestimationSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3DepthClipEnable")]
        public Bool32 ExtendedDynamicState3DepthClipEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3SampleLocationsEnable")]
        public Bool32 ExtendedDynamicState3SampleLocationsEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ColorBlendAdvanced")]
        public Bool32 ExtendedDynamicState3ColorBlendAdvanced;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ProvokingVertexMode")]
        public Bool32 ExtendedDynamicState3ProvokingVertexMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3LineRasterizationMode")]
        public Bool32 ExtendedDynamicState3LineRasterizationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3LineStippleEnable")]
        public Bool32 ExtendedDynamicState3LineStippleEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3DepthClipNegativeOneToOne")]
        public Bool32 ExtendedDynamicState3DepthClipNegativeOneToOne;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ViewportWScalingEnable")]
        public Bool32 ExtendedDynamicState3ViewportWScalingEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ViewportSwizzle")]
        public Bool32 ExtendedDynamicState3ViewportSwizzle;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageToColorEnable")]
        public Bool32 ExtendedDynamicState3CoverageToColorEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageToColorLocation")]
        public Bool32 ExtendedDynamicState3CoverageToColorLocation;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageModulationMode")]
        public Bool32 ExtendedDynamicState3CoverageModulationMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageModulationTableEnable")]
        public Bool32 ExtendedDynamicState3CoverageModulationTableEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageModulationTable")]
        public Bool32 ExtendedDynamicState3CoverageModulationTable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3CoverageReductionMode")]
        public Bool32 ExtendedDynamicState3CoverageReductionMode;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3RepresentativeFragmentTestEnable")]
        public Bool32 ExtendedDynamicState3RepresentativeFragmentTestEnable;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "extendedDynamicState3ShadingRateImageEnable")]
        public Bool32 ExtendedDynamicState3ShadingRateImageEnable;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceExtendedDynamicState3FeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
