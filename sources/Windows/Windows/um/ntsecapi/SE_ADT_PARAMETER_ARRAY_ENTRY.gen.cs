// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SE_ADT_PARAMETER_ARRAY_ENTRY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_ENTRY"]/*'/>
public unsafe partial struct SE_ADT_PARAMETER_ARRAY_ENTRY
{
    /// <include file='SE_ADT_PARAMETER_ARRAY_ENTRY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_ENTRY.Type"]/*'/>
    public SE_ADT_PARAMETER_TYPE Type;
    /// <include file='SE_ADT_PARAMETER_ARRAY_ENTRY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_ENTRY.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='SE_ADT_PARAMETER_ARRAY_ENTRY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_ENTRY.Data"]/*'/>
    [NativeTypeName("ULONG_PTR[2]")]
    public _Data_e__FixedBuffer Data;
    /// <include file='SE_ADT_PARAMETER_ARRAY_ENTRY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY_ENTRY.Address"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Address;
    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*'/>
    public partial struct _Data_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;
        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 2);
    }
}