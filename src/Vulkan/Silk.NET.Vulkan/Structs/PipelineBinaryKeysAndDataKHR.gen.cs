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
    [NativeName("Name", "VkPipelineBinaryKeysAndDataKHR")]
    public unsafe partial struct PipelineBinaryKeysAndDataKHR
    {
        public PipelineBinaryKeysAndDataKHR
        (
            uint? binaryCount = null,
            PipelineBinaryKeyKHR* pPipelineBinaryKeys = null,
            PipelineBinaryDataKHR* pPipelineBinaryData = null
        ) : this()
        {
            if (binaryCount is not null)
            {
                BinaryCount = binaryCount.Value;
            }

            if (pPipelineBinaryKeys is not null)
            {
                PPipelineBinaryKeys = pPipelineBinaryKeys;
            }

            if (pPipelineBinaryData is not null)
            {
                PPipelineBinaryData = pPipelineBinaryData;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "binaryCount")]
        public uint BinaryCount;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBinaryKeyKHR*")]
        [NativeName("Type.Name", "VkPipelineBinaryKeyKHR")]
        [NativeName("Name", "pPipelineBinaryKeys")]
        public PipelineBinaryKeyKHR* PPipelineBinaryKeys;
/// <summary></summary>
        [NativeName("Type", "VkPipelineBinaryDataKHR*")]
        [NativeName("Type.Name", "VkPipelineBinaryDataKHR")]
        [NativeName("Name", "pPipelineBinaryData")]
        public PipelineBinaryDataKHR* PPipelineBinaryData;
    }
}
