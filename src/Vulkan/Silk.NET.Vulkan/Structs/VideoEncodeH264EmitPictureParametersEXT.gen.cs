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
    [NativeName("Name", "VkVideoEncodeH264EmitPictureParametersEXT")]
    public unsafe partial struct VideoEncodeH264EmitPictureParametersEXT : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeH264EmitPictureParametersEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264EmitPictureParametersExt,
            void* pNext = null,
            byte? spsId = null,
            Bool32? emitSpsEnable = null,
            uint? ppsIdEntryCount = null,
            byte* ppsIdEntries = null
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

            if (spsId is not null)
            {
                SpsId = spsId.Value;
            }

            if (emitSpsEnable is not null)
            {
                EmitSpsEnable = emitSpsEnable.Value;
            }

            if (ppsIdEntryCount is not null)
            {
                PpsIdEntryCount = ppsIdEntryCount.Value;
            }

            if (ppsIdEntries is not null)
            {
                PpsIdEntries = ppsIdEntries;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "spsId")]
        public byte SpsId;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "emitSpsEnable")]
        public Bool32 EmitSpsEnable;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "ppsIdEntryCount")]
        public uint PpsIdEntryCount;
/// <summary></summary>
        [NativeName("Type", "uint8_t*")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "ppsIdEntries")]
        public byte* PpsIdEntries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264EmitPictureParametersExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
