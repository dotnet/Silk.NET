// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_TIMING_INFO
{
    [NativeTypeName("UINT32")]
    public uint cbSize;
    public UNSIGNED_RATIO rateRefresh;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcRefreshPeriod;
    public UNSIGNED_RATIO rateCompose;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcVBlank;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefresh;
    public uint cDXRefresh;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcCompose;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrame;
    public uint cDXPresent;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshFrame;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameSubmitted;
    public uint cDXPresentSubmitted;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameConfirmed;
    public uint cDXPresentConfirmed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshConfirmed;
    public uint cDXRefreshConfirmed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesLate;
    public uint cFramesOutstanding;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameDisplayed;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcFrameDisplayed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshFrameDisplayed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameComplete;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcFrameComplete;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramePending;

    [NativeTypeName("QPC_TIME")]
    public ulong qpcFramePending;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesDisplayed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesComplete;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesPending;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesAvailable;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesDropped;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesMissed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshNextDisplayed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshNextPresented;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshesDisplayed;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshesPresented;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshStarted;

    [NativeTypeName("ULONGLONG")]
    public ulong cPixelsReceived;

    [NativeTypeName("ULONGLONG")]
    public ulong cPixelsDrawn;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cBuffersEmpty;
}
