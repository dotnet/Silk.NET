// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum CoreIndependentInputFilters : uint
{
    CoreIndependentInputFilters_None = 0,
    CoreIndependentInputFilters_MouseButton = 0x1,
    CoreIndependentInputFilters_MouseWheel = 0x2,
    CoreIndependentInputFilters_MouseHover = 0x4,
    CoreIndependentInputFilters_PenWithBarrel = 0x8,
    CoreIndependentInputFilters_PenInverted = 0x10,
}
