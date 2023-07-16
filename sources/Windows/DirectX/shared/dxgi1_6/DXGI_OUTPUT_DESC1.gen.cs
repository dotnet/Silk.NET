// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;

namespace Silk.NET.DirectX;
/// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1"]/*'/>
public unsafe partial struct DXGI_OUTPUT_DESC1
{
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.DeviceName"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort DeviceName[32];
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.DesktopCoordinates"]/*'/>
    public RECT DesktopCoordinates;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.AttachedToDesktop"]/*'/>
    public BOOL AttachedToDesktop;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.Rotation"]/*'/>
    public DXGI_MODE_ROTATION Rotation;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.Monitor"]/*'/>
    public HMONITOR Monitor;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.BitsPerColor"]/*'/>
    public uint BitsPerColor;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.ColorSpace"]/*'/>
    public DXGI_COLOR_SPACE_TYPE ColorSpace;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.RedPrimary"]/*'/>
    [NativeTypeName("FLOAT[2]")]
    public fixed float RedPrimary[2];
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.GreenPrimary"]/*'/>
    [NativeTypeName("FLOAT[2]")]
    public fixed float GreenPrimary[2];
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.BluePrimary"]/*'/>
    [NativeTypeName("FLOAT[2]")]
    public fixed float BluePrimary[2];
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.WhitePoint"]/*'/>
    [NativeTypeName("FLOAT[2]")]
    public fixed float WhitePoint[2];
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MinLuminance"]/*'/>
    public float MinLuminance;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MaxLuminance"]/*'/>
    public float MaxLuminance;
    /// <include file='DXGI_OUTPUT_DESC1.xml' path='doc/member[@name="DXGI_OUTPUT_DESC1.MaxFullFrameLuminance"]/*'/>
    public float MaxFullFrameLuminance;
}