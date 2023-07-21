// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE"]/*' />
public partial struct D2D1_SIMPLE_COLOR_PROFILE
{
    /// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE.redPrimary"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F redPrimary;

    /// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE.greenPrimary"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F greenPrimary;

    /// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE.bluePrimary"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F bluePrimary;

    /// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE.whitePointXZ"]/*' />
    [NativeTypeName("D2D1_POINT_2F")]
    public D2D_POINT_2F whitePointXZ;

    /// <include file='D2D1_SIMPLE_COLOR_PROFILE.xml' path='doc/member[@name="D2D1_SIMPLE_COLOR_PROFILE.gamma"]/*' />
    public D2D1_GAMMA1 gamma;
}
