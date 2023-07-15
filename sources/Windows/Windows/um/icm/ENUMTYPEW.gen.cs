// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW"]/*'/>
public unsafe partial struct ENUMTYPEW
{
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwFields"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFields;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.pDeviceName"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pDeviceName;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwMediaType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMediaType;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwDitheringMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDitheringMode;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwResolution"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwResolution[2];
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwCMMType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCMMType;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwClass;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwDataColorSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDataColorSpace;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwConnectionSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwConnectionSpace;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwPlatform"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPlatform;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwProfileFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProfileFlags;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwManufacturer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwManufacturer;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwModel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwModel;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwAttributes"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint dwAttributes[2];
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwRenderingIntent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRenderingIntent;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwCreator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCreator;
    /// <include file='ENUMTYPEW.xml' path='doc/member[@name="ENUMTYPEW.dwDeviceClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDeviceClass;
}