// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_RESOURCE_DATA_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DATA_ENTRY"]/*' />
public partial struct IMAGE_RESOURCE_DATA_ENTRY
{
    /// <include file='IMAGE_RESOURCE_DATA_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DATA_ENTRY.OffsetToData"]/*' />
    [NativeTypeName("DWORD")]
    public uint OffsetToData;

    /// <include file='IMAGE_RESOURCE_DATA_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DATA_ENTRY.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGE_RESOURCE_DATA_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DATA_ENTRY.CodePage"]/*' />
    [NativeTypeName("DWORD")]
    public uint CodePage;

    /// <include file='IMAGE_RESOURCE_DATA_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DATA_ENTRY.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;
}
