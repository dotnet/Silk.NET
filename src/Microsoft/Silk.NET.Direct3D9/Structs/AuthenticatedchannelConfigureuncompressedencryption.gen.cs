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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGUREUNCOMPRESSEDENCRYPTION")]
    public unsafe partial struct AuthenticatedchannelConfigureuncompressedencryption
    {
        public AuthenticatedchannelConfigureuncompressedencryption
        (
            AuthenticatedchannelConfigureInput? parameters = null,
            Guid? encryptionGuid = null
        ) : this()
        {
            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }

            if (encryptionGuid is not null)
            {
                EncryptionGuid = encryptionGuid.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedchannelConfigureInput Parameters;

        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "EncryptionGuid")]
        public Guid EncryptionGuid;
    }
}
