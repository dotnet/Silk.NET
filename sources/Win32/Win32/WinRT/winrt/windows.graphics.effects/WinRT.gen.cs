// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.effects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public static partial class WinRT
{
    [NativeTypeName("const WCHAR[41]")]
    public const string InterfaceName_Windows_Graphics_Effects_IGraphicsEffect =
        "Windows.Graphics.Effects.IGraphicsEffect";

    [NativeTypeName("const WCHAR[47]")]
    public const string InterfaceName_Windows_Graphics_Effects_IGraphicsEffectSource =
        "Windows.Graphics.Effects.IGraphicsEffectSource";
}
