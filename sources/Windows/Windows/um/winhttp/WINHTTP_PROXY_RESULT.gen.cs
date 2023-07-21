// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_PROXY_RESULT.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT"]/*' />
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WINHTTP_PROXY_RESULT
{
    /// <include file='WINHTTP_PROXY_RESULT.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT.cEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint cEntries;

    /// <include file='WINHTTP_PROXY_RESULT.xml' path='doc/member[@name="WINHTTP_PROXY_RESULT.pEntries"]/*' />
    public WINHTTP_PROXY_RESULT_ENTRY* pEntries;
}
