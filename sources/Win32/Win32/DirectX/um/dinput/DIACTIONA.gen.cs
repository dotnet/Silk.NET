// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public unsafe partial struct DIACTIONA
{
    [NativeTypeName("UINT_PTR")]
    public nuint uAppData;

    [NativeTypeName("DWORD")]
    public uint dwSemantic;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("__AnonymousRecord_dinput_L660_C17")]
    public _Anonymous_e__Union Anonymous;
    public Guid guidInstance;

    [NativeTypeName("DWORD")]
    public uint dwObjID;

    [NativeTypeName("DWORD")]
    public uint dwHow;

    [UnscopedRef]
    public ref sbyte* lptszActionName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.lptszActionName; }
    }

    [UnscopedRef]
    public ref uint uResIdString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.uResIdString; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* lptszActionName;

        [FieldOffset(0)]
        public uint uResIdString;
    }
}
