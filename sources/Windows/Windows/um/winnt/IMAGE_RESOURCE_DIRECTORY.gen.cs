// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY"]/*' />
public partial struct IMAGE_RESOURCE_DIRECTORY
{
    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.Characteristics"]/*' />
    [NativeTypeName("DWORD")]
    public uint Characteristics;

    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.MajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.MinorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.NumberOfNamedEntries"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfNamedEntries;

    /// <include file='IMAGE_RESOURCE_DIRECTORY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY.NumberOfIdEntries"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfIdEntries;
}
