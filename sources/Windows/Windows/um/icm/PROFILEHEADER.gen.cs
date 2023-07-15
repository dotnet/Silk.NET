// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER"]/*'/>
public unsafe partial struct PROFILEHEADER
{
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phSize;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phCMMType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phCMMType;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phVersion;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phClass;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phDataColorSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phDataColorSpace;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phConnectionSpace"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phConnectionSpace;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phDateTime"]/*'/>
    [NativeTypeName("DWORD[3]")]
    public fixed uint phDateTime[3];
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phSignature;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phPlatform"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phPlatform;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phProfileFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phProfileFlags;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phManufacturer"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phManufacturer;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phModel"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phModel;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phAttributes"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint phAttributes[2];
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phRenderingIntent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phRenderingIntent;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phIlluminant"]/*'/>
    public CIEXYZ phIlluminant;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phCreator"]/*'/>
    [NativeTypeName("DWORD")]
    public uint phCreator;
    /// <include file='PROFILEHEADER.xml' path='doc/member[@name="PROFILEHEADER.phReserved"]/*'/>
    [NativeTypeName("BYTE[44]")]
    public fixed byte phReserved[44];
}