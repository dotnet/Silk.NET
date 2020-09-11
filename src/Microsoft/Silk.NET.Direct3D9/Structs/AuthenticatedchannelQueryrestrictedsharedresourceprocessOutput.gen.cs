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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESS_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryrestrictedsharedresourceprocessOutput
    {
        public AuthenticatedchannelQueryrestrictedsharedresourceprocessOutput
        (
            AuthenticatedchannelQueryOutput output = default,
            uint processIndex = default,
            AuthenticatedchannelProcessidentifiertype processIdentifer = default,
            void* processHandle = default
        )
        {
            Output = output;
            ProcessIndex = processIndex;
            ProcessIdentifer = processIdentifer;
            ProcessHandle = processHandle;
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProcessIndex")]
        public uint ProcessIndex;

        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Name", "ProcessIdentifer")]
        public AuthenticatedchannelProcessidentifiertype ProcessIdentifer;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "ProcessHandle")]
        public void* ProcessHandle;
    }
}
