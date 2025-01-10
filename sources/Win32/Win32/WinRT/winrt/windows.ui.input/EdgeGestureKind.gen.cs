// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum EdgeGestureKind
{
    EdgeGestureKind_Touch = 0,
    EdgeGestureKind_Keyboard = 1,
    EdgeGestureKind_Mouse = 2,
}
