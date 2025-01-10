// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum RangeGravity
{
    RangeGravity_UIBehavior = 0,
    RangeGravity_Backward = 1,
    RangeGravity_Forward = 2,
    RangeGravity_Inward = 3,
    RangeGravity_Outward = 4,
}
