// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_PLACEHOLDER_INFO
{
    public PRJ_FILE_BASIC_INFO FileBasicInfo;

    [NativeTypeName("__AnonymousRecord_projectedfslib_L212_C5")]
    public _EaInformation_e__Struct EaInformation;

    [NativeTypeName("__AnonymousRecord_projectedfslib_L218_C5")]
    public _SecurityInformation_e__Struct SecurityInformation;

    [NativeTypeName("__AnonymousRecord_projectedfslib_L224_C5")]
    public _StreamsInformation_e__Struct StreamsInformation;
    public PRJ_PLACEHOLDER_VERSION_INFO VersionInfo;

    [NativeTypeName("UINT8[1]")]
    public _VariableData_e__FixedBuffer VariableData;

    public partial struct _EaInformation_e__Struct
    {
        [NativeTypeName("UINT32")]
        public uint EaBufferSize;

        [NativeTypeName("UINT32")]
        public uint OffsetToFirstEa;
    }

    public partial struct _SecurityInformation_e__Struct
    {
        [NativeTypeName("UINT32")]
        public uint SecurityBufferSize;

        [NativeTypeName("UINT32")]
        public uint OffsetToSecurityDescriptor;
    }

    public partial struct _StreamsInformation_e__Struct
    {
        [NativeTypeName("UINT32")]
        public uint StreamsInfoBufferSize;

        [NativeTypeName("UINT32")]
        public uint OffsetToFirstStreamInfo;
    }

    public partial struct _VariableData_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
