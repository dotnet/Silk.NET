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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT")]
    public unsafe partial struct AuthenticatedchannelQuerycryptosessionInput
    {
        public AuthenticatedchannelQuerycryptosessionInput
        (
            AuthenticatedchannelQueryInput? input = null,
            void* dXVA2DecodeHandle = null
        ) : this()
        {
            if (input is not null)
            {
                Input = input.Value;
            }

            if (dXVA2DecodeHandle is not null)
            {
                DXVA2DecodeHandle = dXVA2DecodeHandle;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
        [NativeName("Name", "Input")]
        public AuthenticatedchannelQueryInput Input;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "DXVA2DecodeHandle")]
        public void* DXVA2DecodeHandle;
    }
}
