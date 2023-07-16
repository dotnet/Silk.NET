// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR"]/*'/>
public partial struct STORAGE_DEVICE_TIERING_DESCRIPTOR
{
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.TotalNumberOfTiers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalNumberOfTiers;
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.NumberOfTiersReturned"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfTiersReturned;
    /// <include file='STORAGE_DEVICE_TIERING_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_DEVICE_TIERING_DESCRIPTOR.Tiers"]/*'/>
    [NativeTypeName("STORAGE_TIER[1]")]
    public _Tiers_e__FixedBuffer Tiers;
    /// <include file='_Tiers_e__FixedBuffer.xml' path='doc/member[@name="_Tiers_e__FixedBuffer"]/*'/>
    public partial struct _Tiers_e__FixedBuffer
    {
        public STORAGE_TIER e0;
        [UnscopedRef]
        public ref STORAGE_TIER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_TIER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}