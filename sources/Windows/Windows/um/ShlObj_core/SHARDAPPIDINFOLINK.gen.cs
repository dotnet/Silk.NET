// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SHARDAPPIDINFOLINK.xml' path='doc/member[@name="SHARDAPPIDINFOLINK"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHARDAPPIDINFOLINK
{
    /// <include file='SHARDAPPIDINFOLINK.xml' path='doc/member[@name="SHARDAPPIDINFOLINK.psl"]/*'/>
    public IShellLinkW* psl;
    /// <include file='SHARDAPPIDINFOLINK.xml' path='doc/member[@name="SHARDAPPIDINFOLINK.pszAppID"]/*'/>
    [NativeTypeName("PCWSTR")]
    public ushort* pszAppID;
}