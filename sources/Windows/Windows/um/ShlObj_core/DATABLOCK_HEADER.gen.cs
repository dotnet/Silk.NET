// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DATABLOCK_HEADER.xml' path='doc/member[@name="DATABLOCK_HEADER"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DATABLOCK_HEADER
{
    /// <include file='DATABLOCK_HEADER.xml' path='doc/member[@name="DATABLOCK_HEADER.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='DATABLOCK_HEADER.xml' path='doc/member[@name="DATABLOCK_HEADER.dwSignature"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSignature;
}