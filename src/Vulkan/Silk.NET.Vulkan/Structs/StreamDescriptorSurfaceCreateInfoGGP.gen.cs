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
    [NativeName("Name", "VkStreamDescriptorSurfaceCreateInfoGGP")]
    public unsafe partial struct StreamDescriptorSurfaceCreateInfoGGP : IChainable
    {
        public StreamDescriptorSurfaceCreateInfoGGP
        (
            StructureType? sType = StructureType.StreamDescriptorSurfaceCreateInfoGgp,
            void* pNext = null,
            uint? flags = null,
            nint? streamDescriptor = null
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

            if (streamDescriptor is not null)
            {
                StreamDescriptor = streamDescriptor.Value;
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
        [NativeName("Type", "VkStreamDescriptorSurfaceCreateFlagsGGP")]
        [NativeName("Type.Name", "VkStreamDescriptorSurfaceCreateFlagsGGP")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "GgpStreamDescriptor")]
        [NativeName("Type.Name", "GgpStreamDescriptor")]
        [NativeName("Name", "streamDescriptor")]
        public nint StreamDescriptor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.StreamDescriptorSurfaceCreateInfoGgp;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
