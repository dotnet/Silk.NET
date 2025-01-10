// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FILE_ID_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint dwSize;
    public FILE_ID_TYPE Type;

    [NativeTypeName("__AnonymousRecord_winbase_L9419_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref LARGE_INTEGER FileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FileId; }
    }

    [UnscopedRef]
    public ref Guid ObjectId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ObjectId; }
    }

    [UnscopedRef]
    public ref FILE_ID_128 ExtendedFileId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ExtendedFileId; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public LARGE_INTEGER FileId;

        [FieldOffset(0)]
        public Guid ObjectId;

        [FieldOffset(0)]
        public FILE_ID_128 ExtendedFileId;
    }
}
