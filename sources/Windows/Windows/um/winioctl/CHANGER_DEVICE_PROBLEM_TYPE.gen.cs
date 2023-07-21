// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE"]/*' />
public enum CHANGER_DEVICE_PROBLEM_TYPE
{
    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemNone"]/*' />
    DeviceProblemNone,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemHardware"]/*' />
    DeviceProblemHardware,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCHMError"]/*' />
    DeviceProblemCHMError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemDoorOpen"]/*' />
    DeviceProblemDoorOpen,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCalibrationError"]/*' />
    DeviceProblemCalibrationError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemTargetFailure"]/*' />
    DeviceProblemTargetFailure,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCHMMoveError"]/*' />
    DeviceProblemCHMMoveError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCHMZeroError"]/*' />
    DeviceProblemCHMZeroError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCartridgeInsertError"]/*' />
    DeviceProblemCartridgeInsertError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemPositionError"]/*' />
    DeviceProblemPositionError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemSensorError"]/*' />
    DeviceProblemSensorError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemCartridgeEjectError"]/*' />
    DeviceProblemCartridgeEjectError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemGripperError"]/*' />
    DeviceProblemGripperError,

    /// <include file='CHANGER_DEVICE_PROBLEM_TYPE.xml' path='doc/member[@name="CHANGER_DEVICE_PROBLEM_TYPE.DeviceProblemDriveError"]/*' />
    DeviceProblemDriveError,
}
