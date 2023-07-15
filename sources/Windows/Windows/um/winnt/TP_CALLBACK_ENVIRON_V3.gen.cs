// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3"]/*'/>
public unsafe partial struct TP_CALLBACK_ENVIRON_V3
{
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Version"]/*'/>
    [NativeTypeName("TP_VERSION")]
    public uint Version;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Pool"]/*'/>
    public PTP_POOL Pool;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CleanupGroup"]/*'/>
    public PTP_CLEANUP_GROUP CleanupGroup;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CleanupGroupCancelCallback"]/*'/>
    [NativeTypeName("PTP_CLEANUP_GROUP_CANCEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, void> CleanupGroupCancelCallback;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.RaceDll"]/*'/>
    [NativeTypeName("PVOID")]
    public void* RaceDll;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.ActivationContext"]/*'/>
    [NativeTypeName("struct _ACTIVATION_CONTEXT *")]
    public IntPtr ActivationContext;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.FinalizationCallback"]/*'/>
    [NativeTypeName("PTP_SIMPLE_CALLBACK")]
    public delegate* unmanaged<PTP_CALLBACK_INSTANCE, void*, void> FinalizationCallback;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.u"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L24226_C5")]
    public _u_e__Union u;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.CallbackPriority"]/*'/>
    public TP_CALLBACK_PRIORITY CallbackPriority;
    /// <include file='TP_CALLBACK_ENVIRON_V3.xml' path='doc/member[@name="TP_CALLBACK_ENVIRON_V3.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Flags"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.s"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L24228_C9")]
        public _s_e__Struct s;
        /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct"]/*'/>
        public partial struct _s_e__Struct
        {
            public uint _bitfield;
            /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.LongFunction"]/*'/>
            [NativeTypeName("DWORD : 1")]
            public uint LongFunction
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.Persistent"]/*'/>
            [NativeTypeName("DWORD : 1")]
            public uint Persistent
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_s_e__Struct.xml' path='doc/member[@name="_s_e__Struct.Private"]/*'/>
            [NativeTypeName("DWORD : 30")]
            public uint Private
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 2) & 0x3FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                }
            }
        }
    }
}