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
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_UNRESTRICTED_PROTECTED_SHARED_RESOURCE_COUNT_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryUnrestrictedProtectedSharedResourceCountOutput
    {
        public AuthenticatedQueryUnrestrictedProtectedSharedResourceCountOutput
        (
            AuthenticatedQueryOutput? output = null,
            uint? unrestrictedProtectedSharedResourceCount = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (unrestrictedProtectedSharedResourceCount is not null)
            {
                UnrestrictedProtectedSharedResourceCount = unrestrictedProtectedSharedResourceCount.Value;
            }
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "UnrestrictedProtectedSharedResourceCount")]
        public uint UnrestrictedProtectedSharedResourceCount;
    }
}
