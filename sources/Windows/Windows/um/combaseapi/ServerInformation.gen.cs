// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ServerInformation.xml' path='doc/member[@name="ServerInformation"]/*' />
public partial struct ServerInformation
{
    /// <include file='ServerInformation.xml' path='doc/member[@name="ServerInformation.dwServerPid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwServerPid;

    /// <include file='ServerInformation.xml' path='doc/member[@name="ServerInformation.dwServerTid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwServerTid;

    /// <include file='ServerInformation.xml' path='doc/member[@name="ServerInformation.ui64ServerAddress"]/*' />
    [NativeTypeName("UINT64")]
    public ulong ui64ServerAddress;
}
