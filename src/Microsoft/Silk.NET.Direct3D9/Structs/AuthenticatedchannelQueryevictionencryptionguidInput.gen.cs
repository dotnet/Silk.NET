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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYEVICTIONENCRYPTIONGUID_INPUT")]
    public unsafe partial struct AuthenticatedchannelQueryevictionencryptionguidInput
    {
        public AuthenticatedchannelQueryevictionencryptionguidInput
        (
            AuthenticatedchannelQueryInput? input = null,
            uint? encryptionGuidIndex = null
        ) : this()
        {
            if (input is not null)
            {
                Input = input.Value;
            }

            if (encryptionGuidIndex is not null)
            {
                EncryptionGuidIndex = encryptionGuidIndex.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Name", "Input")]
        public AuthenticatedchannelQueryInput Input;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "EncryptionGuidIndex")]
        public uint EncryptionGuidIndex;
    }
}
