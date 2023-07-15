// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CERT_SERVER_OCSP_RESPONSE_CONTEXT.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_CONTEXT"]/*'/>
public unsafe partial struct CERT_SERVER_OCSP_RESPONSE_CONTEXT
{
    /// <include file='CERT_SERVER_OCSP_RESPONSE_CONTEXT.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_CONTEXT.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_CONTEXT.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_CONTEXT.pbEncodedOcspResponse"]/*'/>
    public byte* pbEncodedOcspResponse;
    /// <include file='CERT_SERVER_OCSP_RESPONSE_CONTEXT.xml' path='doc/member[@name="CERT_SERVER_OCSP_RESPONSE_CONTEXT.cbEncodedOcspResponse"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbEncodedOcspResponse;
}