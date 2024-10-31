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
    [NativeName("Name", "VkWaylandSurfaceCreateInfoKHR")]
    public unsafe partial struct WaylandSurfaceCreateInfoKHR : IChainable
    {
        public WaylandSurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.WaylandSurfaceCreateInfoKhr,
            void* pNext = null,
            WaylandSurfaceCreateFlagsKHR? flags = null,
            nint* display = null,
            nint* surface = null
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

            if (display is not null)
            {
                Display = display;
            }

            if (surface is not null)
            {
                Surface = surface;
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
        [NativeName("Type", "VkWaylandSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkWaylandSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public WaylandSurfaceCreateFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "wl_display*")]
        [NativeName("Type.Name", "wl_display")]
        [NativeName("Name", "display")]
        public nint* Display;
/// <summary></summary>
        [NativeName("Type", "wl_surface*")]
        [NativeName("Type.Name", "wl_surface")]
        [NativeName("Name", "surface")]
        public nint* Surface;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.WaylandSurfaceCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
