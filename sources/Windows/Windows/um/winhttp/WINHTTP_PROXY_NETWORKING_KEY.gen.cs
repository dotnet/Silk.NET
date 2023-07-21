// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WINHTTP_PROXY_NETWORKING_KEY.xml' path='doc/member[@name="WINHTTP_PROXY_NETWORKING_KEY"]/*' />
public unsafe partial struct WINHTTP_PROXY_NETWORKING_KEY
{
    /// <include file='WINHTTP_PROXY_NETWORKING_KEY.xml' path='doc/member[@name="WINHTTP_PROXY_NETWORKING_KEY.pbBuffer"]/*' />
    [NativeTypeName("unsigned char[128]")]
    public fixed byte pbBuffer[128];
}
