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
    [NativeName("Name", "D3D12_COMPILER_CACHE_CONST_VALUE")]
    public unsafe partial struct CompilerCacheConstValue
    {
        public CompilerCacheConstValue
        (
            void* pValue = null,
            uint? valueSize = null
        ) : this()
        {
            if (pValue is not null)
            {
                PValue = pValue;
            }

            if (valueSize is not null)
            {
                ValueSize = valueSize.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pValue")]
        public void* PValue;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ValueSize")]
        public uint ValueSize;
    }
}
