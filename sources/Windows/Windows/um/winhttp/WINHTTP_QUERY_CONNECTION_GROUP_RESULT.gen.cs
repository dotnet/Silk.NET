// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WINHTTP_QUERY_CONNECTION_GROUP_RESULT.xml' path='doc/member[@name="WINHTTP_QUERY_CONNECTION_GROUP_RESULT"]/*' />
public unsafe partial struct WINHTTP_QUERY_CONNECTION_GROUP_RESULT
{
    /// <include file='WINHTTP_QUERY_CONNECTION_GROUP_RESULT.xml' path='doc/member[@name="WINHTTP_QUERY_CONNECTION_GROUP_RESULT.cHosts"]/*' />
    [NativeTypeName("ULONG")]
    public uint cHosts;

    /// <include file='WINHTTP_QUERY_CONNECTION_GROUP_RESULT.xml' path='doc/member[@name="WINHTTP_QUERY_CONNECTION_GROUP_RESULT.pHostConnectionGroups"]/*' />
    [NativeTypeName("PWINHTTP_HOST_CONNECTION_GROUP")]
    public WINHTTP_HOST_CONNECTION_GROUP* pHostConnectionGroups;
}
