// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_PRESENT_PARAMETERS")]
    public unsafe partial struct PresentParameters
    {
        public PresentParameters
        (
            uint dirtyRectsCount = default,
            Silk.NET.Core.Runtime.Windows.TagRect* pDirtyRects = default,
            Silk.NET.Core.Runtime.Windows.TagRect* pScrollRect = default,
            Silk.NET.Core.Runtime.Windows.TagPoint* pScrollOffset = default
        )
        {
            DirtyRectsCount = dirtyRectsCount;
            PDirtyRects = pDirtyRects;
            PScrollRect = pScrollRect;
            PScrollOffset = pScrollOffset;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DirtyRectsCount")]
        public uint DirtyRectsCount;

        [NativeName("Type", "RECT *")]
        [NativeName("Type.Name", "RECT *")]
        [NativeName("Name", "pDirtyRects")]
        public Silk.NET.Core.Runtime.Windows.TagRect* PDirtyRects;

        [NativeName("Type", "RECT *")]
        [NativeName("Type.Name", "RECT *")]
        [NativeName("Name", "pScrollRect")]
        public Silk.NET.Core.Runtime.Windows.TagRect* PScrollRect;

        [NativeName("Type", "POINT *")]
        [NativeName("Type.Name", "POINT *")]
        [NativeName("Name", "pScrollOffset")]
        public Silk.NET.Core.Runtime.Windows.TagPoint* PScrollOffset;
    }
}
