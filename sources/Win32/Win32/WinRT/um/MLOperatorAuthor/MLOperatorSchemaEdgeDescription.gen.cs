// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public unsafe partial struct MLOperatorSchemaEdgeDescription
{
    public MLOperatorParameterOptions options;
    public MLOperatorSchemaEdgeTypeFormat typeFormat;

    [NativeTypeName("__AnonymousRecord_MLOperatorAuthor_L427_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref void* reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.reserved; }
    }

    [UnscopedRef]
    public ref sbyte* typeLabel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.typeLabel; }
    }

    [UnscopedRef]
    public ref MLOperatorEdgeDescription edgeDescription
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.edgeDescription; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* reserved;

        [FieldOffset(0)]
        [NativeTypeName("const char *")]
        public sbyte* typeLabel;

        [FieldOffset(0)]
        public MLOperatorEdgeDescription edgeDescription;
    }
}
