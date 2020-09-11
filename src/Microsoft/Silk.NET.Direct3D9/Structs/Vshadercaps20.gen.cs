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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DVSHADERCAPS2_0")]
    public unsafe partial struct Vshadercaps20
    {
        public Vshadercaps20
        (
            uint caps = default,
            int dynamicFlowControlDepth = default,
            int numTemps = default,
            int staticFlowControlDepth = default
        )
        {
            Caps = caps;
            DynamicFlowControlDepth = dynamicFlowControlDepth;
            NumTemps = numTemps;
            StaticFlowControlDepth = staticFlowControlDepth;
        }


        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "Caps")]
        public uint Caps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "DynamicFlowControlDepth")]
        public int DynamicFlowControlDepth;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "NumTemps")]
        public int NumTemps;

        [NativeName("Type", "INT")]
        [NativeName("Type.Name", "INT")]
        [NativeName("Name", "StaticFlowControlDepth")]
        public int StaticFlowControlDepth;
    }
}
