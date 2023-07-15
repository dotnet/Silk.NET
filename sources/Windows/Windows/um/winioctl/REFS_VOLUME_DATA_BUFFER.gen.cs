// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER"]/*'/>
public partial struct REFS_VOLUME_DATA_BUFFER
{
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.ByteCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ByteCount;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.MajorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MajorVersion;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.MinorVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MinorVersion;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.BytesPerPhysicalSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerPhysicalSector;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.VolumeSerialNumber"]/*'/>
    public LARGE_INTEGER VolumeSerialNumber;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.NumberSectors"]/*'/>
    public LARGE_INTEGER NumberSectors;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.TotalClusters"]/*'/>
    public LARGE_INTEGER TotalClusters;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.FreeClusters"]/*'/>
    public LARGE_INTEGER FreeClusters;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.TotalReserved"]/*'/>
    public LARGE_INTEGER TotalReserved;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.BytesPerSector"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerSector;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.BytesPerCluster"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BytesPerCluster;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.MaximumSizeOfResidentFile"]/*'/>
    public LARGE_INTEGER MaximumSizeOfResidentFile;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.FastTierDataFillRatio"]/*'/>
    [NativeTypeName("WORD")]
    public ushort FastTierDataFillRatio;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.SlowTierDataFillRatio"]/*'/>
    [NativeTypeName("WORD")]
    public ushort SlowTierDataFillRatio;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.DestagesFastTierToSlowTierRate"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DestagesFastTierToSlowTierRate;
    /// <include file='REFS_VOLUME_DATA_BUFFER.xml' path='doc/member[@name="REFS_VOLUME_DATA_BUFFER.Reserved"]/*'/>
    [NativeTypeName("LARGE_INTEGER[9]")]
    public _Reserved_e__FixedBuffer Reserved;
    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*'/>
    public partial struct _Reserved_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
        public LARGE_INTEGER e1;
        public LARGE_INTEGER e2;
        public LARGE_INTEGER e3;
        public LARGE_INTEGER e4;
        public LARGE_INTEGER e5;
        public LARGE_INTEGER e6;
        public LARGE_INTEGER e7;
        public LARGE_INTEGER e8;
        [UnscopedRef]
        public ref LARGE_INTEGER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LARGE_INTEGER> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 9);
    }
}