// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_OR_CRL_BLOB.xml' path='doc/member[@name="CERT_OR_CRL_BLOB"]/*'/>
public unsafe partial struct CERT_OR_CRL_BLOB
{
    /// <include file='CERT_OR_CRL_BLOB.xml' path='doc/member[@name="CERT_OR_CRL_BLOB.dwChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwChoice;
    /// <include file='CERT_OR_CRL_BLOB.xml' path='doc/member[@name="CERT_OR_CRL_BLOB.cbEncoded"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbEncoded;
    /// <include file='CERT_OR_CRL_BLOB.xml' path='doc/member[@name="CERT_OR_CRL_BLOB.pbEncoded"]/*'/>
    public byte* pbEncoded;
}