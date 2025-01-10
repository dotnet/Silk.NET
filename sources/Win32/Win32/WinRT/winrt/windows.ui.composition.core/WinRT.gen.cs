// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[50]")]
    public const string InterfaceName_Windows_UI_Composition_Core_ICompositorController =
        "Windows.UI.Composition.Core.ICompositorController";

    [NativeTypeName("const WCHAR[49]")]
    public const string RuntimeClass_Windows_UI_Composition_Core_CompositorController =
        "Windows.UI.Composition.Core.CompositorController";
}
