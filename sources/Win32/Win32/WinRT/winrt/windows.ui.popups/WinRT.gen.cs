// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.popups.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[33]")]
    public const string InterfaceName_Windows_UI_Popups_IMessageDialog =
        "Windows.UI.Popups.IMessageDialog";

    [NativeTypeName("const WCHAR[40]")]
    public const string InterfaceName_Windows_UI_Popups_IMessageDialogFactory =
        "Windows.UI.Popups.IMessageDialogFactory";

    [NativeTypeName("const WCHAR[29]")]
    public const string InterfaceName_Windows_UI_Popups_IPopupMenu = "Windows.UI.Popups.IPopupMenu";

    [NativeTypeName("const WCHAR[29]")]
    public const string InterfaceName_Windows_UI_Popups_IUICommand = "Windows.UI.Popups.IUICommand";

    [NativeTypeName("const WCHAR[36]")]
    public const string InterfaceName_Windows_UI_Popups_IUICommandFactory =
        "Windows.UI.Popups.IUICommandFactory";

    [NativeTypeName("const WCHAR[32]")]
    public const string RuntimeClass_Windows_UI_Popups_MessageDialog =
        "Windows.UI.Popups.MessageDialog";

    [NativeTypeName("const WCHAR[28]")]
    public const string RuntimeClass_Windows_UI_Popups_PopupMenu = "Windows.UI.Popups.PopupMenu";

    [NativeTypeName("const WCHAR[28]")]
    public const string RuntimeClass_Windows_UI_Popups_UICommand = "Windows.UI.Popups.UICommand";

    [NativeTypeName("const WCHAR[37]")]
    public const string RuntimeClass_Windows_UI_Popups_UICommandSeparator =
        "Windows.UI.Popups.UICommandSeparator";
}
