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
    [NativeName("Name", "VkXlibSurfaceCreateInfoKHR")]
    public unsafe partial struct XlibSurfaceCreateInfoKHR : IChainable
    {
        public XlibSurfaceCreateInfoKHR
        (
            StructureType? sType = StructureType.XlibSurfaceCreateInfoKhr,
            void* pNext = null,
            uint? flags = null,
            nint* dpy = null,
            nint? window = null
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

            if (dpy is not null)
            {
                Dpy = dpy;
            }

            if (window is not null)
            {
                Window = window.Value;
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
        [NativeName("Type", "VkXlibSurfaceCreateFlagsKHR")]
        [NativeName("Type.Name", "VkXlibSurfaceCreateFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "Display*")]
        [NativeName("Type.Name", "Display")]
        [NativeName("Name", "dpy")]
        public nint* Dpy;
/// <summary></summary>
        [NativeName("Type", "Window")]
        [NativeName("Type.Name", "Window")]
        [NativeName("Name", "window")]
        public nint Window;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.XlibSurfaceCreateInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
