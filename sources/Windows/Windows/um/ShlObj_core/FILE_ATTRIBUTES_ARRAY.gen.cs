// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct FILE_ATTRIBUTES_ARRAY
{
    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.cItems"]/*'/>
    public uint cItems;
    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.dwSumFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSumFileAttributes;
    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.dwProductFileAttributes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwProductFileAttributes;
    /// <include file='FILE_ATTRIBUTES_ARRAY.xml' path='doc/member[@name="FILE_ATTRIBUTES_ARRAY.rgdwFileAttributes"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint rgdwFileAttributes[1];
}