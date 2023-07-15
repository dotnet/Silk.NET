// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='PEB.xml' path='doc/member[@name="PEB"]/*'/>
public unsafe partial struct PEB
{
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved1"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved1[2];
    /// <include file='PEB.xml' path='doc/member[@name="PEB.BeingDebugged"]/*'/>
    public byte BeingDebugged;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved2"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Reserved2[1];
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved3"]/*'/>
    [NativeTypeName("PVOID[2]")]
    public _Reserved3_e__FixedBuffer Reserved3;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Ldr"]/*'/>
    [NativeTypeName("PPEB_LDR_DATA")]
    public PEB_LDR_DATA* Ldr;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.ProcessParameters"]/*'/>
    [NativeTypeName("PRTL_USER_PROCESS_PARAMETERS")]
    public RTL_USER_PROCESS_PARAMETERS* ProcessParameters;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved4"]/*'/>
    [NativeTypeName("PVOID[3]")]
    public _Reserved4_e__FixedBuffer Reserved4;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.AtlThunkSListPtr"]/*'/>
    [NativeTypeName("PVOID")]
    public void* AtlThunkSListPtr;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved5"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved5;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved6"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved6;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved7"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Reserved7;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved8"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Reserved8;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.AtlThunkSListPtr32"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AtlThunkSListPtr32;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved9"]/*'/>
    [NativeTypeName("PVOID[45]")]
    public _Reserved9_e__FixedBuffer Reserved9;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved10"]/*'/>
    [NativeTypeName("BYTE[96]")]
    public fixed byte Reserved10[96];
    /// <include file='PEB.xml' path='doc/member[@name="PEB.PostProcessInitRoutine"]/*'/>
    [NativeTypeName("PPS_POST_PROCESS_INIT_ROUTINE")]
    public delegate* unmanaged<void> PostProcessInitRoutine;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved11"]/*'/>
    [NativeTypeName("BYTE[128]")]
    public fixed byte Reserved11[128];
    /// <include file='PEB.xml' path='doc/member[@name="PEB.Reserved12"]/*'/>
    [NativeTypeName("PVOID[1]")]
    public _Reserved12_e__FixedBuffer Reserved12;
    /// <include file='PEB.xml' path='doc/member[@name="PEB.SessionId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SessionId;
    /// <include file='_Reserved3_e__FixedBuffer.xml' path='doc/member[@name="_Reserved3_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved3_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved4_e__FixedBuffer.xml' path='doc/member[@name="_Reserved4_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved4_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved9_e__FixedBuffer.xml' path='doc/member[@name="_Reserved9_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved9_e__FixedBuffer
    {
        public void* e0;
        public void* e1;
        public void* e2;
        public void* e3;
        public void* e4;
        public void* e5;
        public void* e6;
        public void* e7;
        public void* e8;
        public void* e9;
        public void* e10;
        public void* e11;
        public void* e12;
        public void* e13;
        public void* e14;
        public void* e15;
        public void* e16;
        public void* e17;
        public void* e18;
        public void* e19;
        public void* e20;
        public void* e21;
        public void* e22;
        public void* e23;
        public void* e24;
        public void* e25;
        public void* e26;
        public void* e27;
        public void* e28;
        public void* e29;
        public void* e30;
        public void* e31;
        public void* e32;
        public void* e33;
        public void* e34;
        public void* e35;
        public void* e36;
        public void* e37;
        public void* e38;
        public void* e39;
        public void* e40;
        public void* e41;
        public void* e42;
        public void* e43;
        public void* e44;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }

    /// <include file='_Reserved12_e__FixedBuffer.xml' path='doc/member[@name="_Reserved12_e__FixedBuffer"]/*'/>
    public unsafe partial struct _Reserved12_e__FixedBuffer
    {
        public void* e0;
        public ref void* this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (void** pThis = &e0)
                {
                    return ref pThis[index];
                }
            }
        }
    }
}