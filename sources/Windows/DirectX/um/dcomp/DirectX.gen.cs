// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateDevice(IDXGIDevice* dxgiDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice2"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DCompositionCreateDevice2(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateDevice3"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionCreateDevice3(IUnknown* renderingDevice, [NativeTypeName("const IID &")] Guid* iid, void** dcompositionDevice);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionCreateSurfaceHandle"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateSurfaceHandle([NativeTypeName("DWORD")] uint desiredAccess, SECURITY_ATTRIBUTES* securityAttributes, HANDLE* surfaceHandle);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionAttachMouseWheelToHwnd"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseWheelToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionAttachMouseDragToHwnd"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseDragToHwnd(IDCompositionVisual* visual, HWND hwnd, BOOL enable);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionGetFrameId"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionGetFrameId(COMPOSITION_FRAME_ID_TYPE frameIdType, [NativeTypeName("COMPOSITION_FRAME_ID *")] ulong* frameId);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionGetStatistics"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionGetStatistics([NativeTypeName("COMPOSITION_FRAME_ID")] ulong frameId, COMPOSITION_FRAME_STATS* frameStats, uint targetIdCount, COMPOSITION_TARGET_ID* targetIds, uint* actualTargetIdCount);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionGetTargetStatistics"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionGetTargetStatistics([NativeTypeName("COMPOSITION_FRAME_ID")] ulong frameId, [NativeTypeName("const COMPOSITION_TARGET_ID *")] COMPOSITION_TARGET_ID* targetId, COMPOSITION_TARGET_STATS* targetStats);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionBoostCompositorClock"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionBoostCompositorClock(BOOL enable);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DCompositionWaitForCompositorClock"]/*' />
    [DllImport("dcomp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint DCompositionWaitForCompositorClock(uint count, [NativeTypeName("const HANDLE *")] HANDLE* handles, [NativeTypeName("DWORD")] uint timeoutInMs);
}
