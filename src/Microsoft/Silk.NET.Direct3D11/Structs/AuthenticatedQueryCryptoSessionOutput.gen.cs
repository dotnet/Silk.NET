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
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_CRYPTO_SESSION_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryCryptoSessionOutput
    {
        public AuthenticatedQueryCryptoSessionOutput
        (
            AuthenticatedQueryOutput? output = null,
            nint* decoderHandle = null,
            nint* cryptoSessionHandle = null,
            nint* deviceHandle = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (decoderHandle is not null)
            {
                DecoderHandle = decoderHandle;
            }

            if (cryptoSessionHandle is not null)
            {
                CryptoSessionHandle = cryptoSessionHandle;
            }

            if (deviceHandle is not null)
            {
                DeviceHandle = deviceHandle;
            }
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DecoderHandle")]
        public nint* DecoderHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "CryptoSessionHandle")]
        public nint* CryptoSessionHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DeviceHandle")]
        public nint* DeviceHandle;
    }
}
