// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_DEVICE_NUMBERS.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBERS"]/*'/>
public partial struct STORAGE_DEVICE_NUMBERS
{
    /// <include file='STORAGE_DEVICE_NUMBERS.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBERS.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_NUMBERS.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBERS.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_NUMBERS.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBERS.NumberOfDevices"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfDevices;
    /// <include file='STORAGE_DEVICE_NUMBERS.xml' path='doc/member[@name="STORAGE_DEVICE_NUMBERS.Devices"]/*'/>
    [NativeTypeName("STORAGE_DEVICE_NUMBER[1]")]
    public _Devices_e__FixedBuffer Devices;
    /// <include file='_Devices_e__FixedBuffer.xml' path='doc/member[@name="_Devices_e__FixedBuffer"]/*'/>
    public partial struct _Devices_e__FixedBuffer
    {
        public STORAGE_DEVICE_NUMBER e0;
        [UnscopedRef]
        public ref STORAGE_DEVICE_NUMBER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_DEVICE_NUMBER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}