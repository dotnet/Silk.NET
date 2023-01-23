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
    [NativeName("Name", "_DXVAHDETW_VIDEOPROCESSBLTSTATE")]
    public unsafe partial struct HdetwVideoprocessbltstate
    {
        public HdetwVideoprocessbltstate
        (
            ulong? pObject = null,
            HDBltState? state = null,
            uint? dataSize = null,
            Silk.NET.Core.Bool32? setState = null
        ) : this()
        {
            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (state is not null)
            {
                State = state.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (setState is not null)
            {
                SetState = setState.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "DXVAHD_BLT_STATE")]
        [NativeName("Type.Name", "DXVAHD_BLT_STATE")]
        [NativeName("Name", "State")]
        public HDBltState State;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "SetState")]
        public Silk.NET.Core.Bool32 SetState;
    }
}
