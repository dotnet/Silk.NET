// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION"]/*'/>
public partial struct DISK_CACHE_INFORMATION
{
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ParametersSavable"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ParametersSavable;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ReadCacheEnabled"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ReadCacheEnabled;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.WriteCacheEnabled"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte WriteCacheEnabled;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.ReadRetentionPriority"]/*'/>
    public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.WriteRetentionPriority"]/*'/>
    public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.DisablePrefetchTransferLength"]/*'/>
    [NativeTypeName("WORD")]
    public ushort DisablePrefetchTransferLength;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.PrefetchScalar"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte PrefetchScalar;
    /// <include file='DISK_CACHE_INFORMATION.xml' path='doc/member[@name="DISK_CACHE_INFORMATION.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L9315_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ScalarPrefetch"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._ScalarPrefetch_e__Struct ScalarPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ScalarPrefetch;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BlockPrefetch"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._BlockPrefetch_e__Struct BlockPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.BlockPrefetch;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ScalarPrefetch"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9316_C9")]
        public _ScalarPrefetch_e__Struct ScalarPrefetch;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.BlockPrefetch"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9328_C9")]
        public _BlockPrefetch_e__Struct BlockPrefetch;
        /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct"]/*'/>
        public partial struct _ScalarPrefetch_e__Struct
        {
            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.Minimum"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Minimum;
            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.Maximum"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Maximum;
            /// <include file='_ScalarPrefetch_e__Struct.xml' path='doc/member[@name="_ScalarPrefetch_e__Struct.MaximumBlocks"]/*'/>
            [NativeTypeName("WORD")]
            public ushort MaximumBlocks;
        }

        /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct"]/*'/>
        public partial struct _BlockPrefetch_e__Struct
        {
            /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct.Minimum"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Minimum;
            /// <include file='_BlockPrefetch_e__Struct.xml' path='doc/member[@name="_BlockPrefetch_e__Struct.Maximum"]/*'/>
            [NativeTypeName("WORD")]
            public ushort Maximum;
        }
    }
}