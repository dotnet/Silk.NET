// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS"]/*'/>
public enum SCM_PD_LAST_FW_ACTIVATION_STATUS
{
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivationStatus_None"]/*'/>
    ScmPdLastFwActivationStatus_None = 0,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivationStatus_Success"]/*'/>
    ScmPdLastFwActivationStatus_Success = 1,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivationStatus_FwNotFound"]/*'/>
    ScmPdLastFwActivationStatus_FwNotFound = 2,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivationStatus_ColdRebootRequired"]/*'/>
    ScmPdLastFwActivationStatus_ColdRebootRequired = 3,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivaitonStatus_ActivationInProgress"]/*'/>
    ScmPdLastFwActivaitonStatus_ActivationInProgress = 4,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivaitonStatus_Retry"]/*'/>
    ScmPdLastFwActivaitonStatus_Retry = 5,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivaitonStatus_FwUnsupported"]/*'/>
    ScmPdLastFwActivaitonStatus_FwUnsupported = 6,
    /// <include file='SCM_PD_LAST_FW_ACTIVATION_STATUS.xml' path='doc/member[@name="SCM_PD_LAST_FW_ACTIVATION_STATUS.ScmPdLastFwActivaitonStatus_UnknownError"]/*'/>
    ScmPdLastFwActivaitonStatus_UnknownError = 7,
}