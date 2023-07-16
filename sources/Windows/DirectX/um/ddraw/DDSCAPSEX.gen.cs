// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
/// <include file='DDSCAPSEX.xml' path='doc/member[@name="DDSCAPSEX"]/*'/>
public partial struct DDSCAPSEX
{
    /// <include file='DDSCAPSEX.xml' path='doc/member[@name="DDSCAPSEX.dwCaps2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps2;
    /// <include file='DDSCAPSEX.xml' path='doc/member[@name="DDSCAPSEX.dwCaps3"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCaps3;
    /// <include file='DDSCAPSEX.xml' path='doc/member[@name="DDSCAPSEX.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_ddraw_L356_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwCaps4"]/*'/>
    [UnscopedRef]
    public ref uint dwCaps4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwCaps4;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwVolumeDepth"]/*'/>
    [UnscopedRef]
    public ref uint dwVolumeDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwVolumeDepth;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwCaps4"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwCaps4;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwVolumeDepth"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVolumeDepth;
    }
}