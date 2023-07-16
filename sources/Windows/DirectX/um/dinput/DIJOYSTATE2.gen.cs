// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2"]/*'/>
public unsafe partial struct DIJOYSTATE2
{
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lX"]/*'/>
    [NativeTypeName("LONG")]
    public int lX;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lY"]/*'/>
    [NativeTypeName("LONG")]
    public int lY;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lZ"]/*'/>
    [NativeTypeName("LONG")]
    public int lZ;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRx"]/*'/>
    [NativeTypeName("LONG")]
    public int lRx;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRy"]/*'/>
    [NativeTypeName("LONG")]
    public int lRy;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lRz"]/*'/>
    [NativeTypeName("LONG")]
    public int lRz;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglSlider"]/*'/>
    [NativeTypeName("LONG[2]")]
    public fixed int rglSlider[2];
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rgdwPOV"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint rgdwPOV[4];
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rgbButtons"]/*'/>
    [NativeTypeName("BYTE[128]")]
    public fixed byte rgbButtons[128];
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVX"]/*'/>
    [NativeTypeName("LONG")]
    public int lVX;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVY"]/*'/>
    [NativeTypeName("LONG")]
    public int lVY;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVZ"]/*'/>
    [NativeTypeName("LONG")]
    public int lVZ;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRx"]/*'/>
    [NativeTypeName("LONG")]
    public int lVRx;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRy"]/*'/>
    [NativeTypeName("LONG")]
    public int lVRy;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lVRz"]/*'/>
    [NativeTypeName("LONG")]
    public int lVRz;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglVSlider"]/*'/>
    [NativeTypeName("LONG[2]")]
    public fixed int rglVSlider[2];
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAX"]/*'/>
    [NativeTypeName("LONG")]
    public int lAX;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAY"]/*'/>
    [NativeTypeName("LONG")]
    public int lAY;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lAZ"]/*'/>
    [NativeTypeName("LONG")]
    public int lAZ;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARx"]/*'/>
    [NativeTypeName("LONG")]
    public int lARx;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARy"]/*'/>
    [NativeTypeName("LONG")]
    public int lARy;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lARz"]/*'/>
    [NativeTypeName("LONG")]
    public int lARz;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglASlider"]/*'/>
    [NativeTypeName("LONG[2]")]
    public fixed int rglASlider[2];
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFX"]/*'/>
    [NativeTypeName("LONG")]
    public int lFX;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFY"]/*'/>
    [NativeTypeName("LONG")]
    public int lFY;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFZ"]/*'/>
    [NativeTypeName("LONG")]
    public int lFZ;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRx"]/*'/>
    [NativeTypeName("LONG")]
    public int lFRx;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRy"]/*'/>
    [NativeTypeName("LONG")]
    public int lFRy;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.lFRz"]/*'/>
    [NativeTypeName("LONG")]
    public int lFRz;
    /// <include file='DIJOYSTATE2.xml' path='doc/member[@name="DIJOYSTATE2.rglFSlider"]/*'/>
    [NativeTypeName("LONG[2]")]
    public fixed int rglFSlider[2];
}