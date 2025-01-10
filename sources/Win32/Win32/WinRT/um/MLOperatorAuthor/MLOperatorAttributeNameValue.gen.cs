// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public unsafe partial struct MLOperatorAttributeNameValue
{
    [NativeTypeName("const char *")]
    public sbyte* name;
    public MLOperatorAttributeType type;

    [NativeTypeName("uint32_t")]
    public uint valueCount;

    [NativeTypeName("__AnonymousRecord_MLOperatorAuthor_L603_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref void* reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.reserved; }
    }

    [UnscopedRef]
    public ref long* ints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ints; }
    }

    [UnscopedRef]
    public ref sbyte** strings
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.strings; }
    }

    [UnscopedRef]
    public ref float* floats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.floats; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* reserved;

        [FieldOffset(0)]
        [NativeTypeName("const int64_t *")]
        public long* ints;

        [FieldOffset(0)]
        [NativeTypeName("const char *const *")]
        public sbyte** strings;

        [FieldOffset(0)]
        [NativeTypeName("const float *")]
        public float* floats;
    }
}
