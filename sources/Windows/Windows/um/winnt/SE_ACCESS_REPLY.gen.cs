// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY"]/*'/>
public unsafe partial struct SE_ACCESS_REPLY
{
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.ResultListCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ResultListCount;
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.GrantedAccess"]/*'/>
    [NativeTypeName("PACCESS_MASK")]
    public uint* GrantedAccess;
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.AccessStatus"]/*'/>
    [NativeTypeName("PDWORD")]
    public uint* AccessStatus;
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.AccessReason"]/*'/>
    [NativeTypeName("PACCESS_REASONS")]
    public ACCESS_REASONS* AccessReason;
    /// <include file='SE_ACCESS_REPLY.xml' path='doc/member[@name="SE_ACCESS_REPLY.Privileges"]/*'/>
    [NativeTypeName("PPRIVILEGE_SET *")]
    public PRIVILEGE_SET** Privileges;
}