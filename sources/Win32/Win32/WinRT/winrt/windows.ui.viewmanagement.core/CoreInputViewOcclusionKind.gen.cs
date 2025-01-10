// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum CoreInputViewOcclusionKind
{
    CoreInputViewOcclusionKind_Docked = 0,
    CoreInputViewOcclusionKind_Floating = 1,
    CoreInputViewOcclusionKind_Overlay = 2,
}
