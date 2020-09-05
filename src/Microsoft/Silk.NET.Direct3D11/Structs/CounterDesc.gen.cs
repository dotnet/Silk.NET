// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_COUNTER_DESC")]
    public unsafe partial struct CounterDesc
    {
        public CounterDesc
        (
            Counter counter = default,
            uint miscFlags = default
        )
        {
            Counter = counter;
            MiscFlags = miscFlags;
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
