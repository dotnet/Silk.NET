// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STORAGE_ATTRIBUTE_MGMT.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT"]/*' />
public partial struct STORAGE_ATTRIBUTE_MGMT
{
    /// <include file='STORAGE_ATTRIBUTE_MGMT.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_ATTRIBUTE_MGMT.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_ATTRIBUTE_MGMT.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT.Action"]/*' />
    public STORAGE_ATTRIBUTE_MGMT_ACTION Action;

    /// <include file='STORAGE_ATTRIBUTE_MGMT.xml' path='doc/member[@name="STORAGE_ATTRIBUTE_MGMT.Attribute"]/*' />
    [NativeTypeName("DWORD")]
    public uint Attribute;
}
