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
    [NativeName("Name", "VkCopyMicromapInfoEXT")]
    public unsafe partial struct CopyMicromapInfoEXT : IChainable
    {
        public CopyMicromapInfoEXT
        (
            StructureType? sType = StructureType.CopyMicromapInfoExt,
            void* pNext = null,
            MicromapEXT? src = null,
            MicromapEXT? dst = null,
            CopyMicromapModeEXT? mode = null
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

            if (src is not null)
            {
                Src = src.Value;
            }

            if (dst is not null)
            {
                Dst = dst.Value;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
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
        [NativeName("Type", "VkMicromapEXT")]
        [NativeName("Type.Name", "VkMicromapEXT")]
        [NativeName("Name", "src")]
        public MicromapEXT Src;
/// <summary></summary>
        [NativeName("Type", "VkMicromapEXT")]
        [NativeName("Type.Name", "VkMicromapEXT")]
        [NativeName("Name", "dst")]
        public MicromapEXT Dst;
/// <summary></summary>
        [NativeName("Type", "VkCopyMicromapModeEXT")]
        [NativeName("Type.Name", "VkCopyMicromapModeEXT")]
        [NativeName("Name", "mode")]
        public CopyMicromapModeEXT Mode;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CopyMicromapInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
