// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IP_INTERFACE_INFO.xml' path='doc/member[@name="IP_INTERFACE_INFO"]/*'/>
public partial struct IP_INTERFACE_INFO
{
    /// <include file='IP_INTERFACE_INFO.xml' path='doc/member[@name="IP_INTERFACE_INFO.NumAdapters"]/*'/>
    [NativeTypeName("LONG")]
    public int NumAdapters;
    /// <include file='IP_INTERFACE_INFO.xml' path='doc/member[@name="IP_INTERFACE_INFO.Adapter"]/*'/>
    [NativeTypeName("IP_ADAPTER_INDEX_MAP[1]")]
    public _Adapter_e__FixedBuffer Adapter;
    /// <include file='_Adapter_e__FixedBuffer.xml' path='doc/member[@name="_Adapter_e__FixedBuffer"]/*'/>
    public partial struct _Adapter_e__FixedBuffer
    {
        public IP_ADAPTER_INDEX_MAP e0;
        [UnscopedRef]
        public ref IP_ADAPTER_INDEX_MAP this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IP_ADAPTER_INDEX_MAP> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}