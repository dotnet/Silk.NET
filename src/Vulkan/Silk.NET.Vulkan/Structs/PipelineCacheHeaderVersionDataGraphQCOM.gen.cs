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
    [NativeName("Name", "VkPipelineCacheHeaderVersionDataGraphQCOM")]
    public unsafe partial struct PipelineCacheHeaderVersionDataGraphQCOM
    {
        public PipelineCacheHeaderVersionDataGraphQCOM
        (
            uint? headerSize = null,
            PipelineCacheHeaderVersion? headerVersion = null,
            DataGraphModelCacheTypeQCOM? cacheType = null,
            uint? cacheVersion = null
        ) : this()
        {
            if (headerSize is not null)
            {
                HeaderSize = headerSize.Value;
            }

            if (headerVersion is not null)
            {
                HeaderVersion = headerVersion.Value;
            }

            if (cacheType is not null)
            {
                CacheType = cacheType.Value;
            }

            if (cacheVersion is not null)
            {
                CacheVersion = cacheVersion.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "headerSize")]
        public uint HeaderSize;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCacheHeaderVersion")]
        [NativeName("Type.Name", "VkPipelineCacheHeaderVersion")]
        [NativeName("Name", "headerVersion")]
        public PipelineCacheHeaderVersion HeaderVersion;
/// <summary></summary>
        [NativeName("Type", "VkDataGraphModelCacheTypeQCOM")]
        [NativeName("Type.Name", "VkDataGraphModelCacheTypeQCOM")]
        [NativeName("Name", "cacheType")]
        public DataGraphModelCacheTypeQCOM CacheType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cacheVersion")]
        public uint CacheVersion;
        /// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "toolchainVersion")]
        public fixed uint ToolchainVersion[3];
    }
}
