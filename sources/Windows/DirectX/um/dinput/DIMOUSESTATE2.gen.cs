// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIMOUSESTATE2.xml' path='doc/member[@name="DIMOUSESTATE2"]/*'/>
public unsafe partial struct DIMOUSESTATE2
{
    /// <include file='DIMOUSESTATE2.xml' path='doc/member[@name="DIMOUSESTATE2.lX"]/*'/>
    [NativeTypeName("LONG")]
    public int lX;
    /// <include file='DIMOUSESTATE2.xml' path='doc/member[@name="DIMOUSESTATE2.lY"]/*'/>
    [NativeTypeName("LONG")]
    public int lY;
    /// <include file='DIMOUSESTATE2.xml' path='doc/member[@name="DIMOUSESTATE2.lZ"]/*'/>
    [NativeTypeName("LONG")]
    public int lZ;
    /// <include file='DIMOUSESTATE2.xml' path='doc/member[@name="DIMOUSESTATE2.rgbButtons"]/*'/>
    [NativeTypeName("BYTE[8]")]
    public fixed byte rgbButtons[8];
}