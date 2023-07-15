// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX"]/*'/>
public partial struct PPM_IDLE_ACCOUNTING_EX
{
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.StateCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StateCount;
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.TotalTransitions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalTransitions;
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.ResetCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ResetCount;
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.AbortCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AbortCount;
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.StartTime"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong StartTime;
    /// <include file='PPM_IDLE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_ACCOUNTING_EX.State"]/*'/>
    [NativeTypeName("PPM_IDLE_STATE_ACCOUNTING_EX[1]")]
    public _State_e__FixedBuffer State;
    /// <include file='_State_e__FixedBuffer.xml' path='doc/member[@name="_State_e__FixedBuffer"]/*'/>
    public partial struct _State_e__FixedBuffer
    {
        public PPM_IDLE_STATE_ACCOUNTING_EX e0;
        [UnscopedRef]
        public ref PPM_IDLE_STATE_ACCOUNTING_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_IDLE_STATE_ACCOUNTING_EX> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}