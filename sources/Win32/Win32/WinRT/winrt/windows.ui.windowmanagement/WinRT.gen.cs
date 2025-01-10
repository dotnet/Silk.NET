// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.windowmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[39]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindow =
        "Windows.UI.WindowManagement.IAppWindow";

    [NativeTypeName("const WCHAR[55]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowChangedEventArgs =
        "Windows.UI.WindowManagement.IAppWindowChangedEventArgs";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowCloseRequestedEventArgs =
        "Windows.UI.WindowManagement.IAppWindowCloseRequestedEventArgs";

    [NativeTypeName("const WCHAR[54]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowClosedEventArgs =
        "Windows.UI.WindowManagement.IAppWindowClosedEventArgs";

    [NativeTypeName("const WCHAR[44]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowFrame =
        "Windows.UI.WindowManagement.IAppWindowFrame";

    [NativeTypeName("const WCHAR[49]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowFrameStyle =
        "Windows.UI.WindowManagement.IAppWindowFrameStyle";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowPlacement =
        "Windows.UI.WindowManagement.IAppWindowPlacement";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowPresentationConfiguration =
        "Windows.UI.WindowManagement.IAppWindowPresentationConfiguration";

    [NativeTypeName("const WCHAR[71]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowPresentationConfigurationFactory =
        "Windows.UI.WindowManagement.IAppWindowPresentationConfigurationFactory";

    [NativeTypeName("const WCHAR[48]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowPresenter =
        "Windows.UI.WindowManagement.IAppWindowPresenter";

    [NativeTypeName("const WCHAR[46]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowStatics =
        "Windows.UI.WindowManagement.IAppWindowStatics";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowTitleBar =
        "Windows.UI.WindowManagement.IAppWindowTitleBar";

    [NativeTypeName("const WCHAR[56]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowTitleBarOcclusion =
        "Windows.UI.WindowManagement.IAppWindowTitleBarOcclusion";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IAppWindowTitleBarVisibility =
        "Windows.UI.WindowManagement.IAppWindowTitleBarVisibility";

    [NativeTypeName("const WCHAR[69]")]
    public const string InterfaceName_Windows_UI_WindowManagement_ICompactOverlayPresentationConfiguration =
        "Windows.UI.WindowManagement.ICompactOverlayPresentationConfiguration";

    [NativeTypeName("const WCHAR[62]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IDefaultPresentationConfiguration =
        "Windows.UI.WindowManagement.IDefaultPresentationConfiguration";

    [NativeTypeName("const WCHAR[43]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IDisplayRegion =
        "Windows.UI.WindowManagement.IDisplayRegion";

    [NativeTypeName("const WCHAR[65]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IFullScreenPresentationConfiguration =
        "Windows.UI.WindowManagement.IFullScreenPresentationConfiguration";

    [NativeTypeName("const WCHAR[51]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowServicesStatics =
        "Windows.UI.WindowManagement.IWindowServicesStatics";

    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowingEnvironment =
        "Windows.UI.WindowManagement.IWindowingEnvironment";

    [NativeTypeName("const WCHAR[64]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowingEnvironmentAddedEventArgs =
        "Windows.UI.WindowManagement.IWindowingEnvironmentAddedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowingEnvironmentChangedEventArgs =
        "Windows.UI.WindowManagement.IWindowingEnvironmentChangedEventArgs";

    [NativeTypeName("const WCHAR[66]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowingEnvironmentRemovedEventArgs =
        "Windows.UI.WindowManagement.IWindowingEnvironmentRemovedEventArgs";

    [NativeTypeName("const WCHAR[57]")]
    public const string InterfaceName_Windows_UI_WindowManagement_IWindowingEnvironmentStatics =
        "Windows.UI.WindowManagement.IWindowingEnvironmentStatics";

    [NativeTypeName("const WCHAR[38]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindow =
        "Windows.UI.WindowManagement.AppWindow";

    [NativeTypeName("const WCHAR[54]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowChangedEventArgs =
        "Windows.UI.WindowManagement.AppWindowChangedEventArgs";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowCloseRequestedEventArgs =
        "Windows.UI.WindowManagement.AppWindowCloseRequestedEventArgs";

    [NativeTypeName("const WCHAR[53]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowClosedEventArgs =
        "Windows.UI.WindowManagement.AppWindowClosedEventArgs";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowFrame =
        "Windows.UI.WindowManagement.AppWindowFrame";

    [NativeTypeName("const WCHAR[47]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowPlacement =
        "Windows.UI.WindowManagement.AppWindowPlacement";

    [NativeTypeName("const WCHAR[63]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowPresentationConfiguration =
        "Windows.UI.WindowManagement.AppWindowPresentationConfiguration";

    [NativeTypeName("const WCHAR[47]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowPresenter =
        "Windows.UI.WindowManagement.AppWindowPresenter";

    [NativeTypeName("const WCHAR[46]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowTitleBar =
        "Windows.UI.WindowManagement.AppWindowTitleBar";

    [NativeTypeName("const WCHAR[55]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_AppWindowTitleBarOcclusion =
        "Windows.UI.WindowManagement.AppWindowTitleBarOcclusion";

    [NativeTypeName("const WCHAR[68]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_CompactOverlayPresentationConfiguration =
        "Windows.UI.WindowManagement.CompactOverlayPresentationConfiguration";

    [NativeTypeName("const WCHAR[61]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_DefaultPresentationConfiguration =
        "Windows.UI.WindowManagement.DefaultPresentationConfiguration";

    [NativeTypeName("const WCHAR[42]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_DisplayRegion =
        "Windows.UI.WindowManagement.DisplayRegion";

    [NativeTypeName("const WCHAR[64]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_FullScreenPresentationConfiguration =
        "Windows.UI.WindowManagement.FullScreenPresentationConfiguration";

    [NativeTypeName("const WCHAR[43]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_WindowServices =
        "Windows.UI.WindowManagement.WindowServices";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_WindowingEnvironment =
        "Windows.UI.WindowManagement.WindowingEnvironment";

    [NativeTypeName("const WCHAR[63]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_WindowingEnvironmentAddedEventArgs =
        "Windows.UI.WindowManagement.WindowingEnvironmentAddedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_WindowingEnvironmentChangedEventArgs =
        "Windows.UI.WindowManagement.WindowingEnvironmentChangedEventArgs";

    [NativeTypeName("const WCHAR[65]")]
    public const string RuntimeClass_Windows_UI_WindowManagement_WindowingEnvironmentRemovedEventArgs =
        "Windows.UI.WindowManagement.WindowingEnvironmentRemovedEventArgs";
}
