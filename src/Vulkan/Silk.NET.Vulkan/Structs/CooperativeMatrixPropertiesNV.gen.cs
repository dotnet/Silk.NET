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
    [NativeName("Name", "VkCooperativeMatrixPropertiesNV")]
    public unsafe partial struct CooperativeMatrixPropertiesNV : IChainable
    {
        public CooperativeMatrixPropertiesNV
        (
            StructureType? sType = StructureType.CooperativeMatrixPropertiesNV,
            void* pNext = null,
            uint? mSize = null,
            uint? nSize = null,
            uint? kSize = null,
            ComponentTypeNV? aType = null,
            ComponentTypeNV? bType = null,
            ComponentTypeNV? cType = null,
            ComponentTypeNV? dType = null,
            ScopeNV? scope = null
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

            if (dType is not null)
            {
                DType = dType.Value;
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
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "AType")]
        public ComponentTypeNV AType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "BType")]
        public ComponentTypeNV BType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "CType")]
        public ComponentTypeNV CType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeNV")]
        [NativeName("Type.Name", "VkComponentTypeNV")]
        [NativeName("Name", "DType")]
        public ComponentTypeNV DType;
/// <summary></summary>
        [NativeName("Type", "VkScopeNV")]
        [NativeName("Type.Name", "VkScopeNV")]
        [NativeName("Name", "scope")]
        public ScopeNV Scope;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CooperativeMatrixPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
