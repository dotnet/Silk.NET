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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_CUSTOM_DECOMPRESSION_RESULT")]
    public unsafe partial struct CustomDecompressionResult
    {
        public CustomDecompressionResult
        (
            ulong? id = null,
            int? result = null
        ) : this()
        {
            if (id is not null)
            {
                Id = id.Value;
            }

            if (result is not null)
            {
                Result = result.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Id")]
        public ulong Id;

        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "Result")]
        public int Result;
    }
}
