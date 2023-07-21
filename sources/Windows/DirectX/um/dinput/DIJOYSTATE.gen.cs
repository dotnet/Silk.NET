// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE"]/*' />
public unsafe partial struct DIJOYSTATE
{
    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lX"]/*' />
    [NativeTypeName("LONG")]
    public int lX;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lY"]/*' />
    [NativeTypeName("LONG")]
    public int lY;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lZ"]/*' />
    [NativeTypeName("LONG")]
    public int lZ;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRx"]/*' />
    [NativeTypeName("LONG")]
    public int lRx;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRy"]/*' />
    [NativeTypeName("LONG")]
    public int lRy;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.lRz"]/*' />
    [NativeTypeName("LONG")]
    public int lRz;

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rglSlider"]/*' />
    [NativeTypeName("LONG[2]")]
    public fixed int rglSlider[2];

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rgdwPOV"]/*' />
    [NativeTypeName("DWORD[4]")]
    public fixed uint rgdwPOV[4];

    /// <include file='DIJOYSTATE.xml' path='doc/member[@name="DIJOYSTATE.rgbButtons"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte rgbButtons[32];
}
