// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShellScalingApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScaleFactorForDevice"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern DEVICE_SCALE_FACTOR GetScaleFactorForDevice(DISPLAY_DEVICE_TYPE deviceType);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterScaleChangeNotifications"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RegisterScaleChangeNotifications(DISPLAY_DEVICE_TYPE displayDevice, HWND hwndNotify, uint uMsgNotify, [NativeTypeName("DWORD *")] uint* pdwCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RevokeScaleChangeNotifications"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT RevokeScaleChangeNotifications(DISPLAY_DEVICE_TYPE displayDevice, [NativeTypeName("DWORD")] uint dwCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetScaleFactorForMonitor"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetScaleFactorForMonitor(HMONITOR hMon, DEVICE_SCALE_FACTOR* pScale);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RegisterScaleChangeEvent"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT RegisterScaleChangeEvent(HANDLE hEvent, [NativeTypeName("DWORD_PTR *")] nuint* pdwCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UnregisterScaleChangeEvent"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT UnregisterScaleChangeEvent([NativeTypeName("DWORD_PTR")] nuint dwCookie);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.SetProcessDpiAwareness"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT SetProcessDpiAwareness(PROCESS_DPI_AWARENESS value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetProcessDpiAwareness"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetProcessDpiAwareness(HANDLE hprocess, PROCESS_DPI_AWARENESS* value);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiForMonitor"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT GetDpiForMonitor(HMONITOR hmonitor, MONITOR_DPI_TYPE dpiType, uint* dpiX, uint* dpiY);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GetDpiForShellUIComponent"]/*'/>
    [DllImport("shcore", ExactSpelling = true)]
    public static extern uint GetDpiForShellUIComponent(SHELL_UI_COMPONENT param0);
}