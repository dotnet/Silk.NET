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
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
    public unsafe partial struct AuthenticatedConfigureInput
    {
        public AuthenticatedConfigureInput
        (
            OMAC omac = default,
            Guid configureType = default,
            void* hChannel = default,
            uint sequenceNumber = default
        )
        {
            Omac = omac;
            ConfigureType = configureType;
            HChannel = hChannel;
            SequenceNumber = sequenceNumber;
        }


        [NativeName("Type", "D3D11_OMAC")]
        [NativeName("Type.Name", "D3D11_OMAC")]
        [NativeName("Name", "omac")]
        public OMAC Omac;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "ConfigureType")]
        public Guid ConfigureType;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hChannel")]
        public void* HChannel;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SequenceNumber")]
        public uint SequenceNumber;
    }
}
