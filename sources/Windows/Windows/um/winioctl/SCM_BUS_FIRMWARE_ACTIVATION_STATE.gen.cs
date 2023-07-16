// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_BUS_FIRMWARE_ACTIVATION_STATE.xml' path='doc/member[@name="SCM_BUS_FIRMWARE_ACTIVATION_STATE"]/*'/>
public enum SCM_BUS_FIRMWARE_ACTIVATION_STATE
{
    /// <include file='SCM_BUS_FIRMWARE_ACTIVATION_STATE.xml' path='doc/member[@name="SCM_BUS_FIRMWARE_ACTIVATION_STATE.ScmBusFirmwareActivationState_Idle"]/*'/>
    ScmBusFirmwareActivationState_Idle = 0,
    /// <include file='SCM_BUS_FIRMWARE_ACTIVATION_STATE.xml' path='doc/member[@name="SCM_BUS_FIRMWARE_ACTIVATION_STATE.ScmBusFirmwareActivationState_Armed"]/*'/>
    ScmBusFirmwareActivationState_Armed = 1,
    /// <include file='SCM_BUS_FIRMWARE_ACTIVATION_STATE.xml' path='doc/member[@name="SCM_BUS_FIRMWARE_ACTIVATION_STATE.ScmBusFirmwareActivationState_Busy"]/*'/>
    ScmBusFirmwareActivationState_Busy = 2,
}