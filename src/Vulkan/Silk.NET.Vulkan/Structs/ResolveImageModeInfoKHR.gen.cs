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
    [NativeName("Name", "VkResolveImageModeInfoKHR")]
    public unsafe partial struct ResolveImageModeInfoKHR : IExtendsChain<ResolveImageInfo2>, IExtendsChain<ResolveImageInfo2KHR>
    {
        public ResolveImageModeInfoKHR
        (
            StructureType? sType = StructureType.ResolveImageModeInfoKhr,
            void* pNext = null,
            ResolveImageFlagsKHR? flags = null,
            ResolveModeFlags? resolveMode = null,
            ResolveModeFlags? stencilResolveMode = null
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

            if (resolveMode is not null)
            {
                ResolveMode = resolveMode.Value;
            }

            if (stencilResolveMode is not null)
            {
                StencilResolveMode = stencilResolveMode.Value;
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
        [NativeName("Type", "VkResolveImageFlagsKHR")]
        [NativeName("Type.Name", "VkResolveImageFlagsKHR")]
        [NativeName("Name", "flags")]
        public ResolveImageFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "resolveMode")]
        public ResolveModeFlags ResolveMode;
/// <summary></summary>
        [NativeName("Type", "VkResolveModeFlagBits")]
        [NativeName("Type.Name", "VkResolveModeFlagBits")]
        [NativeName("Name", "stencilResolveMode")]
        public ResolveModeFlags StencilResolveMode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ResolveImageModeInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
