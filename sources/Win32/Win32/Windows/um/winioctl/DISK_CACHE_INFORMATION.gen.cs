// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISK_CACHE_INFORMATION
{
    [NativeTypeName("BOOLEAN")]
    public byte ParametersSavable;

    [NativeTypeName("BOOLEAN")]
    public byte ReadCacheEnabled;

    [NativeTypeName("BOOLEAN")]
    public byte WriteCacheEnabled;
    public DISK_CACHE_RETENTION_PRIORITY ReadRetentionPriority;
    public DISK_CACHE_RETENTION_PRIORITY WriteRetentionPriority;

    [NativeTypeName("WORD")]
    public ushort DisablePrefetchTransferLength;

    [NativeTypeName("BOOLEAN")]
    public byte PrefetchScalar;

    [NativeTypeName("__AnonymousRecord_winioctl_L9589_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._ScalarPrefetch_e__Struct ScalarPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ScalarPrefetch; }
    }

    [UnscopedRef]
    public ref _Anonymous_e__Union._BlockPrefetch_e__Struct BlockPrefetch
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.BlockPrefetch; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9590_C9")]
        public _ScalarPrefetch_e__Struct ScalarPrefetch;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L9602_C9")]
        public _BlockPrefetch_e__Struct BlockPrefetch;

        public partial struct _ScalarPrefetch_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Minimum;

            [NativeTypeName("WORD")]
            public ushort Maximum;

            [NativeTypeName("WORD")]
            public ushort MaximumBlocks;
        }

        public partial struct _BlockPrefetch_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort Minimum;

            [NativeTypeName("WORD")]
            public ushort Maximum;
        }
    }
}
