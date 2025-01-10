// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct TF_LMLATTELEMENT
{
    [NativeTypeName("DWORD")]
    public uint dwFrameStart;

    [NativeTypeName("DWORD")]
    public uint dwFrameLen;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("__AnonymousRecord_ctffunc_L2394_C36")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("BSTR")]
    public ushort* bstrText;

    [UnscopedRef]
    public ref int iCost
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.iCost; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public int iCost;
    }
}
