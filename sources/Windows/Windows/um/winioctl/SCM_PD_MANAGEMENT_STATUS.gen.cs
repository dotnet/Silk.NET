// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS"]/*' />
public partial struct SCM_PD_MANAGEMENT_STATUS
{
    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.Health"]/*' />
    public SCM_PD_HEALTH_STATUS Health;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.NumberOfOperationalStatus"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfOperationalStatus;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.NumberOfAdditionalReasons"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfAdditionalReasons;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.OperationalStatus"]/*' />
    [NativeTypeName("SCM_PD_OPERATIONAL_STATUS[16]")]
    public _OperationalStatus_e__FixedBuffer OperationalStatus;

    /// <include file='SCM_PD_MANAGEMENT_STATUS.xml' path='doc/member[@name="SCM_PD_MANAGEMENT_STATUS.AdditionalReasons"]/*' />
    [NativeTypeName("SCM_PD_OPERATIONAL_STATUS_REASON[1]")]
    public _AdditionalReasons_e__FixedBuffer AdditionalReasons;

    /// <include file='_OperationalStatus_e__FixedBuffer.xml' path='doc/member[@name="_OperationalStatus_e__FixedBuffer"]/*' />
    public partial struct _OperationalStatus_e__FixedBuffer
    {
        public SCM_PD_OPERATIONAL_STATUS e0;
        public SCM_PD_OPERATIONAL_STATUS e1;
        public SCM_PD_OPERATIONAL_STATUS e2;
        public SCM_PD_OPERATIONAL_STATUS e3;
        public SCM_PD_OPERATIONAL_STATUS e4;
        public SCM_PD_OPERATIONAL_STATUS e5;
        public SCM_PD_OPERATIONAL_STATUS e6;
        public SCM_PD_OPERATIONAL_STATUS e7;
        public SCM_PD_OPERATIONAL_STATUS e8;
        public SCM_PD_OPERATIONAL_STATUS e9;
        public SCM_PD_OPERATIONAL_STATUS e10;
        public SCM_PD_OPERATIONAL_STATUS e11;
        public SCM_PD_OPERATIONAL_STATUS e12;
        public SCM_PD_OPERATIONAL_STATUS e13;
        public SCM_PD_OPERATIONAL_STATUS e14;
        public SCM_PD_OPERATIONAL_STATUS e15;

        [UnscopedRef]
        public ref SCM_PD_OPERATIONAL_STATUS this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_PD_OPERATIONAL_STATUS> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }

    /// <include file='_AdditionalReasons_e__FixedBuffer.xml' path='doc/member[@name="_AdditionalReasons_e__FixedBuffer"]/*' />
    public partial struct _AdditionalReasons_e__FixedBuffer
    {
        public SCM_PD_OPERATIONAL_STATUS_REASON e0;

        [UnscopedRef]
        public ref SCM_PD_OPERATIONAL_STATUS_REASON this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SCM_PD_OPERATIONAL_STATUS_REASON> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
