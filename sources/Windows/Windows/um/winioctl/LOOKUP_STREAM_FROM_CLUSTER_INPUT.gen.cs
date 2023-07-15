// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='LOOKUP_STREAM_FROM_CLUSTER_INPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_INPUT"]/*'/>
public partial struct LOOKUP_STREAM_FROM_CLUSTER_INPUT
{
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_INPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_INPUT.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_INPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_INPUT.NumberOfClusters"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfClusters;
    /// <include file='LOOKUP_STREAM_FROM_CLUSTER_INPUT.xml' path='doc/member[@name="LOOKUP_STREAM_FROM_CLUSTER_INPUT.Cluster"]/*'/>
    [NativeTypeName("LARGE_INTEGER[1]")]
    public _Cluster_e__FixedBuffer Cluster;
    /// <include file='_Cluster_e__FixedBuffer.xml' path='doc/member[@name="_Cluster_e__FixedBuffer"]/*'/>
    public partial struct _Cluster_e__FixedBuffer
    {
        public LARGE_INTEGER e0;
        [UnscopedRef]
        public ref LARGE_INTEGER this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LARGE_INTEGER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}