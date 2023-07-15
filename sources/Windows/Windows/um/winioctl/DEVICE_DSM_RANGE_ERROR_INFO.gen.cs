// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO"]/*'/>
public partial struct DEVICE_DSM_RANGE_ERROR_INFO
{
    /// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO.TotalNumberOfRanges"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalNumberOfRanges;
    /// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO.NumberOfRangesReturned"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfRangesReturned;
    /// <include file='DEVICE_DSM_RANGE_ERROR_INFO.xml' path='doc/member[@name="DEVICE_DSM_RANGE_ERROR_INFO.Ranges"]/*'/>
    [NativeTypeName("DEVICE_STORAGE_RANGE_ATTRIBUTES[1]")]
    public _Ranges_e__FixedBuffer Ranges;
    /// <include file='_Ranges_e__FixedBuffer.xml' path='doc/member[@name="_Ranges_e__FixedBuffer"]/*'/>
    public partial struct _Ranges_e__FixedBuffer
    {
        public DEVICE_STORAGE_RANGE_ATTRIBUTES e0;
        [UnscopedRef]
        public ref DEVICE_STORAGE_RANGE_ATTRIBUTES this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DEVICE_STORAGE_RANGE_ATTRIBUTES> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}