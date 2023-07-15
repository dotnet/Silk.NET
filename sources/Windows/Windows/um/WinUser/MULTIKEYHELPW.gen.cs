// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW"]/*'/>
public unsafe partial struct MULTIKEYHELPW
{
    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.mkSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mkSize;
    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.mkKeylist"]/*'/>
    [NativeTypeName("WCHAR")]
    public ushort mkKeylist;
    /// <include file='MULTIKEYHELPW.xml' path='doc/member[@name="MULTIKEYHELPW.szKeyphrase"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort szKeyphrase[1];
}