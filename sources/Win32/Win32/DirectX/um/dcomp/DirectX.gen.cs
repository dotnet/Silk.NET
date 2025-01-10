// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateDevice(
        IDXGIDevice dxgiDevice,
        [NativeTypeName("const IID &")] Guid* iid,
        void** dcompositionDevice
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT DCompositionCreateDevice2(
        IUnknown renderingDevice,
        [NativeTypeName("const IID &")] Guid* iid,
        void** dcompositionDevice
    );

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionCreateDevice3(
        IUnknown renderingDevice,
        [NativeTypeName("const IID &")] Guid* iid,
        void** dcompositionDevice
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT DCompositionCreateSurfaceHandle(
        [NativeTypeName("DWORD")] uint desiredAccess,
        SECURITY_ATTRIBUTES* securityAttributes,
        HANDLE* surfaceHandle
    );

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseWheelToHwnd(
        IDCompositionVisual visual,
        HWND hwnd,
        BOOL enable
    );

    [DllImport("dcomp", ExactSpelling = true)]
    public static extern HRESULT DCompositionAttachMouseDragToHwnd(
        IDCompositionVisual visual,
        HWND hwnd,
        BOOL enable
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT DCompositionGetFrameId(
        COMPOSITION_FRAME_ID_TYPE frameIdType,
        [NativeTypeName("COMPOSITION_FRAME_ID *")] ulong* frameId
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT DCompositionGetStatistics(
        [NativeTypeName("COMPOSITION_FRAME_ID")] ulong frameId,
        COMPOSITION_FRAME_STATS* frameStats,
        uint targetIdCount,
        COMPOSITION_TARGET_ID* targetIds,
        uint* actualTargetIdCount
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT DCompositionGetTargetStatistics(
        [NativeTypeName("COMPOSITION_FRAME_ID")] ulong frameId,
        [NativeTypeName("const COMPOSITION_TARGET_ID *")] COMPOSITION_TARGET_ID* targetId,
        COMPOSITION_TARGET_STATS* targetStats
    );

    [DllImport("dcomp", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern HRESULT DCompositionBoostCompositorClock(BOOL enable);

    [DllImport("dcomp", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows10.0.22000.0")]
    public static extern uint DCompositionWaitForCompositorClock(
        uint count,
        [NativeTypeName("const HANDLE *")] HANDLE* handles,
        [NativeTypeName("DWORD")] uint timeoutInMs
    );
}
