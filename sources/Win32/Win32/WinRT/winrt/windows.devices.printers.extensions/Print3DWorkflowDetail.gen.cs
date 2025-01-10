// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum Print3DWorkflowDetail
{
    Print3DWorkflowDetail_Unknown = 0,
    Print3DWorkflowDetail_ModelExceedsPrintBed = 1,
    Print3DWorkflowDetail_UploadFailed = 2,
    Print3DWorkflowDetail_InvalidMaterialSelection = 3,
    Print3DWorkflowDetail_InvalidModel = 4,
    Print3DWorkflowDetail_ModelNotManifold = 5,
    Print3DWorkflowDetail_InvalidPrintTicket = 6,
}
