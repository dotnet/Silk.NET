// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='ENCLAVE_CREATE_INFO_VBS.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS"]/*' />
[SupportedOSPlatform("windows10.0.16299.0")]
public unsafe partial struct ENCLAVE_CREATE_INFO_VBS
{
    /// <include file='ENCLAVE_CREATE_INFO_VBS.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='ENCLAVE_CREATE_INFO_VBS.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_VBS.OwnerID"]/*' />
    [NativeTypeName("BYTE[32]")]
    public fixed byte OwnerID[32];
}
