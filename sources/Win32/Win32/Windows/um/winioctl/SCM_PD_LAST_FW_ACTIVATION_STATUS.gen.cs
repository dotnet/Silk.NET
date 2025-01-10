// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SCM_PD_LAST_FW_ACTIVATION_STATUS
{
    ScmPdLastFwActivationStatus_None = 0,
    ScmPdLastFwActivationStatus_Success = 1,
    ScmPdLastFwActivationStatus_FwNotFound = 2,
    ScmPdLastFwActivationStatus_ColdRebootRequired = 3,
    ScmPdLastFwActivaitonStatus_ActivationInProgress = 4,
    ScmPdLastFwActivaitonStatus_Retry = 5,
    ScmPdLastFwActivaitonStatus_FwUnsupported = 6,
    ScmPdLastFwActivaitonStatus_UnknownError = 7,
}
