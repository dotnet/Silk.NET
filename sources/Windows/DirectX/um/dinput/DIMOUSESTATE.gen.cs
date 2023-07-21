// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='DIMOUSESTATE.xml' path='doc/member[@name="DIMOUSESTATE"]/*' />
public unsafe partial struct DIMOUSESTATE
{
    /// <include file='DIMOUSESTATE.xml' path='doc/member[@name="DIMOUSESTATE.lX"]/*' />
    [NativeTypeName("LONG")]
    public int lX;

    /// <include file='DIMOUSESTATE.xml' path='doc/member[@name="DIMOUSESTATE.lY"]/*' />
    [NativeTypeName("LONG")]
    public int lY;

    /// <include file='DIMOUSESTATE.xml' path='doc/member[@name="DIMOUSESTATE.lZ"]/*' />
    [NativeTypeName("LONG")]
    public int lZ;

    /// <include file='DIMOUSESTATE.xml' path='doc/member[@name="DIMOUSESTATE.rgbButtons"]/*' />
    [NativeTypeName("BYTE[4]")]
    public fixed byte rgbButtons[4];
}
