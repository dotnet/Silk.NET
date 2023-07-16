// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PKU2U_CERT_BLOB.xml' path='doc/member[@name="PKU2U_CERT_BLOB"]/*'/>
public partial struct PKU2U_CERT_BLOB
{
    /// <include file='PKU2U_CERT_BLOB.xml' path='doc/member[@name="PKU2U_CERT_BLOB.CertOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CertOffset;
    /// <include file='PKU2U_CERT_BLOB.xml' path='doc/member[@name="PKU2U_CERT_BLOB.CertLength"]/*'/>
    public ushort CertLength;
}