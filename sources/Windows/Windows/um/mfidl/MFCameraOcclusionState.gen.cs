// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFCameraOcclusionState.xml' path='doc/member[@name="MFCameraOcclusionState"]/*'/>
public enum MFCameraOcclusionState
{
    /// <include file='MFCameraOcclusionState.xml' path='doc/member[@name="MFCameraOcclusionState.MFCameraOcclusionState_Open"]/*'/>
    MFCameraOcclusionState_Open = 0,
    /// <include file='MFCameraOcclusionState.xml' path='doc/member[@name="MFCameraOcclusionState.MFCameraOcclusionState_OccludedByLid"]/*'/>
    MFCameraOcclusionState_OccludedByLid = 0x1,
    /// <include file='MFCameraOcclusionState.xml' path='doc/member[@name="MFCameraOcclusionState.MFCameraOcclusionState_OccludedByCameraHardware"]/*'/>
    MFCameraOcclusionState_OccludedByCameraHardware = 0x2,
}