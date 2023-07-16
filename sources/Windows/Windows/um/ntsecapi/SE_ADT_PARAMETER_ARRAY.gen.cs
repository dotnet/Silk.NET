// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY"]/*'/>
public partial struct SE_ADT_PARAMETER_ARRAY
{
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.CategoryId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint CategoryId;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.AuditId"]/*'/>
    [NativeTypeName("ULONG")]
    public uint AuditId;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.ParameterCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ParameterCount;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.Length"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Length;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.FlatSubCategoryId"]/*'/>
    public ushort FlatSubCategoryId;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.Type"]/*'/>
    public ushort Type;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='SE_ADT_PARAMETER_ARRAY.xml' path='doc/member[@name="SE_ADT_PARAMETER_ARRAY.Parameters"]/*'/>
    [NativeTypeName("SE_ADT_PARAMETER_ARRAY_ENTRY[32]")]
    public _Parameters_e__FixedBuffer Parameters;
    /// <include file='_Parameters_e__FixedBuffer.xml' path='doc/member[@name="_Parameters_e__FixedBuffer"]/*'/>
    public partial struct _Parameters_e__FixedBuffer
    {
        public SE_ADT_PARAMETER_ARRAY_ENTRY e0;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e1;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e2;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e3;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e4;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e5;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e6;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e7;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e8;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e9;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e10;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e11;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e12;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e13;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e14;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e15;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e16;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e17;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e18;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e19;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e20;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e21;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e22;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e23;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e24;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e25;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e26;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e27;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e28;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e29;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e30;
        public SE_ADT_PARAMETER_ARRAY_ENTRY e31;
        [UnscopedRef]
        public ref SE_ADT_PARAMETER_ARRAY_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<SE_ADT_PARAMETER_ARRAY_ENTRY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
    }
}