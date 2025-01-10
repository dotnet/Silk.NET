// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TF_DA_COLOR
{
    public TF_DA_COLORTYPE type;

    [NativeTypeName("__AnonymousRecord_msctf_L10803_C36")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref int nIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.nIndex; }
    }

    [UnscopedRef]
    public ref COLORREF cr
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cr; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public int nIndex;

        [FieldOffset(0)]
        public COLORREF cr;
    }
}
