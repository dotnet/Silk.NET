// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum AppDiagnosticInfoWatcherStatus
{
    AppDiagnosticInfoWatcherStatus_Created = 0,
    AppDiagnosticInfoWatcherStatus_Started = 1,
    AppDiagnosticInfoWatcherStatus_EnumerationCompleted = 2,
    AppDiagnosticInfoWatcherStatus_Stopping = 3,
    AppDiagnosticInfoWatcherStatus_Stopped = 4,
    AppDiagnosticInfoWatcherStatus_Aborted = 5,
}
