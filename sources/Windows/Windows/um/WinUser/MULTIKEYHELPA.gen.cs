// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MULTIKEYHELPA.xml' path='doc/member[@name="MULTIKEYHELPA"]/*'/>
public unsafe partial struct MULTIKEYHELPA
{
    /// <include file='MULTIKEYHELPA.xml' path='doc/member[@name="MULTIKEYHELPA.mkSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint mkSize;
    /// <include file='MULTIKEYHELPA.xml' path='doc/member[@name="MULTIKEYHELPA.mkKeylist"]/*'/>
    [NativeTypeName("CHAR")]
    public sbyte mkKeylist;
    /// <include file='MULTIKEYHELPA.xml' path='doc/member[@name="MULTIKEYHELPA.szKeyphrase"]/*'/>
    [NativeTypeName("CHAR[1]")]
    public fixed sbyte szKeyphrase[1];
}