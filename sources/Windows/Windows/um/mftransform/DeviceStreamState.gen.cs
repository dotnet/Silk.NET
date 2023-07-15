// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DeviceStreamState.xml' path='doc/member[@name="DeviceStreamState"]/*'/>
public enum DeviceStreamState
{
    /// <include file='DeviceStreamState.xml' path='doc/member[@name="DeviceStreamState.DeviceStreamState_Stop"]/*'/>
    DeviceStreamState_Stop = 0,
    /// <include file='DeviceStreamState.xml' path='doc/member[@name="DeviceStreamState.DeviceStreamState_Pause"]/*'/>
    DeviceStreamState_Pause = (DeviceStreamState_Stop + 1),
    /// <include file='DeviceStreamState.xml' path='doc/member[@name="DeviceStreamState.DeviceStreamState_Run"]/*'/>
    DeviceStreamState_Run = (DeviceStreamState_Pause + 1),
    /// <include file='DeviceStreamState.xml' path='doc/member[@name="DeviceStreamState.DeviceStreamState_Disabled"]/*'/>
    DeviceStreamState_Disabled = (DeviceStreamState_Run + 1),
}