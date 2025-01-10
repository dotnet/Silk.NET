// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SPC_LINK
{
    [NativeTypeName("DWORD")]
    public uint dwLinkChoice;

    [NativeTypeName("__AnonymousRecord_WinTrust_L1335_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref ushort* pwszUrl
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszUrl; }
    }

    [UnscopedRef]
    public ref SPC_SERIALIZED_OBJECT Moniker
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Moniker; }
    }

    [UnscopedRef]
    public ref ushort* pwszFile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszFile; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszUrl;

        [FieldOffset(0)]
        public SPC_SERIALIZED_OBJECT Moniker;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszFile;
    }
}
