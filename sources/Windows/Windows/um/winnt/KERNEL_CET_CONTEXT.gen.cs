// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT"]/*'/>
public unsafe partial struct KERNEL_CET_CONTEXT
{
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Ssp"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Ssp;
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Rip"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Rip;
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.SegCs"]/*'/>
    [NativeTypeName("WORD")]
    public ushort SegCs;
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L2715_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='KERNEL_CET_CONTEXT.xml' path='doc/member[@name="KERNEL_CET_CONTEXT.Fill"]/*'/>
    [NativeTypeName("WORD[2]")]
    public fixed ushort Fill[2];
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AllFlags"]/*'/>
    [UnscopedRef]
    public ref ushort AllFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AllFlags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UseWrss"]/*'/>
    public ushort UseWrss
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.UseWrss;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.UseWrss = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PopShadowStackOne"]/*'/>
    public ushort PopShadowStackOne
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.PopShadowStackOne;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.PopShadowStackOne = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Unused"]/*'/>
    public ushort Unused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Unused;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Unused = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AllFlags"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort AllFlags;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L2717_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public ushort _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.UseWrss"]/*'/>
            [NativeTypeName("WORD : 1")]
            public ushort UseWrss
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (ushort)(_bitfield & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PopShadowStackOne"]/*'/>
            [NativeTypeName("WORD : 1")]
            public ushort PopShadowStackOne
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (ushort)((_bitfield >> 1) & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Unused"]/*'/>
            [NativeTypeName("WORD : 14")]
            public ushort Unused
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (ushort)((_bitfield >> 2) & 0x3FFFu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x3FFFu << 2)) | ((value & 0x3FFFu) << 2));
                }
            }
        }
    }
}