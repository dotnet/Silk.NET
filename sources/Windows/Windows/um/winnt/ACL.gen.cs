// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACL.xml' path='doc/member[@name="ACL"]/*'/>
public partial struct ACL
{
    /// <include file='ACL.xml' path='doc/member[@name="ACL.AclRevision"]/*'/>
    public byte AclRevision;
    /// <include file='ACL.xml' path='doc/member[@name="ACL.Sbz1"]/*'/>
    public byte Sbz1;
    /// <include file='ACL.xml' path='doc/member[@name="ACL.AclSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort AclSize;
    /// <include file='ACL.xml' path='doc/member[@name="ACL.AceCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort AceCount;
    /// <include file='ACL.xml' path='doc/member[@name="ACL.Sbz2"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Sbz2;
}