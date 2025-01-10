// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tcpestats.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TCP_ESTATS_SND_CONG_ROD_v0
{
    [NativeTypeName("ULONG")]
    public uint SndLimTransRwin;

    [NativeTypeName("ULONG")]
    public uint SndLimTimeRwin;

    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesRwin;

    [NativeTypeName("ULONG")]
    public uint SndLimTransCwnd;

    [NativeTypeName("ULONG")]
    public uint SndLimTimeCwnd;

    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesCwnd;

    [NativeTypeName("ULONG")]
    public uint SndLimTransSnd;

    [NativeTypeName("ULONG")]
    public uint SndLimTimeSnd;

    [NativeTypeName("SIZE_T")]
    public nuint SndLimBytesSnd;

    [NativeTypeName("ULONG")]
    public uint SlowStart;

    [NativeTypeName("ULONG")]
    public uint CongAvoid;

    [NativeTypeName("ULONG")]
    public uint OtherReductions;

    [NativeTypeName("ULONG")]
    public uint CurCwnd;

    [NativeTypeName("ULONG")]
    public uint MaxSsCwnd;

    [NativeTypeName("ULONG")]
    public uint MaxCaCwnd;

    [NativeTypeName("ULONG")]
    public uint CurSsthresh;

    [NativeTypeName("ULONG")]
    public uint MaxSsthresh;

    [NativeTypeName("ULONG")]
    public uint MinSsthresh;
}
