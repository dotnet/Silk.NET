// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.viewmanagement.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Obsolete(
    "ApplicationViewState may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly."
)]
public enum ApplicationViewState
{
    ApplicationViewState_FullScreenLandscape = 0,
    ApplicationViewState_Filled = 1,
    ApplicationViewState_Snapped = 2,
    ApplicationViewState_FullScreenPortrait = 3,
}
