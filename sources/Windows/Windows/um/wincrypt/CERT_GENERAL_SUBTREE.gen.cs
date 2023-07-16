// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_GENERAL_SUBTREE.xml' path='doc/member[@name="CERT_GENERAL_SUBTREE"]/*'/>
public partial struct CERT_GENERAL_SUBTREE
{
    /// <include file='CERT_GENERAL_SUBTREE.xml' path='doc/member[@name="CERT_GENERAL_SUBTREE.Base"]/*'/>
    public CERT_ALT_NAME_ENTRY Base;
    /// <include file='CERT_GENERAL_SUBTREE.xml' path='doc/member[@name="CERT_GENERAL_SUBTREE.dwMinimum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinimum;
    /// <include file='CERT_GENERAL_SUBTREE.xml' path='doc/member[@name="CERT_GENERAL_SUBTREE.fMaximum"]/*'/>
    public BOOL fMaximum;
    /// <include file='CERT_GENERAL_SUBTREE.xml' path='doc/member[@name="CERT_GENERAL_SUBTREE.dwMaximum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaximum;
}