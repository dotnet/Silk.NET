// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct STORAGE_OFFLOAD_TOKEN
{
    [NativeTypeName("BYTE[4]")]
    public _TokenType_e__FixedBuffer TokenType;

    [NativeTypeName("BYTE[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    [NativeTypeName("BYTE[2]")]
    public _TokenIdLength_e__FixedBuffer TokenIdLength;

    [NativeTypeName("__AnonymousRecord_winioctl_L3588_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref _Anonymous_e__Union._StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.StorageOffloadZeroDataToken; }
    }

    [UnscopedRef]
    public Span<byte> Token
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Token; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L3589_C9")]
        public _StorageOffloadZeroDataToken_e__Struct StorageOffloadZeroDataToken;

        [FieldOffset(0)]
        [NativeTypeName("BYTE[504]")]
        public _Token_e__FixedBuffer Token;

        public partial struct _StorageOffloadZeroDataToken_e__Struct
        {
            [NativeTypeName("BYTE[504]")]
            public _Reserved2_e__FixedBuffer Reserved2;

            [InlineArray(504)]
            public partial struct _Reserved2_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [InlineArray(504)]
        public partial struct _Token_e__FixedBuffer
        {
            public byte e0;
        }
    }

    [InlineArray(4)]
    public partial struct _TokenType_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _TokenIdLength_e__FixedBuffer
    {
        public byte e0;
    }
}
