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
    [NativeName("Name", "_DXVA2_FilterValues")]
    public unsafe partial struct DXVA2FilterValues
    {
        public DXVA2FilterValues
        (
            DXVA2Fixed32? level = null,
            DXVA2Fixed32? threshold = null,
            DXVA2Fixed32? radius = null
        ) : this()
        {
            if (level is not null)
            {
                Level = level.Value;
            }

            if (threshold is not null)
            {
                Threshold = threshold.Value;
            }

            if (radius is not null)
            {
                Radius = radius.Value;
            }
        }


        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Level")]
        public DXVA2Fixed32 Level;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Threshold")]
        public DXVA2Fixed32 Threshold;

        [NativeName("Type", "DXVA2_Fixed32")]
        [NativeName("Type.Name", "DXVA2_Fixed32")]
        [NativeName("Name", "Radius")]
        public DXVA2Fixed32 Radius;
    }
}
