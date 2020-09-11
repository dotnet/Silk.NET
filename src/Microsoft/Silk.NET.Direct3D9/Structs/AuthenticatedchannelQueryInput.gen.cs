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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERY_INPUT")]
    public unsafe partial struct AuthenticatedchannelQueryInput
    {
        public AuthenticatedchannelQueryInput
        (
            Guid queryType = default,
            void* hChannel = default,
            uint sequenceNumber = default
        )
        {
            QueryType = queryType;
            HChannel = hChannel;
            SequenceNumber = sequenceNumber;
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
