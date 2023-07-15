// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POWER_SESSION_RIT_STATE.xml' path='doc/member[@name="POWER_SESSION_RIT_STATE"]/*'/>
public partial struct POWER_SESSION_RIT_STATE
{
    /// <include file='POWER_SESSION_RIT_STATE.xml' path='doc/member[@name="POWER_SESSION_RIT_STATE.Active"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Active;
    /// <include file='POWER_SESSION_RIT_STATE.xml' path='doc/member[@name="POWER_SESSION_RIT_STATE.LastInputTime"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong LastInputTime;
}