// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TYPEDESC
{
    [NativeTypeName("__AnonymousRecord_oaidl_L653_C36")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("VARTYPE")]
    public ushort vt;

    [UnscopedRef]
    public ref TYPEDESC* lptdesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lptdesc; }
    }

    [UnscopedRef]
    public ref ARRAYDESC* lpadesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lpadesc; }
    }

    [UnscopedRef]
    public ref uint hreftype
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hreftype; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct tagTYPEDESC *")]
        public TYPEDESC* lptdesc;

        [FieldOffset(0)]
        [NativeTypeName("struct tagARRAYDESC *")]
        public ARRAYDESC* lpadesc;

        [FieldOffset(0)]
        [NativeTypeName("HREFTYPE")]
        public uint hreftype;
    }
}
