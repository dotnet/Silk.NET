// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.workflow.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintWorkflowJobIssueKind
{
    PrintWorkflowJobIssueKind_Other = 0,
    PrintWorkflowJobIssueKind_AttentionRequired = 1,
    PrintWorkflowJobIssueKind_DoorOpen = 2,
    PrintWorkflowJobIssueKind_MarkerSupplyLow = 3,
    PrintWorkflowJobIssueKind_MarkerSupplyEmpty = 4,
    PrintWorkflowJobIssueKind_MediaJam = 5,
    PrintWorkflowJobIssueKind_MediaEmpty = 6,
    PrintWorkflowJobIssueKind_MediaLow = 7,
    PrintWorkflowJobIssueKind_OutputAreaAlmostFull = 8,
    PrintWorkflowJobIssueKind_OutputAreaFull = 9,
    PrintWorkflowJobIssueKind_JobPrintingError = 10,
}
