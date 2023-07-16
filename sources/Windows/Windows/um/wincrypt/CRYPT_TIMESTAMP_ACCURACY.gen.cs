// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CRYPT_TIMESTAMP_ACCURACY.xml' path='doc/member[@name="CRYPT_TIMESTAMP_ACCURACY"]/*'/>
public partial struct CRYPT_TIMESTAMP_ACCURACY
{
    /// <include file='CRYPT_TIMESTAMP_ACCURACY.xml' path='doc/member[@name="CRYPT_TIMESTAMP_ACCURACY.dwSeconds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSeconds;
    /// <include file='CRYPT_TIMESTAMP_ACCURACY.xml' path='doc/member[@name="CRYPT_TIMESTAMP_ACCURACY.dwMillis"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMillis;
    /// <include file='CRYPT_TIMESTAMP_ACCURACY.xml' path='doc/member[@name="CRYPT_TIMESTAMP_ACCURACY.dwMicros"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMicros;
}