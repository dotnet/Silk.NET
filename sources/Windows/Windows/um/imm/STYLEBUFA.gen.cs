// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA"]/*'/>
public unsafe partial struct STYLEBUFA
{
    /// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='STYLEBUFA.xml' path='doc/member[@name="STYLEBUFA.szDescription"]/*'/>
    [NativeTypeName("CHAR[32]")]
    public fixed sbyte szDescription[32];
}