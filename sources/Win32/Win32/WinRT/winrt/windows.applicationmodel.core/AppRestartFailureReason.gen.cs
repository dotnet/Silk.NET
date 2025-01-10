// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppRestartFailureReason
{
    AppRestartFailureReason_RestartPending = 0,
    AppRestartFailureReason_NotInForeground = 1,
    AppRestartFailureReason_InvalidUser = 2,
    AppRestartFailureReason_Other = 3,
}
