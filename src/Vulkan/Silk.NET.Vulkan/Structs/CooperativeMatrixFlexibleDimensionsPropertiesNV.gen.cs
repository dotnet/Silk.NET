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
    [NativeName("Name", "VkCooperativeMatrixFlexibleDimensionsPropertiesNV")]
    public unsafe partial struct CooperativeMatrixFlexibleDimensionsPropertiesNV : IChainable
    {
        public CooperativeMatrixFlexibleDimensionsPropertiesNV
        (
            StructureType? sType = StructureType.CooperativeMatrixFlexibleDimensionsPropertiesNV,
            void* pNext = null,
            uint? mGranularity = null,
            uint? nGranularity = null,
            uint? kGranularity = null,
            ComponentTypeKHR? aType = null,
            ComponentTypeKHR? bType = null,
            ComponentTypeKHR? cType = null,
            ComponentTypeKHR? resultType = null,
            Bool32? saturatingAccumulation = null,
            ScopeKHR? scope = null,
            uint? workgroupInvocations = null
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

            if (mGranularity is not null)
            {
                MGranularity = mGranularity.Value;
            }

            if (nGranularity is not null)
            {
                NGranularity = nGranularity.Value;
            }

            if (kGranularity is not null)
            {
                KGranularity = kGranularity.Value;
            }

            if (aType is not null)
            {
                AType = aType.Value;
            }

            if (bType is not null)
            {
                BType = bType.Value;
            }

            if (cType is not null)
            {
                CType = cType.Value;
            }

            if (resultType is not null)
            {
                ResultType = resultType.Value;
            }

            if (saturatingAccumulation is not null)
            {
                SaturatingAccumulation = saturatingAccumulation.Value;
            }

            if (scope is not null)
            {
                Scope = scope.Value;
            }

            if (workgroupInvocations is not null)
            {
                WorkgroupInvocations = workgroupInvocations.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "MGranularity")]
        public uint MGranularity;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "NGranularity")]
        public uint NGranularity;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "KGranularity")]
        public uint KGranularity;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "AType")]
        public ComponentTypeKHR AType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "BType")]
        public ComponentTypeKHR BType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "CType")]
        public ComponentTypeKHR CType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "ResultType")]
        public ComponentTypeKHR ResultType;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "saturatingAccumulation")]
        public Bool32 SaturatingAccumulation;
/// <summary></summary>
        [NativeName("Type", "VkScopeKHR")]
        [NativeName("Type.Name", "VkScopeKHR")]
        [NativeName("Name", "scope")]
        public ScopeKHR Scope;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "workgroupInvocations")]
        public uint WorkgroupInvocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CooperativeMatrixFlexibleDimensionsPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
