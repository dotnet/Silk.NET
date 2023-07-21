// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_DYNAMIC_RELOCATION32_V2
{
    /// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2.HeaderSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint HeaderSize;

    /// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2.FixupInfoSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint FixupInfoSize;

    /// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2.Symbol"]/*' />
    [NativeTypeName("DWORD")]
    public uint Symbol;

    /// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2.SymbolGroup"]/*' />
    [NativeTypeName("DWORD")]
    public uint SymbolGroup;

    /// <include file='IMAGE_DYNAMIC_RELOCATION32_V2.xml' path='doc/member[@name="IMAGE_DYNAMIC_RELOCATION32_V2.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
