// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY"]/*'/>
public partial struct ADMINISTRATOR_POWER_POLICY
{
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinSleep"]/*'/>
    public SYSTEM_POWER_STATE MinSleep;
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxSleep"]/*'/>
    public SYSTEM_POWER_STATE MaxSleep;
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinVideoTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinVideoTimeout;
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxVideoTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxVideoTimeout;
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MinSpindownTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinSpindownTimeout;
    /// <include file='ADMINISTRATOR_POWER_POLICY.xml' path='doc/member[@name="ADMINISTRATOR_POWER_POLICY.MaxSpindownTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxSpindownTimeout;
}