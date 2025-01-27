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
    [NativeName("Name", "VkVideoEncodeH264SessionParametersGetInfoKHR")]
    public unsafe partial struct VideoEncodeH264SessionParametersGetInfoKHR : IExtendsChain<VideoEncodeSessionParametersGetInfoKHR>
    {
        public VideoEncodeH264SessionParametersGetInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionParametersGetInfoKhr,
            void* pNext = null,
            Bool32? writeStdSps = null,
            Bool32? writeStdPps = null,
            uint? stdSpsid = null,
            uint? stdPpsid = null
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

            if (writeStdSps is not null)
            {
                WriteStdSps = writeStdSps.Value;
            }

            if (writeStdPps is not null)
            {
                WriteStdPps = writeStdPps.Value;
            }

            if (stdSpsid is not null)
            {
                StdSpsid = stdSpsid.Value;
            }

            if (stdPpsid is not null)
            {
                StdPpsid = stdPpsid.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "writeStdSPS")]
        public Bool32 WriteStdSps;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "writeStdPPS")]
        public Bool32 WriteStdPps;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stdSPSId")]
        public uint StdSpsid;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stdPPSId")]
        public uint StdPpsid;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionParametersGetInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
