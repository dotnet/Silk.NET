// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PROPSPEC
{
    [NativeTypeName("ULONG")]
    public uint ulKind;

    [NativeTypeName("__AnonymousRecord_propidlbase_L452_C43")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint propid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.propid; }
    }

    [UnscopedRef]
    public ref ushort* lpwstr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lpwstr; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PROPID")]
        public uint propid;

        [FieldOffset(0)]
        [NativeTypeName("LPOLESTR")]
        public ushort* lpwstr;
    }
}
