// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PSAPI_WS_WATCH_INFORMATION_EX.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION_EX"]/*' />
public partial struct PSAPI_WS_WATCH_INFORMATION_EX
{
    /// <include file='PSAPI_WS_WATCH_INFORMATION_EX.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION_EX.BasicInfo"]/*' />
    public PSAPI_WS_WATCH_INFORMATION BasicInfo;

    /// <include file='PSAPI_WS_WATCH_INFORMATION_EX.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION_EX.FaultingThreadId"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint FaultingThreadId;

    /// <include file='PSAPI_WS_WATCH_INFORMATION_EX.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION_EX.Flags"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint Flags;
}
