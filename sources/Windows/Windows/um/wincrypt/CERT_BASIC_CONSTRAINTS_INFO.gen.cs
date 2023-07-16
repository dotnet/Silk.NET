// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO"]/*'/>
public unsafe partial struct CERT_BASIC_CONSTRAINTS_INFO
{
    /// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO.SubjectType"]/*'/>
    public CRYPT_BIT_BLOB SubjectType;
    /// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO.fPathLenConstraint"]/*'/>
    public BOOL fPathLenConstraint;
    /// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO.dwPathLenConstraint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPathLenConstraint;
    /// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO.cSubtreesConstraint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSubtreesConstraint;
    /// <include file='CERT_BASIC_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_BASIC_CONSTRAINTS_INFO.rgSubtreesConstraint"]/*'/>
    [NativeTypeName("CERT_NAME_BLOB *")]
    public CRYPT_DATA_BLOB* rgSubtreesConstraint;
}