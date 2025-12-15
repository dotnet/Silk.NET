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
    [NativeName("Name", "D3D12_COMPILER_CACHE_GROUP_KEY")]
    public unsafe partial struct CompilerCacheGroupKey
    {
        public CompilerCacheGroupKey
        (
            void* pKey = null,
            uint? keySize = null
        ) : this()
        {
            if (pKey is not null)
            {
                PKey = pKey;
            }

            if (keySize is not null)
            {
                KeySize = keySize.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pKey")]
        public void* PKey;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "KeySize")]
        public uint KeySize;
    }
}
