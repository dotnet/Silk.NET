// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE"]/*'/>
public unsafe partial struct CRYPT_TIMESTAMP_RESPONSE
{
    /// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE.dwStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStatus;
    /// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE.cFreeText"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cFreeText;
    /// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE.rgFreeText"]/*'/>
    [NativeTypeName("LPWSTR *")]
    public ushort** rgFreeText;
    /// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE.FailureInfo"]/*'/>
    public CRYPT_BIT_BLOB FailureInfo;
    /// <include file='CRYPT_TIMESTAMP_RESPONSE.xml' path='doc/member[@name="CRYPT_TIMESTAMP_RESPONSE.ContentInfo"]/*'/>
    [NativeTypeName("CRYPT_DER_BLOB")]
    public CRYPT_DATA_BLOB ContentInfo;
}