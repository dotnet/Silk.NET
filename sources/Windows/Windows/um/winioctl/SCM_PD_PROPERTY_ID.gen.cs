// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID"]/*'/>
public enum SCM_PD_PROPERTY_ID
{
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_DeviceInfo"]/*'/>
    ScmPhysicalDeviceProperty_DeviceInfo = 0,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_ManagementStatus"]/*'/>
    ScmPhysicalDeviceProperty_ManagementStatus,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_FirmwareInfo"]/*'/>
    ScmPhysicalDeviceProperty_FirmwareInfo,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_LocationString"]/*'/>
    ScmPhysicalDeviceProperty_LocationString,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_DeviceSpecificInfo"]/*'/>
    ScmPhysicalDeviceProperty_DeviceSpecificInfo,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_DeviceHandle"]/*'/>
    ScmPhysicalDeviceProperty_DeviceHandle,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_FruIdString"]/*'/>
    ScmPhysicalDeviceProperty_FruIdString,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_RuntimeFwActivationInfo"]/*'/>
    ScmPhysicalDeviceProperty_RuntimeFwActivationInfo,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_RuntimeFwActivationArmState"]/*'/>
    ScmPhysicalDeviceProperty_RuntimeFwActivationArmState,
    /// <include file='SCM_PD_PROPERTY_ID.xml' path='doc/member[@name="SCM_PD_PROPERTY_ID.ScmPhysicalDeviceProperty_Max"]/*'/>
    ScmPhysicalDeviceProperty_Max,
}