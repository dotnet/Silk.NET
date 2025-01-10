// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WINTRUST_DETACHED_SIG_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwUnionChoice;

    [NativeTypeName("__AnonymousRecord_WinTrust_L268_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref WINTRUST_DETACHED_SIG_FILE_HANDLES* pDetachedSigHandles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pDetachedSigHandles; }
    }

    [UnscopedRef]
    public ref WINTRUST_DETACHED_SIG_BLOBS* pDetachedSigBlobs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pDetachedSigBlobs; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_DETACHED_SIG_HANDLES_ *")]
        public WINTRUST_DETACHED_SIG_FILE_HANDLES* pDetachedSigHandles;

        [FieldOffset(0)]
        [NativeTypeName("struct WINTRUST_DETACHED_SIG_BLOBS_ *")]
        public WINTRUST_DETACHED_SIG_BLOBS* pDetachedSigBlobs;
    }
}
