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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYPROTECTION_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryprotectionOutput
    {
        public AuthenticatedchannelQueryprotectionOutput
        (
            AuthenticatedchannelQueryOutput? output = null,
            AuthenticatedchannelProtectionFlags? protectionFlags = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (protectionFlags is not null)
            {
                ProtectionFlags = protectionFlags.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_PROTECTION_FLAGS")]
        [NativeName("Name", "ProtectionFlags")]
        public AuthenticatedchannelProtectionFlags ProtectionFlags;
    }
}
