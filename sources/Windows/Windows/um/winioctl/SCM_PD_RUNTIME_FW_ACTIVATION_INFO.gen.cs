// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCM_PD_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_PD_RUNTIME_FW_ACTIVATION_INFO"]/*'/>
public partial struct SCM_PD_RUNTIME_FW_ACTIVATION_INFO
{
    /// <include file='SCM_PD_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_PD_RUNTIME_FW_ACTIVATION_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='SCM_PD_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_PD_RUNTIME_FW_ACTIVATION_INFO.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SCM_PD_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_PD_RUNTIME_FW_ACTIVATION_INFO.LastFirmwareActivationStatus"]/*'/>
    public SCM_PD_LAST_FW_ACTIVATION_STATUS LastFirmwareActivationStatus;
    /// <include file='SCM_PD_RUNTIME_FW_ACTIVATION_INFO.xml' path='doc/member[@name="SCM_PD_RUNTIME_FW_ACTIVATION_INFO.FirmwareActivationState"]/*'/>
    public SCM_PD_FIRMWARE_ACTIVATION_STATE FirmwareActivationState;
}