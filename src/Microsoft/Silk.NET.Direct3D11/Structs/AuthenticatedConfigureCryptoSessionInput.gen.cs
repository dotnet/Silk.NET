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
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_CRYPTO_SESSION_INPUT")]
    public unsafe partial struct AuthenticatedConfigureCryptoSessionInput
    {
        public AuthenticatedConfigureCryptoSessionInput
        (
            AuthenticatedConfigureInput parameters = default,
            void* decoderHandle = default,
            void* cryptoSessionHandle = default,
            void* deviceHandle = default
        )
        {
            Parameters = parameters;
            DecoderHandle = decoderHandle;
            CryptoSessionHandle = cryptoSessionHandle;
            DeviceHandle = deviceHandle;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedConfigureInput Parameters;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DecoderHandle")]
        public void* DecoderHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "CryptoSessionHandle")]
        public void* CryptoSessionHandle;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DeviceHandle")]
        public void* DeviceHandle;
    }
}
