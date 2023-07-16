// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACL_REVISION_INFORMATION.xml' path='doc/member[@name="ACL_REVISION_INFORMATION"]/*'/>
public partial struct ACL_REVISION_INFORMATION
{
    /// <include file='ACL_REVISION_INFORMATION.xml' path='doc/member[@name="ACL_REVISION_INFORMATION.AclRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AclRevision;
}