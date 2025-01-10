// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct ELEMDESC
{
    public TYPEDESC tdesc;

    [NativeTypeName("__AnonymousRecord_oaidl_L733_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref IDLDESC idldesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.idldesc; }
    }

    [UnscopedRef]
    public ref PARAMDESC paramdesc
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.paramdesc; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public IDLDESC idldesc;

        [FieldOffset(0)]
        public PARAMDESC paramdesc;
    }
}
