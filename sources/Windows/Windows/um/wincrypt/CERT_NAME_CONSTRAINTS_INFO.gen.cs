// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_NAME_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_NAME_CONSTRAINTS_INFO"]/*'/>
public unsafe partial struct CERT_NAME_CONSTRAINTS_INFO
{
    /// <include file='CERT_NAME_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_NAME_CONSTRAINTS_INFO.cPermittedSubtree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cPermittedSubtree;
    /// <include file='CERT_NAME_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_NAME_CONSTRAINTS_INFO.rgPermittedSubtree"]/*'/>
    [NativeTypeName("PCERT_GENERAL_SUBTREE")]
    public CERT_GENERAL_SUBTREE* rgPermittedSubtree;
    /// <include file='CERT_NAME_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_NAME_CONSTRAINTS_INFO.cExcludedSubtree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExcludedSubtree;
    /// <include file='CERT_NAME_CONSTRAINTS_INFO.xml' path='doc/member[@name="CERT_NAME_CONSTRAINTS_INFO.rgExcludedSubtree"]/*'/>
    [NativeTypeName("PCERT_GENERAL_SUBTREE")]
    public CERT_GENERAL_SUBTREE* rgExcludedSubtree;
}