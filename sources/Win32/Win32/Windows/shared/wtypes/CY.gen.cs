// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct CY
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_wtypes_L679_C5")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("LONGLONG")]
    public long int64;

    [UnscopedRef]
    public ref uint Lo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Lo; }
    }

    [UnscopedRef]
    public ref int Hi
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Hi; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("ULONG")]
        public uint Lo;

        [NativeTypeName("LONG")]
        public int Hi;
    }
}
