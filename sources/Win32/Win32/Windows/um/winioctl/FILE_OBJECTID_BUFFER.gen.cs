// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_OBJECTID_BUFFER
{
    [NativeTypeName("BYTE[16]")]
    public _ObjectId_e__FixedBuffer ObjectId;

    [NativeTypeName("__AnonymousRecord_winioctl_L12540_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public Span<byte> BirthVolumeId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.BirthVolumeId; }
    }

    [UnscopedRef]
    public Span<byte> BirthObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.BirthObjectId; }
    }

    [UnscopedRef]
    public Span<byte> DomainId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.Anonymous.DomainId; }
    }

    [UnscopedRef]
    public Span<byte> ExtendedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return Anonymous.ExtendedInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L12541_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("BYTE[48]")]
        public _ExtendedInfo_e__FixedBuffer ExtendedInfo;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("BYTE[16]")]
            public _BirthVolumeId_e__FixedBuffer BirthVolumeId;

            [NativeTypeName("BYTE[16]")]
            public _BirthObjectId_e__FixedBuffer BirthObjectId;

            [NativeTypeName("BYTE[16]")]
            public _DomainId_e__FixedBuffer DomainId;

            [InlineArray(16)]
            public partial struct _BirthVolumeId_e__FixedBuffer
            {
                public byte e0;
            }

            [InlineArray(16)]
            public partial struct _BirthObjectId_e__FixedBuffer
            {
                public byte e0;
            }

            [InlineArray(16)]
            public partial struct _DomainId_e__FixedBuffer
            {
                public byte e0;
            }
        }

        [InlineArray(48)]
        public partial struct _ExtendedInfo_e__FixedBuffer
        {
            public byte e0;
        }
    }

    [InlineArray(16)]
    public partial struct _ObjectId_e__FixedBuffer
    {
        public byte e0;
    }
}
