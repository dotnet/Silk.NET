// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CIDA.xml' path='doc/member[@name="CIDA"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct CIDA
{
    /// <include file='CIDA.xml' path='doc/member[@name="CIDA.cidl"]/*'/>
    public uint cidl;
    /// <include file='CIDA.xml' path='doc/member[@name="CIDA.aoffset"]/*'/>
    [NativeTypeName("UINT[1]")]
    public fixed uint aoffset[1];
}