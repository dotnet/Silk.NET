// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE"]/*'/>
public partial struct SECURITY_DESCRIPTOR_RELATIVE
{
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Revision"]/*'/>
    public byte Revision;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Sbz1"]/*'/>
    public byte Sbz1;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Control"]/*'/>
    [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")]
    public ushort Control;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Owner"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Owner;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Group"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Group;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Sacl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Sacl;
    /// <include file='SECURITY_DESCRIPTOR_RELATIVE.xml' path='doc/member[@name="SECURITY_DESCRIPTOR_RELATIVE.Dacl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Dacl;
}