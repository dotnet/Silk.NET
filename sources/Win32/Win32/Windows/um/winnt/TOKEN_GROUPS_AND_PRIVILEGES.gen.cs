// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TOKEN_GROUPS_AND_PRIVILEGES
{
    [NativeTypeName("DWORD")]
    public uint SidCount;

    [NativeTypeName("DWORD")]
    public uint SidLength;

    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* Sids;

    [NativeTypeName("DWORD")]
    public uint RestrictedSidCount;

    [NativeTypeName("DWORD")]
    public uint RestrictedSidLength;

    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* RestrictedSids;

    [NativeTypeName("DWORD")]
    public uint PrivilegeCount;

    [NativeTypeName("DWORD")]
    public uint PrivilegeLength;

    [NativeTypeName("PLUID_AND_ATTRIBUTES")]
    public LUID_AND_ATTRIBUTES* Privileges;
    public LUID AuthenticationId;
}
