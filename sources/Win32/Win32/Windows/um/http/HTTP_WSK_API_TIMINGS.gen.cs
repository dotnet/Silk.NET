// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_WSK_API_TIMINGS
{
    [NativeTypeName("ULONGLONG")]
    public ulong ConnectCount;

    [NativeTypeName("ULONGLONG")]
    public ulong ConnectSum;

    [NativeTypeName("ULONGLONG")]
    public ulong DisconnectCount;

    [NativeTypeName("ULONGLONG")]
    public ulong DisconnectSum;

    [NativeTypeName("ULONGLONG")]
    public ulong SendCount;

    [NativeTypeName("ULONGLONG")]
    public ulong SendSum;

    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveCount;

    [NativeTypeName("ULONGLONG")]
    public ulong ReceiveSum;

    [NativeTypeName("ULONGLONG")]
    public ulong ReleaseCount;

    [NativeTypeName("ULONGLONG")]
    public ulong ReleaseSum;

    [NativeTypeName("ULONGLONG")]
    public ulong ControlSocketCount;

    [NativeTypeName("ULONGLONG")]
    public ulong ControlSocketSum;
}
