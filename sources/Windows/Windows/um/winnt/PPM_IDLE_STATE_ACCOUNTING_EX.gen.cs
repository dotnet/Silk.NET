// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX"]/*'/>
public partial struct PPM_IDLE_STATE_ACCOUNTING_EX
{
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.TotalTime"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong TotalTime;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTransitions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint IdleTransitions;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.FailedTransitions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FailedTransitions;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.InvalidBucketIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint InvalidBucketIndex;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MinTimeUs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinTimeUs;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.MaxTimeUs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxTimeUs;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.CancelledTransitions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CancelledTransitions;
    /// <include file='PPM_IDLE_STATE_ACCOUNTING_EX.xml' path='doc/member[@name="PPM_IDLE_STATE_ACCOUNTING_EX.IdleTimeBuckets"]/*'/>
    [NativeTypeName("PPM_IDLE_STATE_BUCKET_EX[16]")]
    public _IdleTimeBuckets_e__FixedBuffer IdleTimeBuckets;
    /// <include file='_IdleTimeBuckets_e__FixedBuffer.xml' path='doc/member[@name="_IdleTimeBuckets_e__FixedBuffer"]/*'/>
    public partial struct _IdleTimeBuckets_e__FixedBuffer
    {
        public PPM_IDLE_STATE_BUCKET_EX e0;
        public PPM_IDLE_STATE_BUCKET_EX e1;
        public PPM_IDLE_STATE_BUCKET_EX e2;
        public PPM_IDLE_STATE_BUCKET_EX e3;
        public PPM_IDLE_STATE_BUCKET_EX e4;
        public PPM_IDLE_STATE_BUCKET_EX e5;
        public PPM_IDLE_STATE_BUCKET_EX e6;
        public PPM_IDLE_STATE_BUCKET_EX e7;
        public PPM_IDLE_STATE_BUCKET_EX e8;
        public PPM_IDLE_STATE_BUCKET_EX e9;
        public PPM_IDLE_STATE_BUCKET_EX e10;
        public PPM_IDLE_STATE_BUCKET_EX e11;
        public PPM_IDLE_STATE_BUCKET_EX e12;
        public PPM_IDLE_STATE_BUCKET_EX e13;
        public PPM_IDLE_STATE_BUCKET_EX e14;
        public PPM_IDLE_STATE_BUCKET_EX e15;
        [UnscopedRef]
        public ref PPM_IDLE_STATE_BUCKET_EX this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PPM_IDLE_STATE_BUCKET_EX> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}