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
    [NativeName("Name", "_DXVAHD_STREAM_STATE_ALPHA_DATA")]
    public unsafe partial struct HDStreamStateAlphaData
    {
        public HDStreamStateAlphaData
        (
            Silk.NET.Core.Bool32? enable = null,
            float? alpha = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (alpha is not null)
            {
                Alpha = alpha.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public Silk.NET.Core.Bool32 Enable;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Alpha")]
        public float Alpha;
    }
}
