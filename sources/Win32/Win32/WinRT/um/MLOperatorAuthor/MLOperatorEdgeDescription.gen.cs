// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct MLOperatorEdgeDescription
{
    public MLOperatorEdgeType edgeType;

    [NativeTypeName("__AnonymousRecord_MLOperatorAuthor_L119_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ulong reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.reserved; }
    }

    [UnscopedRef]
    public ref MLOperatorTensorDataType tensorDataType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.tensorDataType; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("uint64_t")]
        public ulong reserved;

        [FieldOffset(0)]
        public MLOperatorTensorDataType tensorDataType;
    }
}
