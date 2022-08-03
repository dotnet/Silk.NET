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
    [NativeName("Name", "VkTilePropertiesQCOM")]
    public unsafe partial struct TilePropertiesQCOM : IChainable
    {
        public TilePropertiesQCOM
        (
            StructureType? sType = StructureType.TilePropertiesQCom,
            void* pNext = null,
            Extent3D? tileSize = null,
            Extent2D? apronSize = null,
            Offset2D? origin = null
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

            if (tileSize is not null)
            {
                TileSize = tileSize.Value;
            }

            if (apronSize is not null)
            {
                ApronSize = apronSize.Value;
            }

            if (origin is not null)
            {
                Origin = origin.Value;
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
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "tileSize")]
        public Extent3D TileSize;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "apronSize")]
        public Extent2D ApronSize;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "origin")]
        public Offset2D Origin;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.TilePropertiesQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
