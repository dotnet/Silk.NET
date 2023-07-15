// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct EXP_SZ_LINK
{
    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.szTarget"]/*'/>
    [NativeTypeName("CHAR[260]")]
    public fixed sbyte szTarget[260];
    /// <include file='EXP_SZ_LINK.xml' path='doc/member[@name="EXP_SZ_LINK.swzTarget"]/*'/>
    [NativeTypeName("WCHAR[260]")]
    public fixed ushort swzTarget[260];
}