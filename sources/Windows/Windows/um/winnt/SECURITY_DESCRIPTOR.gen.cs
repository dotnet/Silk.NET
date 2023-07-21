// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR"]/*' />
public unsafe partial struct SECURITY_DESCRIPTOR
{
    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Revision"]/*' />
    public byte Revision;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Sbz1"]/*' />
    public byte Sbz1;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Control"]/*' />
    [NativeTypeName("SECURITY_DESCRIPTOR_CONTROL")]
    public ushort Control;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Owner"]/*' />
    [NativeTypeName("PSID")]
    public void* Owner;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Group"]/*' />
    [NativeTypeName("PSID")]
    public void* Group;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Sacl"]/*' />
    [NativeTypeName("PACL")]
    public ACL* Sacl;

    /// <include file='SECURITY_DESCRIPTOR.xml' path='doc/member[@name="SECURITY_DESCRIPTOR.Dacl"]/*' />
    [NativeTypeName("PACL")]
    public ACL* Dacl;
}
