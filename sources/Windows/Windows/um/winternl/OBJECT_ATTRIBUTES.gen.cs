// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES"]/*' />
public unsafe partial struct OBJECT_ATTRIBUTES
{
    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.Length"]/*' />
    [NativeTypeName("ULONG")]
    public uint Length;

    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.RootDirectory"]/*' />
    public HANDLE RootDirectory;

    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.ObjectName"]/*' />
    [NativeTypeName("PUNICODE_STRING")]
    public UNICODE_STRING* ObjectName;

    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.Attributes"]/*' />
    [NativeTypeName("ULONG")]
    public uint Attributes;

    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.SecurityDescriptor"]/*' />
    [NativeTypeName("PVOID")]
    public void* SecurityDescriptor;

    /// <include file='OBJECT_ATTRIBUTES.xml' path='doc/member[@name="OBJECT_ATTRIBUTES.SecurityQualityOfService"]/*' />
    [NativeTypeName("PVOID")]
    public void* SecurityQualityOfService;
}
