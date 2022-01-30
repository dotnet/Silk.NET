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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_SHADER_CACHE_SESSION_DESC")]
    public unsafe partial struct ShaderCacheSessionDesc
    {
        public ShaderCacheSessionDesc
        (
            Guid? identifier = null,
            ShaderCacheMode? mode = null,
            ShaderCacheFlags? flags = null,
            uint? maximumInMemoryCacheSizeBytes = null,
            uint? maximumInMemoryCacheEntries = null,
            uint? maximumValueFileSizeBytes = null,
            ulong? version = null
        ) : this()
        {
            if (identifier is not null)
            {
                Identifier = identifier.Value;
            }

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (maximumInMemoryCacheSizeBytes is not null)
            {
                MaximumInMemoryCacheSizeBytes = maximumInMemoryCacheSizeBytes.Value;
            }

            if (maximumInMemoryCacheEntries is not null)
            {
                MaximumInMemoryCacheEntries = maximumInMemoryCacheEntries.Value;
            }

            if (maximumValueFileSizeBytes is not null)
            {
                MaximumValueFileSizeBytes = maximumValueFileSizeBytes.Value;
            }

            if (version is not null)
            {
                Version = version.Value;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "Identifier")]
        public Guid Identifier;

        [NativeName("Type", "D3D12_SHADER_CACHE_MODE")]
        [NativeName("Type.Name", "D3D12_SHADER_CACHE_MODE")]
        [NativeName("Name", "Mode")]
        public ShaderCacheMode Mode;

        [NativeName("Type", "D3D12_SHADER_CACHE_FLAGS")]
        [NativeName("Type.Name", "D3D12_SHADER_CACHE_FLAGS")]
        [NativeName("Name", "Flags")]
        public ShaderCacheFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaximumInMemoryCacheSizeBytes")]
        public uint MaximumInMemoryCacheSizeBytes;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaximumInMemoryCacheEntries")]
        public uint MaximumInMemoryCacheEntries;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MaximumValueFileSizeBytes")]
        public uint MaximumValueFileSizeBytes;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Version")]
        public ulong Version;
    }
}
