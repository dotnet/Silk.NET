// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_TEMPLATE_EXT.xml' path='doc/member[@name="CERT_TEMPLATE_EXT"]/*'/>
public unsafe partial struct CERT_TEMPLATE_EXT
{
    /// <include file='CERT_TEMPLATE_EXT.xml' path='doc/member[@name="CERT_TEMPLATE_EXT.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CERT_TEMPLATE_EXT.xml' path='doc/member[@name="CERT_TEMPLATE_EXT.dwMajorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;
    /// <include file='CERT_TEMPLATE_EXT.xml' path='doc/member[@name="CERT_TEMPLATE_EXT.fMinorVersion"]/*'/>
    public BOOL fMinorVersion;
    /// <include file='CERT_TEMPLATE_EXT.xml' path='doc/member[@name="CERT_TEMPLATE_EXT.dwMinorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;
}