// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern DEVICE_SCALE_FACTOR GetScaleFactorForDevice(
        DISPLAY_DEVICE_TYPE deviceType
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RegisterScaleChangeNotifications(
        DISPLAY_DEVICE_TYPE displayDevice,
        HWND hwndNotify,
        uint uMsgNotify,
        [NativeTypeName("DWORD *")] uint* pdwCookie
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RevokeScaleChangeNotifications(
        DISPLAY_DEVICE_TYPE displayDevice,
        [NativeTypeName("DWORD")] uint dwCookie
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetScaleFactorForMonitor(
        HMONITOR hMon,
        DEVICE_SCALE_FACTOR* pScale
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterScaleChangeEvent(
        HANDLE hEvent,
        [NativeTypeName("DWORD_PTR *")] nuint* pdwCookie
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT UnregisterScaleChangeEvent(
        [NativeTypeName("DWORD_PTR")] nuint dwCookie
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SetProcessDpiAwareness(PROCESS_DPI_AWARENESS value);

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetProcessDpiAwareness(
        HANDLE hprocess,
        PROCESS_DPI_AWARENESS* value
    );

    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetDpiForMonitor(
        HMONITOR hmonitor,
        MONITOR_DPI_TYPE dpiType,
        uint* dpiX,
        uint* dpiY
    );

    [DllImport("shcore", ExactSpelling = true)]
    public static extern uint GetDpiForShellUIComponent(SHELL_UI_COMPONENT param0);
}
