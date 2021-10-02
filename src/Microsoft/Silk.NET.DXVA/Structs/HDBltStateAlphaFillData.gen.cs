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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHD_BLT_STATE_ALPHA_FILL_DATA")]
    public unsafe partial struct HDBltStateAlphaFillData
    {
        public HDBltStateAlphaFillData
        (
            HDAlphaFillMode? mode = null,
            uint? streamNumber = null
        ) : this()
        {
            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (streamNumber is not null)
            {
                StreamNumber = streamNumber.Value;
            }
        }


        [NativeName("Type", "DXVAHD_ALPHA_FILL_MODE")]
        [NativeName("Type.Name", "DXVAHD_ALPHA_FILL_MODE")]
        [NativeName("Name", "Mode")]
        public HDAlphaFillMode Mode;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StreamNumber")]
        public uint StreamNumber;
    }
}
