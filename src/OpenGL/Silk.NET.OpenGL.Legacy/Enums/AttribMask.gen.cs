// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [Flags]
    [NativeName("Name", "AttribMask")]
    public enum AttribMask : int
    {
        [NativeName("Name", "")]
        None = 0,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_CURRENT_BIT")]
        CurrentBit = 0x1,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POINT_BIT")]
        PointBit = 0x2,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LINE_BIT")]
        LineBit = 0x4,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POLYGON_BIT")]
        PolygonBit = 0x8,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_POLYGON_STIPPLE_BIT")]
        PolygonStippleBit = 0x10,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_PIXEL_MODE_BIT")]
        PixelModeBit = 0x20,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIGHTING_BIT")]
        LightingBit = 0x40,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_FOG_BIT")]
        FogBit = 0x80,
        [NativeName("Name", "GL_DEPTH_BUFFER_BIT")]
        DepthBufferBit = 0x100,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ACCUM_BUFFER_BIT")]
        AccumBufferBit = 0x200,
        [NativeName("Name", "GL_STENCIL_BUFFER_BIT")]
        StencilBufferBit = 0x400,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_VIEWPORT_BIT")]
        ViewportBit = 0x800,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TRANSFORM_BIT")]
        TransformBit = 0x1000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ENABLE_BIT")]
        EnableBit = 0x2000,
        [NativeName("Name", "GL_COLOR_BUFFER_BIT")]
        ColorBufferBit = 0x4000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_HINT_BIT")]
        HintBit = 0x8000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_EVAL_BIT")]
        EvalBit = 0x10000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_LIST_BIT")]
        ListBit = 0x20000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_TEXTURE_BIT")]
        TextureBit = 0x40000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_SCISSOR_BIT")]
        ScissorBit = 0x80000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_MULTISAMPLE_BIT")]
        MultisampleBit = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_ARB")]
        MultisampleBitArb = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_EXT")]
        MultisampleBitExt = 0x20000000,
        [NativeName("Name", "GL_MULTISAMPLE_BIT_3DFX")]
        MultisampleBit3Dfx = 0x20000000,
        [System.Obsolete("Deprecated in version 3.2")]
        [NativeName("Name", "GL_ALL_ATTRIB_BITS")]
        AllAttribBits = unchecked((int)0xFFFFFFFF),
    }
}
