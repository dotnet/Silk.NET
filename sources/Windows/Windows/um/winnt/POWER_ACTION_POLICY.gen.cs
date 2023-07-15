// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='POWER_ACTION_POLICY.xml' path='doc/member[@name="POWER_ACTION_POLICY"]/*'/>
public partial struct POWER_ACTION_POLICY
{
    /// <include file='POWER_ACTION_POLICY.xml' path='doc/member[@name="POWER_ACTION_POLICY.Action"]/*'/>
    public POWER_ACTION Action;
    /// <include file='POWER_ACTION_POLICY.xml' path='doc/member[@name="POWER_ACTION_POLICY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='POWER_ACTION_POLICY.xml' path='doc/member[@name="POWER_ACTION_POLICY.EventCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EventCode;
}