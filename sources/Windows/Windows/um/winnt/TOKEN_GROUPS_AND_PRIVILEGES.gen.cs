// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES"]/*'/>
public unsafe partial struct TOKEN_GROUPS_AND_PRIVILEGES
{
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.SidCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SidCount;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.SidLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SidLength;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.Sids"]/*'/>
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* Sids;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSidCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RestrictedSidCount;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSidLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RestrictedSidLength;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.RestrictedSids"]/*'/>
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* RestrictedSids;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.PrivilegeCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PrivilegeCount;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.PrivilegeLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PrivilegeLength;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.Privileges"]/*'/>
    [NativeTypeName("PLUID_AND_ATTRIBUTES")]
    public LUID_AND_ATTRIBUTES* Privileges;
    /// <include file='TOKEN_GROUPS_AND_PRIVILEGES.xml' path='doc/member[@name="TOKEN_GROUPS_AND_PRIVILEGES.AuthenticationId"]/*'/>
    public LUID AuthenticationId;
}