// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION"]/*' />
public unsafe partial struct TRANSACTIONMANAGER_LOGPATH_INFORMATION
{
    /// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION.LogPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint LogPathLength;

    /// <include file='TRANSACTIONMANAGER_LOGPATH_INFORMATION.xml' path='doc/member[@name="TRANSACTIONMANAGER_LOGPATH_INFORMATION.LogPath"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort LogPath[1];
}
