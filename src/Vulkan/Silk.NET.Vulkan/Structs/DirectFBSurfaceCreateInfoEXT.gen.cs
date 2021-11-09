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
    [NativeName("Name", "VkDirectFBSurfaceCreateInfoEXT")]
    public unsafe partial struct DirectFBSurfaceCreateInfoEXT : IChainable
    {
        public DirectFBSurfaceCreateInfoEXT
        (
            StructureType? sType = StructureType.DirectfbSurfaceCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            nint? dfb = null,
            nint? surface = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (dfb is not null)
            {
                Dfb = dfb.Value;
            }

            if (surface is not null)
            {
                Surface = surface.Value;
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
        [NativeName("Type", "VkDirectFBSurfaceCreateFlagsEXT")]
        [NativeName("Type.Name", "VkDirectFBSurfaceCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "IDirectFB*")]
        [NativeName("Type.Name", "IDirectFB")]
        [NativeName("Name", "dfb")]
        public nint Dfb;
/// <summary></summary>
        [NativeName("Type", "IDirectFBSurface*")]
        [NativeName("Type.Name", "IDirectFBSurface")]
        [NativeName("Name", "surface")]
        public nint Surface;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DirectfbSurfaceCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
