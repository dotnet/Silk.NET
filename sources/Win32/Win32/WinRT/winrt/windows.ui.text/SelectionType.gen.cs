// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SelectionType
{
    SelectionType_None = 0,
    SelectionType_InsertionPoint = 1,
    SelectionType_Normal = 2,
    SelectionType_InlineShape = 7,
    SelectionType_Shape = 8,
}
