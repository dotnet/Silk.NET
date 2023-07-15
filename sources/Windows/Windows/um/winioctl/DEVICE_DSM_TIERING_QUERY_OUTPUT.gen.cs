// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT"]/*'/>
public partial struct DEVICE_DSM_TIERING_QUERY_OUTPUT
{
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Reserved;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Alignment"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong Alignment;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.TotalNumberOfRegions"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TotalNumberOfRegions;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.NumberOfRegionsReturned"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfRegionsReturned;
    /// <include file='DEVICE_DSM_TIERING_QUERY_OUTPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_OUTPUT.Regions"]/*'/>
    [NativeTypeName("STORAGE_TIER_REGION[1]")]
    public _Regions_e__FixedBuffer Regions;
    /// <include file='_Regions_e__FixedBuffer.xml' path='doc/member[@name="_Regions_e__FixedBuffer"]/*'/>
    public partial struct _Regions_e__FixedBuffer
    {
        public STORAGE_TIER_REGION e0;
        [UnscopedRef]
        public ref STORAGE_TIER_REGION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<STORAGE_TIER_REGION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}