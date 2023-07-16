// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE"]/*'/>
public enum TAPE_DRIVE_PROBLEM_TYPE
{
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveProblemNone"]/*'/>
    TapeDriveProblemNone,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveReadWriteWarning"]/*'/>
    TapeDriveReadWriteWarning,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveReadWriteError"]/*'/>
    TapeDriveReadWriteError,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveReadWarning"]/*'/>
    TapeDriveReadWarning,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveWriteWarning"]/*'/>
    TapeDriveWriteWarning,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveReadError"]/*'/>
    TapeDriveReadError,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveWriteError"]/*'/>
    TapeDriveWriteError,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveHardwareError"]/*'/>
    TapeDriveHardwareError,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveUnsupportedMedia"]/*'/>
    TapeDriveUnsupportedMedia,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveScsiConnectionError"]/*'/>
    TapeDriveScsiConnectionError,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveTimetoClean"]/*'/>
    TapeDriveTimetoClean,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveCleanDriveNow"]/*'/>
    TapeDriveCleanDriveNow,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveMediaLifeExpired"]/*'/>
    TapeDriveMediaLifeExpired,
    /// <include file='TAPE_DRIVE_PROBLEM_TYPE.xml' path='doc/member[@name="TAPE_DRIVE_PROBLEM_TYPE.TapeDriveSnappedTape"]/*'/>
    TapeDriveSnappedTape,
}