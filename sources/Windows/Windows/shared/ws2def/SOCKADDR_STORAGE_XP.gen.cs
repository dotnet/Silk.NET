// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SOCKADDR_STORAGE_XP.xml' path='doc/member[@name="SOCKADDR_STORAGE_XP"]/*'/>
public unsafe partial struct SOCKADDR_STORAGE_XP
{
    /// <include file='SOCKADDR_STORAGE_XP.xml' path='doc/member[@name="SOCKADDR_STORAGE_XP.ss_family"]/*'/>
    public short ss_family;
    /// <include file='SOCKADDR_STORAGE_XP.xml' path='doc/member[@name="SOCKADDR_STORAGE_XP.__ss_pad1"]/*'/>
    [NativeTypeName("CHAR[6]")]
    public fixed sbyte __ss_pad1[6];
    /// <include file='SOCKADDR_STORAGE_XP.xml' path='doc/member[@name="SOCKADDR_STORAGE_XP.__ss_align"]/*'/>
    [NativeTypeName("long long")]
    public long __ss_align;
    /// <include file='SOCKADDR_STORAGE_XP.xml' path='doc/member[@name="SOCKADDR_STORAGE_XP.__ss_pad2"]/*'/>
    [NativeTypeName("CHAR[112]")]
    public fixed sbyte __ss_pad2[112];
}