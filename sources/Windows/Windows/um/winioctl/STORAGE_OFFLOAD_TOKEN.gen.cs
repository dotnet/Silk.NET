// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct STORAGE_OFFLOAD_TOKEN
{
    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.TokenType"]/*'/>
    [NativeTypeName("BYTE[4]")]
    public fixed byte TokenType[4];
    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.Reserved"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte Reserved[2];
    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.TokenIdLength"]/*'/>
    [NativeTypeName("BYTE[2]")]
    public fixed byte TokenIdLength[2];
    /// <include file='STORAGE_OFFLOAD_TOKEN.xml' path='doc/member[@name="STORAGE_OFFLOAD_TOKEN.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L3359_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StorageOffloadZeroDataToken"]/*'/>
    [UnscopedRef]
    public ref _Anonymous_e__Union._StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.StorageOffloadZeroDataToken;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Token"]/*'/>
    [UnscopedRef]
    public Span<byte> Token
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Token[0], 504);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.StorageOffloadZeroDataToken"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3360_C9")]
        public _StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Token"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("BYTE[504]")]
        public fixed byte Token[504];
        /// <include file='_StorageOffloadZeroDataToken_e__Struct.xml' path='doc/member[@name="_StorageOffloadZeroDataToken_e__Struct"]/*'/>
        public unsafe partial struct _StorageOffloadZeroDataToken_e__Struct
        {
            /// <include file='_StorageOffloadZeroDataToken_e__Struct.xml' path='doc/member[@name="_StorageOffloadZeroDataToken_e__Struct.Reserved2"]/*'/>
            [NativeTypeName("BYTE[504]")]
            public fixed byte Reserved2[504];
        }
    }
}