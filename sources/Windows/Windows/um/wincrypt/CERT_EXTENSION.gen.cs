// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_EXTENSION.xml' path='doc/member[@name="CERT_EXTENSION"]/*'/>
public unsafe partial struct CERT_EXTENSION
{
    /// <include file='CERT_EXTENSION.xml' path='doc/member[@name="CERT_EXTENSION.pszObjId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszObjId;
    /// <include file='CERT_EXTENSION.xml' path='doc/member[@name="CERT_EXTENSION.fCritical"]/*'/>
    public BOOL fCritical;
    /// <include file='CERT_EXTENSION.xml' path='doc/member[@name="CERT_EXTENSION.Value"]/*'/>
    [NativeTypeName("CRYPT_OBJID_BLOB")]
    public CRYPT_DATA_BLOB Value;
}