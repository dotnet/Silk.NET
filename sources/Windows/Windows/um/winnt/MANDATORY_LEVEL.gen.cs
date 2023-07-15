// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MANDATORY_LEVEL
{
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelUntrusted"]/*'/>
    MandatoryLevelUntrusted = 0,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelLow"]/*'/>
    MandatoryLevelLow,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelMedium"]/*'/>
    MandatoryLevelMedium,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelHigh"]/*'/>
    MandatoryLevelHigh,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelSystem"]/*'/>
    MandatoryLevelSystem,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelSecureProcess"]/*'/>
    MandatoryLevelSecureProcess,
    /// <include file='MANDATORY_LEVEL.xml' path='doc/member[@name="MANDATORY_LEVEL.MandatoryLevelCount"]/*'/>
    MandatoryLevelCount,
}