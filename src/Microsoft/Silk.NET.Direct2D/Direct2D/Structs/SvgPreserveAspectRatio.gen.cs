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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_SVG_PRESERVE_ASPECT_RATIO")]
    public unsafe partial struct SvgPreserveAspectRatio
    {
        public SvgPreserveAspectRatio
        (
            Silk.NET.Core.Bool32? defer = null,
            SvgAspectAlign? align = null,
            SvgAspectScaling? meetOrSlice = null
        ) : this()
        {
            if (defer is not null)
            {
                Defer = defer.Value;
            }

            if (align is not null)
            {
                Align = align.Value;
            }

            if (meetOrSlice is not null)
            {
                MeetOrSlice = meetOrSlice.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "defer")]
        public Silk.NET.Core.Bool32 Defer;

        [NativeName("Type", "D2D1_SVG_ASPECT_ALIGN")]
        [NativeName("Type.Name", "D2D1_SVG_ASPECT_ALIGN")]
        [NativeName("Name", "align")]
        public SvgAspectAlign Align;

        [NativeName("Type", "D2D1_SVG_ASPECT_SCALING")]
        [NativeName("Type.Name", "D2D1_SVG_ASPECT_SCALING")]
        [NativeName("Name", "meetOrSlice")]
        public SvgAspectScaling MeetOrSlice;
    }
}
