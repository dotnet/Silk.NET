// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_QUERY_DESC")]
    public unsafe partial struct CD3D11QueryDesc
    {
        public CD3D11QueryDesc
        (
            Query? query = null,
            uint? miscFlags = null
        ) : this()
        {
            if (query is not null)
            {
                Query = query.Value;
            }

            if (miscFlags is not null)
            {
                MiscFlags = miscFlags.Value;
            }
        }


        [NativeName("Type", "D3D11_QUERY")]
        [NativeName("Type.Name", "D3D11_QUERY")]
        [NativeName("Name", "Query")]
        public Query Query;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;
    }
}
