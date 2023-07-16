// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP"]/*'/>
public unsafe partial struct CACHE_RELATIONSHIP
{
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.Level"]/*'/>
    public byte Level;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.Associativity"]/*'/>
    public byte Associativity;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.LineSize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort LineSize;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.CacheSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CacheSize;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.Type"]/*'/>
    public PROCESSOR_CACHE_TYPE Type;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.Reserved"]/*'/>
    [NativeTypeName("BYTE[18]")]
    public fixed byte Reserved[18];
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.GroupCount"]/*'/>
    [NativeTypeName("WORD")]
    public ushort GroupCount;
    /// <include file='CACHE_RELATIONSHIP.xml' path='doc/member[@name="CACHE_RELATIONSHIP.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L13524_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GroupMask"]/*'/>
    [UnscopedRef]
    public ref GROUP_AFFINITY GroupMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.GroupMask;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GroupMask"]/*'/>
        [FieldOffset(0)]
        public GROUP_AFFINITY GroupMask;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.GroupMasks"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("GROUP_AFFINITY[1]")]
        public _GroupMasks_e__FixedBuffer GroupMasks;
        /// <include file='_GroupMasks_e__FixedBuffer.xml' path='doc/member[@name="_GroupMasks_e__FixedBuffer"]/*'/>
        public partial struct _GroupMasks_e__FixedBuffer
        {
            public GROUP_AFFINITY e0;
            [UnscopedRef]
            public ref GROUP_AFFINITY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            [UnscopedRef]
            public Span<GROUP_AFFINITY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}