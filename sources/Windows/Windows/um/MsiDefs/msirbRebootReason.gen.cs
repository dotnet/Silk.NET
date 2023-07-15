// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason"]/*'/>
public enum msirbRebootReason
{
    /// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason.msirbRebootUndeterminedReason"]/*'/>
    msirbRebootUndeterminedReason = 0,
    /// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason.msirbRebootInUseFilesReason"]/*'/>
    msirbRebootInUseFilesReason = 1,
    /// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason.msirbRebootScheduleRebootReason"]/*'/>
    msirbRebootScheduleRebootReason = 2,
    /// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason.msirbRebootForceRebootReason"]/*'/>
    msirbRebootForceRebootReason = 3,
    /// <include file='msirbRebootReason.xml' path='doc/member[@name="msirbRebootReason.msirbRebootCustomActionReason"]/*'/>
    msirbRebootCustomActionReason = 4,
}