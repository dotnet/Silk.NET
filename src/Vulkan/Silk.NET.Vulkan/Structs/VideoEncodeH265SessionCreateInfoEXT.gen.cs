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
    [NativeName("Name", "VkVideoEncodeH265SessionCreateInfoEXT")]
    public unsafe partial struct VideoEncodeH265SessionCreateInfoEXT : IExtendsChain<VideoSessionCreateInfoKHR>
    {
        public VideoEncodeH265SessionCreateInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265SessionCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            ExtensionProperties* pStdExtensionVersion = null
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

            if (pStdExtensionVersion is not null)
            {
                PStdExtensionVersion = pStdExtensionVersion;
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
        [NativeName("Type", "VkVideoEncodeH265CreateFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265CreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkExtensionProperties*")]
        [NativeName("Type.Name", "VkExtensionProperties")]
        [NativeName("Name", "pStdExtensionVersion")]
        public ExtensionProperties* PStdExtensionVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265SessionCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
