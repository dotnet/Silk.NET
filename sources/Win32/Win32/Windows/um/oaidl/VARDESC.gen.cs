// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct VARDESC
{
    [NativeTypeName("MEMBERID")]
    public int memid;

    [NativeTypeName("LPOLESTR")]
    public ushort* lpstrSchema;

    [NativeTypeName("__AnonymousRecord_oaidl_L880_C36")]
    public _Anonymous_e__Union Anonymous;
    public ELEMDESC elemdescVar;

    [NativeTypeName("WORD")]
    public ushort wVarFlags;
    public VARKIND varkind;

    [UnscopedRef]
    public ref uint oInst
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.oInst; }
    }

    [UnscopedRef]
    public ref VARIANT* lpvarValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lpvarValue; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint oInst;

        [FieldOffset(0)]
        public VARIANT* lpvarValue;
    }
}
