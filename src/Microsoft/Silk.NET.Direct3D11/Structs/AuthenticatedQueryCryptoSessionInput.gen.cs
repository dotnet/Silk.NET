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
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_INPUT")]
    public unsafe partial struct AuthenticatedQueryCryptoSessionInput
    {
        public AuthenticatedQueryCryptoSessionInput
        (
            AuthenticatedQueryInput? input = null,
            void* decoderHandle = null
        ) : this()
        {
            if (input is not null)
            {
                Input = input.Value;
            }

            if (decoderHandle is not null)
            {
                DecoderHandle = decoderHandle;
            }
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_INPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_INPUT")]
        [NativeName("Name", "Input")]
        public AuthenticatedQueryInput Input;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DecoderHandle")]
        public void* DecoderHandle;
    }
}
