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
    [NativeName("Name", "VkCooperativeMatrixPropertiesKHR")]
    public unsafe partial struct CooperativeMatrixPropertiesKHR : IChainable
    {
        public CooperativeMatrixPropertiesKHR
        (
            StructureType? sType = StructureType.CooperativeMatrixPropertiesKhr,
            void* pNext = null,
            uint? mSize = null,
            uint? nSize = null,
            uint? kSize = null,
            ComponentTypeKHR? aType = null,
            ComponentTypeKHR? bType = null,
            ComponentTypeKHR? cType = null,
            ComponentTypeKHR? resultType = null,
            Bool32? saturatingAccumulation = null,
            ScopeKHR? scope = null
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

            if (mSize is not null)
            {
                MSize = mSize.Value;
            }

            if (nSize is not null)
            {
                NSize = nSize.Value;
            }

            if (kSize is not null)
            {
                KSize = kSize.Value;
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
        [NativeName("Name", "MSize")]
        public uint MSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "NSize")]
        public uint NSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "KSize")]
        public uint KSize;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CooperativeMatrixPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
