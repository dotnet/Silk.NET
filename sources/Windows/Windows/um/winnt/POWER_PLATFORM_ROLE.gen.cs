// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE"]/*'/>
public enum POWER_PLATFORM_ROLE
{
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleUnspecified"]/*'/>
    PlatformRoleUnspecified = 0,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleDesktop"]/*'/>
    PlatformRoleDesktop,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleMobile"]/*'/>
    PlatformRoleMobile,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleWorkstation"]/*'/>
    PlatformRoleWorkstation,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleEnterpriseServer"]/*'/>
    PlatformRoleEnterpriseServer,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleSOHOServer"]/*'/>
    PlatformRoleSOHOServer,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleAppliancePC"]/*'/>
    PlatformRoleAppliancePC,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRolePerformanceServer"]/*'/>
    PlatformRolePerformanceServer,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleSlate"]/*'/>
    PlatformRoleSlate,
    /// <include file='POWER_PLATFORM_ROLE.xml' path='doc/member[@name="POWER_PLATFORM_ROLE.PlatformRoleMaximum"]/*'/>
    PlatformRoleMaximum,
}