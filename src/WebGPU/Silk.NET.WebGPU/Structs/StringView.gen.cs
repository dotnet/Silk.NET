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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUStringView")]
    public unsafe partial struct StringView
    {
        public StringView
        (
            byte* data = null,
            nuint? length = null
        ) : this()
        {
            if (data is not null)
            {
                Data = data;
            }

            if (length is not null)
            {
                Length = length.Value;
            }
        }


        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "data")]
        public byte* Data;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "length")]
        public nuint Length;
    }
}
