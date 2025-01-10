// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.diagnostics.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DiagnosticActionState
{
    DiagnosticActionState_Initializing = 0,
    DiagnosticActionState_Downloading = 1,
    DiagnosticActionState_VerifyingTrust = 2,
    DiagnosticActionState_Detecting = 3,
    DiagnosticActionState_Resolving = 4,
    DiagnosticActionState_VerifyingResolution = 5,
    DiagnosticActionState_Executing = 6,
}
