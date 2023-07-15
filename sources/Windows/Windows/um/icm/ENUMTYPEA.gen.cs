// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA"]/*'/>
public unsafe partial struct ENUMTYPEA
{
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwFields"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFields;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.pDeviceName"]/*'/>
    [NativeTypeName("PCSTR")]
    public sbyte* pDeviceName;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwMediaType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMediaType;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwDitheringMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDitheringMode;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwResolution"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwResolution[2];
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwCMMType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCMMType;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwClass;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwDataColorSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDataColorSpace;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwConnectionSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwConnectionSpace;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwPlatform"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPlatform;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwProfileFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProfileFlags;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwManufacturer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwManufacturer;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwModel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwModel;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwAttributes"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwAttributes[2];
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwRenderingIntent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRenderingIntent;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwCreator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCreator;
    /// <include file='ENUMTYPEA.xml' path='doc/member[@name="ENUMTYPEA.dwDeviceClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceClass;
}