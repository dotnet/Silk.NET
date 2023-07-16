// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX"]/*'/>
public unsafe partial struct PPM_WMI_IDLE_STATES_EX
{
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.Type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Type;
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.Count"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Count;
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.TargetState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TargetState;
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.OldState"]/*'/>
    [NativeTypeName("DWORD")]
    public uint OldState;
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.TargetProcessors"]/*'/>
    [NativeTypeName("PVOID")]
    public void* TargetProcessors;
    /// <include file='PPM_WMI_IDLE_STATES_EX.xml' path='doc/member[@name="PPM_WMI_IDLE_STATES_EX.State"]/*'/>
    [NativeTypeName("PPM_WMI_IDLE_STATE[1]")]
    public _State_e__FixedBuffer State;
    /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*'/>
    public partial struct _State_e__FixedBuffer
    {
        public PPM_WMI_IDLE_STATE e0;
        [UnscopedRef]
        public ref PPM_WMI_IDLE_STATE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_WMI_IDLE_STATE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}