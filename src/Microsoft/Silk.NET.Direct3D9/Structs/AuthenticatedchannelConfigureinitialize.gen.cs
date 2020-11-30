// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGUREINITIALIZE")]
    public unsafe partial struct AuthenticatedchannelConfigureinitialize
    {
        public AuthenticatedchannelConfigureinitialize
        (
            AuthenticatedchannelConfigureInput? parameters = null,
            uint? startSequenceQuery = null,
            uint? startSequenceConfigure = null
        ) : this()
        {
            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }

            if (startSequenceQuery is not null)
            {
                StartSequenceQuery = startSequenceQuery.Value;
            }

            if (startSequenceConfigure is not null)
            {
                StartSequenceConfigure = startSequenceConfigure.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedchannelConfigureInput Parameters;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartSequenceQuery")]
        public uint StartSequenceQuery;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StartSequenceConfigure")]
        public uint StartSequenceConfigure;
    }
}
