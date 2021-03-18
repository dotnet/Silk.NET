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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
    public unsafe partial struct AuthenticatedchannelConfigureInput
    {
        public AuthenticatedchannelConfigureInput
        (
            D3DOMac? omac = null,
            Guid? configureType = null,
            void* hChannel = null,
            uint? sequenceNumber = null
        ) : this()
        {
            if (omac is not null)
            {
                Omac = omac.Value;
            }

            if (configureType is not null)
            {
                ConfigureType = configureType.Value;
            }

            if (hChannel is not null)
            {
                HChannel = hChannel;
            }

            if (sequenceNumber is not null)
            {
                SequenceNumber = sequenceNumber.Value;
            }
        }


        [NativeName("Type", "D3D_OMAC")]
        [NativeName("Type.Name", "D3D_OMAC")]
        [NativeName("Name", "omac")]
        public D3DOMac Omac;

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
