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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_GLYPH_METRICS")]
    public unsafe partial struct GlyphMetrics
    {
        public GlyphMetrics
        (
            int? leftSideBearing = null,
            uint? advanceWidth = null,
            int? rightSideBearing = null,
            int? topSideBearing = null,
            uint? advanceHeight = null,
            int? bottomSideBearing = null,
            int? verticalOriginY = null
        ) : this()
        {
            if (leftSideBearing is not null)
            {
                LeftSideBearing = leftSideBearing.Value;
            }

            if (advanceWidth is not null)
            {
                AdvanceWidth = advanceWidth.Value;
            }

            if (rightSideBearing is not null)
            {
                RightSideBearing = rightSideBearing.Value;
            }

            if (topSideBearing is not null)
            {
                TopSideBearing = topSideBearing.Value;
            }

            if (advanceHeight is not null)
            {
                AdvanceHeight = advanceHeight.Value;
            }

            if (bottomSideBearing is not null)
            {
                BottomSideBearing = bottomSideBearing.Value;
            }

            if (verticalOriginY is not null)
            {
                VerticalOriginY = verticalOriginY.Value;
            }
        }


        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "leftSideBearing")]
        public int LeftSideBearing;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "advanceWidth")]
        public uint AdvanceWidth;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "rightSideBearing")]
        public int RightSideBearing;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "topSideBearing")]
        public int TopSideBearing;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "advanceHeight")]
        public uint AdvanceHeight;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "bottomSideBearing")]
        public int BottomSideBearing;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "verticalOriginY")]
        public int VerticalOriginY;
    }
}
