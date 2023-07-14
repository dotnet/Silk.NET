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
    [NativeName("Name", "VkPipelineCacheStageValidationIndexEntry")]
    public unsafe partial struct PipelineCacheStageValidationIndexEntry
    {
        public PipelineCacheStageValidationIndexEntry
        (
            ulong? codeSize = null,
            ulong? codeOffset = null
        ) : this()
        {
            if (codeSize is not null)
            {
                CodeSize = codeSize.Value;
            }

            if (codeOffset is not null)
            {
                CodeOffset = codeOffset.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "codeSize")]
        public ulong CodeSize;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "codeOffset")]
        public ulong CodeOffset;
    }
}
