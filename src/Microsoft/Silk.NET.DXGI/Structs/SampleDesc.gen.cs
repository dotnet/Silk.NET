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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_SAMPLE_DESC")]
    public unsafe partial struct SampleDesc
    {
        public SampleDesc
        (
            uint? count = null,
            uint? quality = null
        ) : this()
        {
            if (count is not null)
            {
                Count = count.Value;
            }

            if (quality is not null)
            {
                Quality = quality.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Count")]
        public uint Count;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Quality")]
        public uint Quality;
    }
}
