// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintWorkflowUICompletionStatus
{
    PrintWorkflowUICompletionStatus_Completed = 0,
    PrintWorkflowUICompletionStatus_LaunchFailed = 1,
    PrintWorkflowUICompletionStatus_JobFailed = 2,
    PrintWorkflowUICompletionStatus_UserCanceled = 3,
}
