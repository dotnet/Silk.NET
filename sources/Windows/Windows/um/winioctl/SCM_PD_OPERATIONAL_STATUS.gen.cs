// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS"]/*'/>
public enum SCM_PD_OPERATIONAL_STATUS
{
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_Unknown"]/*'/>
    ScmPhysicalDeviceOpStatus_Unknown = 0,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_Ok"]/*'/>
    ScmPhysicalDeviceOpStatus_Ok,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_PredictingFailure"]/*'/>
    ScmPhysicalDeviceOpStatus_PredictingFailure,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_InService"]/*'/>
    ScmPhysicalDeviceOpStatus_InService,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_HardwareError"]/*'/>
    ScmPhysicalDeviceOpStatus_HardwareError,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_NotUsable"]/*'/>
    ScmPhysicalDeviceOpStatus_NotUsable,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_TransientError"]/*'/>
    ScmPhysicalDeviceOpStatus_TransientError,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_Missing"]/*'/>
    ScmPhysicalDeviceOpStatus_Missing,
    /// <include file='SCM_PD_OPERATIONAL_STATUS.xml' path='doc/member[@name="SCM_PD_OPERATIONAL_STATUS.ScmPhysicalDeviceOpStatus_Max"]/*'/>
    ScmPhysicalDeviceOpStatus_Max,
}