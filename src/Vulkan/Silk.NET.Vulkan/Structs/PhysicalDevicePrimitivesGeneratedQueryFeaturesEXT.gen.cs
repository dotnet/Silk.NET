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
    [NativeName("Name", "VkPhysicalDevicePrimitivesGeneratedQueryFeaturesEXT")]
    public unsafe partial struct PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDevicePrimitivesGeneratedQueryFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDevicePrimitivesGeneratedQueryFeaturesExt,
            void* pNext = null,
            Bool32? primitivesGeneratedQuery = null,
            Bool32? primitivesGeneratedQueryWithRasterizerDiscard = null,
            Bool32? primitivesGeneratedQueryWithNonZeroStreams = null
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

            if (primitivesGeneratedQuery is not null)
            {
                PrimitivesGeneratedQuery = primitivesGeneratedQuery.Value;
            }

            if (primitivesGeneratedQueryWithRasterizerDiscard is not null)
            {
                PrimitivesGeneratedQueryWithRasterizerDiscard = primitivesGeneratedQueryWithRasterizerDiscard.Value;
            }

            if (primitivesGeneratedQueryWithNonZeroStreams is not null)
            {
                PrimitivesGeneratedQueryWithNonZeroStreams = primitivesGeneratedQueryWithNonZeroStreams.Value;
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
        [NativeName("Name", "primitivesGeneratedQuery")]
        public Bool32 PrimitivesGeneratedQuery;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitivesGeneratedQueryWithRasterizerDiscard")]
        public Bool32 PrimitivesGeneratedQueryWithRasterizerDiscard;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitivesGeneratedQueryWithNonZeroStreams")]
        public Bool32 PrimitivesGeneratedQueryWithNonZeroStreams;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDevicePrimitivesGeneratedQueryFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
