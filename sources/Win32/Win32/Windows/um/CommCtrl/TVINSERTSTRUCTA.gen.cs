// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct TVINSERTSTRUCTA
{
    public HTREEITEM hParent;
    public HTREEITEM hInsertAfter;

    [NativeTypeName("__AnonymousRecord_CommCtrl_L5001_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref TVITEMEXA itemex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.itemex; }
    }

    [UnscopedRef]
    public ref TVITEMA item
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.item; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public TVITEMEXA itemex;

        [FieldOffset(0)]
        public TVITEMA item;
    }
}
