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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT")]
    public unsafe partial struct AuthenticatedchannelQueryinfobustypeOutput
    {
        public AuthenticatedchannelQueryinfobustypeOutput
        (
            AuthenticatedchannelQueryOutput? output = null,
            Bustype? busType = null,
            Silk.NET.Core.Bool32? bAccessibleInContiguousBlocks = null,
            Silk.NET.Core.Bool32? bAccessibleInNonContiguousBlocks = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (busType is not null)
            {
                BusType = busType.Value;
            }

            if (bAccessibleInContiguousBlocks is not null)
            {
                BAccessibleInContiguousBlocks = bAccessibleInContiguousBlocks.Value;
            }

            if (bAccessibleInNonContiguousBlocks is not null)
            {
                BAccessibleInNonContiguousBlocks = bAccessibleInNonContiguousBlocks.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedchannelQueryOutput Output;

        [NativeName("Type", "D3DBUSTYPE")]
        [NativeName("Type.Name", "D3DBUSTYPE")]
        [NativeName("Name", "BusType")]
        public Bustype BusType;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bAccessibleInContiguousBlocks")]
        public Silk.NET.Core.Bool32 BAccessibleInContiguousBlocks;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bAccessibleInNonContiguousBlocks")]
        public Silk.NET.Core.Bool32 BAccessibleInNonContiguousBlocks;
    }
}
