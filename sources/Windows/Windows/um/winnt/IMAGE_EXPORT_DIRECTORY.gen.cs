// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY"]/*'/>
public partial struct IMAGE_EXPORT_DIRECTORY
{
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Characteristics"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Characteristics;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.MajorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorVersion;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.MinorVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorVersion;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Name"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Name;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.Base"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Base;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.NumberOfFunctions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfFunctions;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.NumberOfNames"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfNames;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfFunctions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfFunctions;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfNames"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfNames;
    /// <include file='IMAGE_EXPORT_DIRECTORY.xml' path='doc/member[@name="IMAGE_EXPORT_DIRECTORY.AddressOfNameOrdinals"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfNameOrdinals;
}