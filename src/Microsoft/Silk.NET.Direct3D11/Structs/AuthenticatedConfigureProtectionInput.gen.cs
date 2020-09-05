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
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_PROTECTION_INPUT")]
    public unsafe partial struct AuthenticatedConfigureProtectionInput
    {
        public AuthenticatedConfigureProtectionInput
        (
            AuthenticatedConfigureInput parameters = default,
            AuthenticatedProtectionFlags protections = default
        )
        {
            Parameters = parameters;
            Protections = protections;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedConfigureInput Parameters;

        [NativeName("Type", "D3D11_AUTHENTICATED_PROTECTION_FLAGS")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_PROTECTION_FLAGS")]
        [NativeName("Name", "Protections")]
        public AuthenticatedProtectionFlags Protections;
    }
}
