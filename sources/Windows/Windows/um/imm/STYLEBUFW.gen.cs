// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW"]/*'/>
public unsafe partial struct STYLEBUFW
{
    /// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='STYLEBUFW.xml' path='doc/member[@name="STYLEBUFW.szDescription"]/*'/>
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort szDescription[32];
}