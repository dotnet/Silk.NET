// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYRESTRICTEDSHAREDRESOURCEPROCESSCOUNT_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryrestrictedsharedresourceprocesscountOutput
    {
        public AuthenticatedchannelQueryrestrictedsharedresourceprocesscountOutput
        (
            AuthenticatedchannelQueryOutput? output = null,
            uint? numRestrictedSharedResourceProcesses = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (numRestrictedSharedResourceProcesses is not null)
            {
                NumRestrictedSharedResourceProcesses = numRestrictedSharedResourceProcesses.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRestrictedSharedResourceProcesses")]
        public uint NumRestrictedSharedResourceProcesses;
    }
}
