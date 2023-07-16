// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WINHTTP_FAILED_CONNECTION_RETRIES.xml' path='doc/member[@name="WINHTTP_FAILED_CONNECTION_RETRIES"]/*'/>
public partial struct WINHTTP_FAILED_CONNECTION_RETRIES
{
    /// <include file='WINHTTP_FAILED_CONNECTION_RETRIES.xml' path='doc/member[@name="WINHTTP_FAILED_CONNECTION_RETRIES.dwMaxRetries"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaxRetries;
    /// <include file='WINHTTP_FAILED_CONNECTION_RETRIES.xml' path='doc/member[@name="WINHTTP_FAILED_CONNECTION_RETRIES.dwAllowedRetryConditions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAllowedRetryConditions;
}