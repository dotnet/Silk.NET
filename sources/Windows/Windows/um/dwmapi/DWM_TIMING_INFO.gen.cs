// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_TIMING_INFO
{
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cbSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cbSize;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.rateRefresh"]/*'/>
    public UNSIGNED_RATIO rateRefresh;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcRefreshPeriod"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcRefreshPeriod;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.rateCompose"]/*'/>
    public UNSIGNED_RATIO rateCompose;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcVBlank"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcVBlank;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefresh"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefresh;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cDXRefresh"]/*'/>
    public uint cDXRefresh;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcCompose"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcCompose;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFrame"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrame;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cDXPresent"]/*'/>
    public uint cDXPresent;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshFrame"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshFrame;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFrameSubmitted"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameSubmitted;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cDXPresentSubmitted"]/*'/>
    public uint cDXPresentSubmitted;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFrameConfirmed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameConfirmed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cDXPresentConfirmed"]/*'/>
    public uint cDXPresentConfirmed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshConfirmed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshConfirmed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cDXRefreshConfirmed"]/*'/>
    public uint cDXRefreshConfirmed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesLate"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesLate;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesOutstanding"]/*'/>
    public uint cFramesOutstanding;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFrameDisplayed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcFrameDisplayed"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcFrameDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshFrameDisplayed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshFrameDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFrameComplete"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFrameComplete;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcFrameComplete"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcFrameComplete;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramePending"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramePending;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.qpcFramePending"]/*'/>
    [NativeTypeName("QPC_TIME")]
    public ulong qpcFramePending;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesDisplayed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesComplete"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesComplete;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesPending"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesPending;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesAvailable"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesAvailable;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesDropped"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesDropped;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cFramesMissed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cFramesMissed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshNextDisplayed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshNextDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshNextPresented"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshNextPresented;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshesDisplayed"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshesDisplayed;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshesPresented"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshesPresented;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cRefreshStarted"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshStarted;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cPixelsReceived"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong cPixelsReceived;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cPixelsDrawn"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong cPixelsDrawn;
    /// <include file='DWM_TIMING_INFO.xml' path='doc/member[@name="DWM_TIMING_INFO.cBuffersEmpty"]/*'/>
    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cBuffersEmpty;
}