// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CoreInputViewKind
{
    CoreInputViewKind_Default = 0,
    CoreInputViewKind_Keyboard = 1,
    CoreInputViewKind_Handwriting = 2,
    CoreInputViewKind_Emoji = 3,
    CoreInputViewKind_Symbols = 4,
    CoreInputViewKind_Clipboard = 5,
    CoreInputViewKind_Dictation = 6,
}
