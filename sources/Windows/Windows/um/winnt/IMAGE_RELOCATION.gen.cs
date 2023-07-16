// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 2)]
public partial struct IMAGE_RELOCATION
{
    /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19013_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.SymbolTableIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SymbolTableIndex;
    /// <include file='IMAGE_RELOCATION.xml' path='doc/member[@name="IMAGE_RELOCATION.Type"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Type;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VirtualAddress"]/*'/>
    [UnscopedRef]
    public ref uint VirtualAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VirtualAddress;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RelocCount"]/*'/>
    [UnscopedRef]
    public ref uint RelocCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.RelocCount;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit, Pack = 2)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VirtualAddress"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint VirtualAddress;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.RelocCount"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint RelocCount;
    }
}