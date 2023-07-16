// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL"]/*'/>
public partial struct DDCOLORCONTROL
{
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lBrightness"]/*'/>
    [NativeTypeName("LONG")]
    public int lBrightness;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lContrast"]/*'/>
    [NativeTypeName("LONG")]
    public int lContrast;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lHue"]/*'/>
    [NativeTypeName("LONG")]
    public int lHue;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lSaturation"]/*'/>
    [NativeTypeName("LONG")]
    public int lSaturation;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lSharpness"]/*'/>
    [NativeTypeName("LONG")]
    public int lSharpness;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lGamma"]/*'/>
    [NativeTypeName("LONG")]
    public int lGamma;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.lColorEnable"]/*'/>
    [NativeTypeName("LONG")]
    public int lColorEnable;
    /// <include file='DDCOLORCONTROL.xml' path='doc/member[@name="DDCOLORCONTROL.dwReserved1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved1;
}