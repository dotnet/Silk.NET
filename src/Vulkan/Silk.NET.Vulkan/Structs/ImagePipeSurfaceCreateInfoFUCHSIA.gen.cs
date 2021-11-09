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
    [NativeName("Name", "VkImagePipeSurfaceCreateInfoFUCHSIA")]
    public unsafe partial struct ImagePipeSurfaceCreateInfoFUCHSIA : IChainable
    {
        public ImagePipeSurfaceCreateInfoFUCHSIA
        (
            StructureType? sType = StructureType.ImagepipeSurfaceCreateInfoFuchsia,
            void* pNext = null,
            uint? flags = null,
            nint? imagePipeHandle = null
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

            if (imagePipeHandle is not null)
            {
                ImagePipeHandle = imagePipeHandle.Value;
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
        [NativeName("Type", "VkImagePipeSurfaceCreateFlagsFUCHSIA")]
        [NativeName("Type.Name", "VkImagePipeSurfaceCreateFlagsFUCHSIA")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "zx_handle_t")]
        [NativeName("Type.Name", "zx_handle_t")]
        [NativeName("Name", "imagePipeHandle")]
        public nint ImagePipeHandle;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImagepipeSurfaceCreateInfoFuchsia;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
