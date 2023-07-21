// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SCHANNEL_ALERT_TOKEN.xml' path='doc/member[@name="SCHANNEL_ALERT_TOKEN"]/*' />
public partial struct SCHANNEL_ALERT_TOKEN
{
    /// <include file='SCHANNEL_ALERT_TOKEN.xml' path='doc/member[@name="SCHANNEL_ALERT_TOKEN.dwTokenType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTokenType;

    /// <include file='SCHANNEL_ALERT_TOKEN.xml' path='doc/member[@name="SCHANNEL_ALERT_TOKEN.dwAlertType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlertType;

    /// <include file='SCHANNEL_ALERT_TOKEN.xml' path='doc/member[@name="SCHANNEL_ALERT_TOKEN.dwAlertNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAlertNumber;
}
