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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_PRIVATE_IVTC_DATA")]
    public unsafe partial struct HDStreamStatePrivateIvtcData
    {
        public HDStreamStatePrivateIvtcData
        (
            Silk.NET.Core.Bool32? enable = null,
            uint? iTelecineFlags = null,
            uint? frames = null,
            uint? inputField = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (iTelecineFlags is not null)
            {
                ITelecineFlags = iTelecineFlags.Value;
            }

            if (frames is not null)
            {
                Frames = frames.Value;
            }

            if (inputField is not null)
            {
                InputField = inputField.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public Silk.NET.Core.Bool32 Enable;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ITelecineFlags")]
        public uint ITelecineFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Frames")]
        public uint Frames;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputField")]
        public uint InputField;
    }
}
