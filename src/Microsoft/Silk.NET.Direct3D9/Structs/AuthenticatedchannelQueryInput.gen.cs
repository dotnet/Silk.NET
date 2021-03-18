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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
    public unsafe partial struct AuthenticatedchannelQueryInput
    {
        public AuthenticatedchannelQueryInput
        (
            Guid? queryType = null,
            void* hChannel = null,
            uint? sequenceNumber = null
        ) : this()
        {
            if (queryType is not null)
            {
                QueryType = queryType.Value;
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


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "QueryType")]
        public Guid QueryType;

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
