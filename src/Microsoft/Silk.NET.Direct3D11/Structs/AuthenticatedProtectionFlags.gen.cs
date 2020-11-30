// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "D3D11_AUTHENTICATED_PROTECTION_FLAGS")]
    public unsafe partial struct AuthenticatedProtectionFlags
    {
        public AuthenticatedProtectionFlags
        (
            MIDLMIDLItfD3d11000000340001? flags = null,
            uint? value = null
        ) : this()
        {
            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "struct __MIDL___MIDL_itf_d3d11_0000_0034_0001")]
        [NativeName("Type.Name", "struct __MIDL___MIDL_itf_d3d11_0000_0034_0001")]
        [NativeName("Name", "Flags")]
        public MIDLMIDLItfD3d11000000340001 Flags;

        [FieldOffset(0)]
        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Value")]
        public uint Value;
    }
}
