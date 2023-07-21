// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION"]/*' />
public unsafe partial struct SERVERSILO_BASIC_INFORMATION
{
    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.ServiceSessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint ServiceSessionId;

    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.State"]/*' />
    public SERVERSILO_STATE State;

    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.ExitStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint ExitStatus;

    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.IsDownlevelContainer"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IsDownlevelContainer;

    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.ApiSetSchema"]/*' />
    [NativeTypeName("PVOID")]
    public void* ApiSetSchema;

    /// <include file='SERVERSILO_BASIC_INFORMATION.xml' path='doc/member[@name="SERVERSILO_BASIC_INFORMATION.HostApiSetSchema"]/*' />
    [NativeTypeName("PVOID")]
    public void* HostApiSetSchema;
}
