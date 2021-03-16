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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_COUNTER_DESC")]
    public unsafe partial struct CD3D11CounterDesc
    {
        public CD3D11CounterDesc
        (
            Counter? counter = null,
            uint? miscFlags = null
        ) : this()
        {
            if (counter is not null)
            {
                Counter = counter.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }
        }


        [NativeName("Type", "D3D11_COUNTER")]
        [NativeName("Type.Name", "D3D11_COUNTER")]
        [NativeName("Name", "Counter")]
        public Counter Counter;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;
    }
}
