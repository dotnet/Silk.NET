// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='CERT_STRONG_SIGN_SERIALIZED_INFO.xml' path='doc/member[@name="CERT_STRONG_SIGN_SERIALIZED_INFO"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CERT_STRONG_SIGN_SERIALIZED_INFO
{
    /// <include file='CERT_STRONG_SIGN_SERIALIZED_INFO.xml' path='doc/member[@name="CERT_STRONG_SIGN_SERIALIZED_INFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='CERT_STRONG_SIGN_SERIALIZED_INFO.xml' path='doc/member[@name="CERT_STRONG_SIGN_SERIALIZED_INFO.pwszCNGSignHashAlgids"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszCNGSignHashAlgids;
    /// <include file='CERT_STRONG_SIGN_SERIALIZED_INFO.xml' path='doc/member[@name="CERT_STRONG_SIGN_SERIALIZED_INFO.pwszCNGPubKeyMinBitLengths"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pwszCNGPubKeyMinBitLengths;
}