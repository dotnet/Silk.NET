// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_EFFECT_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION"]/*' />
public unsafe partial struct D2D1_EFFECT_INPUT_DESCRIPTION
{
    /// <include file='D2D1_EFFECT_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION.effect"]/*' />
    public ID2D1Effect* effect;

    /// <include file='D2D1_EFFECT_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION.inputIndex"]/*' />
    [NativeTypeName("UINT32")]
    public uint inputIndex;

    /// <include file='D2D1_EFFECT_INPUT_DESCRIPTION.xml' path='doc/member[@name="D2D1_EFFECT_INPUT_DESCRIPTION.inputRectangle"]/*' />
    [NativeTypeName("D2D1_RECT_F")]
    public D2D_RECT_F inputRectangle;
}
