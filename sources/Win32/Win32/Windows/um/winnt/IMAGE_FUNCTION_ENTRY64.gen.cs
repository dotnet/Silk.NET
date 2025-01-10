// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_FUNCTION_ENTRY64
{
    [NativeTypeName("ULONGLONG")]
    public ulong StartingAddress;

    [NativeTypeName("ULONGLONG")]
    public ulong EndingAddress;

    [NativeTypeName("__AnonymousRecord_winnt_L21508_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ulong EndOfPrologue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.EndOfPrologue; }
    }

    [UnscopedRef]
    public ref ulong UnwindInfoAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.UnwindInfoAddress; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong EndOfPrologue;

        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG")]
        public ulong UnwindInfoAddress;
    }
}
