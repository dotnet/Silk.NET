// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE"]/*' />
public unsafe partial struct DXGI_DISPLAY_COLOR_SPACE
{
    /// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE.PrimaryCoordinates"]/*' />
    [NativeTypeName("FLOAT[8][2]")]
    public fixed float PrimaryCoordinates[8 * 2];

    /// <include file='DXGI_DISPLAY_COLOR_SPACE.xml' path='doc/member[@name="DXGI_DISPLAY_COLOR_SPACE.WhitePoints"]/*' />
    [NativeTypeName("FLOAT[16][2]")]
    public fixed float WhitePoints[16 * 2];
}
