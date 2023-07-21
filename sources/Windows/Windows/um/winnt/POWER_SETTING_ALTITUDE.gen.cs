// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE"]/*' />
public enum POWER_SETTING_ALTITUDE
{
    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_GROUP_POLICY"]/*' />
    ALTITUDE_GROUP_POLICY,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_USER"]/*' />
    ALTITUDE_USER,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_RUNTIME_OVERRIDE"]/*' />
    ALTITUDE_RUNTIME_OVERRIDE,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_PROVISIONING"]/*' />
    ALTITUDE_PROVISIONING,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_OEM_CUSTOMIZATION"]/*' />
    ALTITUDE_OEM_CUSTOMIZATION,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_INTERNAL_OVERRIDE"]/*' />
    ALTITUDE_INTERNAL_OVERRIDE,

    /// <include file='POWER_SETTING_ALTITUDE.xml' path='doc/member[@name="POWER_SETTING_ALTITUDE.ALTITUDE_OS_DEFAULT"]/*' />
    ALTITUDE_OS_DEFAULT,
}
