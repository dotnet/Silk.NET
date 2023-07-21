// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_MATCH_CONNECTION_GUID.xml' path='doc/member[@name="WINHTTP_MATCH_CONNECTION_GUID"]/*' />
public partial struct WINHTTP_MATCH_CONNECTION_GUID
{
    /// <include file='WINHTTP_MATCH_CONNECTION_GUID.xml' path='doc/member[@name="WINHTTP_MATCH_CONNECTION_GUID.ConnectionGuid"]/*' />
    public Guid ConnectionGuid;

    /// <include file='WINHTTP_MATCH_CONNECTION_GUID.xml' path='doc/member[@name="WINHTTP_MATCH_CONNECTION_GUID.ullFlags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;
}
