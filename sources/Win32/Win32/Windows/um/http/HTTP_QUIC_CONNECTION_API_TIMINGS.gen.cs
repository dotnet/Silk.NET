// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_QUIC_CONNECTION_API_TIMINGS
{
    [NativeTypeName("ULONGLONG")]
    public ulong OpenTime;

    [NativeTypeName("ULONGLONG")]
    public ulong CloseTime;

    [NativeTypeName("ULONGLONG")]
    public ulong StartTime;

    [NativeTypeName("ULONGLONG")]
    public ulong ShutdownTime;

    [NativeTypeName("ULONGLONG")]
    public ulong SecConfigCreateTime;

    [NativeTypeName("ULONGLONG")]
    public ulong SecConfigDeleteTime;

    [NativeTypeName("ULONGLONG")]
    public ulong GetParamCount;

    [NativeTypeName("ULONGLONG")]
    public ulong GetParamSum;

    [NativeTypeName("ULONGLONG")]
    public ulong SetParamCount;

    [NativeTypeName("ULONGLONG")]
    public ulong SetParamSum;

    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerCount;

    [NativeTypeName("ULONGLONG")]
    public ulong SetCallbackHandlerSum;
    public HTTP_QUIC_STREAM_API_TIMINGS ControlStreamTimings;
}
