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
    [NativeName("Name", "_D3D11_AES_CTR_IV")]
    public unsafe partial struct AesCtrIV
    {
        public AesCtrIV
        (
            ulong? iV = null,
            ulong? count = null
        ) : this()
        {
            if (iV is not null)
            {
                IV = iV.Value;
            }

            if (count is not null)
            {
                Count = count.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "IV")]
        public ulong IV;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Count")]
        public ulong Count;
    }
}
