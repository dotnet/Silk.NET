// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT"]/*'/>
public partial struct DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT
{
    /// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.TotalNumberOfRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalNumberOfRanges;
    /// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.NumberOfRangesReturned"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfRangesReturned;
    /// <include file='DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_PHYSICAL_ADDRESSES_OUTPUT.Ranges"]/*'/>
    [NativeTypeName("DEVICE_STORAGE_ADDRESS_RANGE[1]")]
    public _Ranges_e__FixedBuffer Ranges;
    /// <include file='_Ranges_e__FixedBuffer.xml' path='doc/member[@name="_Ranges_e__FixedBuffer"]/*'/>
    public partial struct _Ranges_e__FixedBuffer
    {
        public DEVICE_STORAGE_ADDRESS_RANGE e0;
        [UnscopedRef]
        public ref DEVICE_STORAGE_ADDRESS_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DEVICE_STORAGE_ADDRESS_RANGE> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}