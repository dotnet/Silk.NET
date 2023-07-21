// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST"]/*' />
public unsafe partial struct SE_ACCESS_REQUEST
{
    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.SeSecurityDescriptor"]/*' />
    [NativeTypeName("PSE_SECURITY_DESCRIPTOR")]
    public SE_SECURITY_DESCRIPTOR* SeSecurityDescriptor;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.DesiredAccess"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint DesiredAccess;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.PreviouslyGrantedAccess"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint PreviouslyGrantedAccess;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.PrincipalSelfSid"]/*' />
    [NativeTypeName("PSID")]
    public void* PrincipalSelfSid;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.GenericMapping"]/*' />
    [NativeTypeName("PGENERIC_MAPPING")]
    public GENERIC_MAPPING* GenericMapping;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.ObjectTypeListCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ObjectTypeListCount;

    /// <include file='SE_ACCESS_REQUEST.xml' path='doc/member[@name="SE_ACCESS_REQUEST.ObjectTypeList"]/*' />
    [NativeTypeName("POBJECT_TYPE_LIST")]
    public OBJECT_TYPE_LIST* ObjectTypeList;
}
