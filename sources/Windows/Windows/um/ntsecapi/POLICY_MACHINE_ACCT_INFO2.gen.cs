// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='POLICY_MACHINE_ACCT_INFO2.xml' path='doc/member[@name="POLICY_MACHINE_ACCT_INFO2"]/*'/>
public unsafe partial struct POLICY_MACHINE_ACCT_INFO2
{
    /// <include file='POLICY_MACHINE_ACCT_INFO2.xml' path='doc/member[@name="POLICY_MACHINE_ACCT_INFO2.Rid"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Rid;
    /// <include file='POLICY_MACHINE_ACCT_INFO2.xml' path='doc/member[@name="POLICY_MACHINE_ACCT_INFO2.Sid"]/*'/>
    [NativeTypeName("PSID")]
    public void* Sid;
    /// <include file='POLICY_MACHINE_ACCT_INFO2.xml' path='doc/member[@name="POLICY_MACHINE_ACCT_INFO2.ObjectGuid"]/*'/>
    public Guid ObjectGuid;
}