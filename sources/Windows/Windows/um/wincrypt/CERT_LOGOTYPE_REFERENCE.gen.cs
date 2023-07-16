// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CERT_LOGOTYPE_REFERENCE.xml' path='doc/member[@name="CERT_LOGOTYPE_REFERENCE"]/*'/>
public unsafe partial struct CERT_LOGOTYPE_REFERENCE
{
    /// <include file='CERT_LOGOTYPE_REFERENCE.xml' path='doc/member[@name="CERT_LOGOTYPE_REFERENCE.cHashedUrl"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cHashedUrl;
    /// <include file='CERT_LOGOTYPE_REFERENCE.xml' path='doc/member[@name="CERT_LOGOTYPE_REFERENCE.rgHashedUrl"]/*'/>
    [NativeTypeName("PCERT_HASHED_URL")]
    public CERT_HASHED_URL* rgHashedUrl;
}