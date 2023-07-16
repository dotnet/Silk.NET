// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACL_SIZE_INFORMATION.xml' path='doc/member[@name="ACL_SIZE_INFORMATION"]/*'/>
public partial struct ACL_SIZE_INFORMATION
{
    /// <include file='ACL_SIZE_INFORMATION.xml' path='doc/member[@name="ACL_SIZE_INFORMATION.AceCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AceCount;
    /// <include file='ACL_SIZE_INFORMATION.xml' path='doc/member[@name="ACL_SIZE_INFORMATION.AclBytesInUse"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AclBytesInUse;
    /// <include file='ACL_SIZE_INFORMATION.xml' path='doc/member[@name="ACL_SIZE_INFORMATION.AclBytesFree"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AclBytesFree;
}