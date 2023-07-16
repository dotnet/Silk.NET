// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_PD_MEDIA_REINITIALIZATION_STATUS.xml' path='doc/member[@name="SCM_PD_MEDIA_REINITIALIZATION_STATUS"]/*'/>
public enum SCM_PD_MEDIA_REINITIALIZATION_STATUS
{
    /// <include file='SCM_PD_MEDIA_REINITIALIZATION_STATUS.xml' path='doc/member[@name="SCM_PD_MEDIA_REINITIALIZATION_STATUS.ScmPhysicalDeviceReinit_Success"]/*'/>
    ScmPhysicalDeviceReinit_Success = 0,
    /// <include file='SCM_PD_MEDIA_REINITIALIZATION_STATUS.xml' path='doc/member[@name="SCM_PD_MEDIA_REINITIALIZATION_STATUS.ScmPhysicalDeviceReinit_RebootNeeded"]/*'/>
    ScmPhysicalDeviceReinit_RebootNeeded,
    /// <include file='SCM_PD_MEDIA_REINITIALIZATION_STATUS.xml' path='doc/member[@name="SCM_PD_MEDIA_REINITIALIZATION_STATUS.ScmPhysicalDeviceReinit_ColdBootNeeded"]/*'/>
    ScmPhysicalDeviceReinit_ColdBootNeeded,
    /// <include file='SCM_PD_MEDIA_REINITIALIZATION_STATUS.xml' path='doc/member[@name="SCM_PD_MEDIA_REINITIALIZATION_STATUS.ScmPhysicalDeviceReinit_Max"]/*'/>
    ScmPhysicalDeviceReinit_Max,
}