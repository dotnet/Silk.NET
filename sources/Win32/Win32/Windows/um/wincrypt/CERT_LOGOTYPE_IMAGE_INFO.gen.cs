// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_LOGOTYPE_IMAGE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwLogotypeImageInfoChoice;

    [NativeTypeName("DWORD")]
    public uint dwFileSize;

    [NativeTypeName("DWORD")]
    public uint dwXSize;

    [NativeTypeName("DWORD")]
    public uint dwYSize;

    [NativeTypeName("DWORD")]
    public uint dwLogotypeImageResolutionChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5499_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszLanguage;

    [UnscopedRef]
    public ref uint dwNumBits
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwNumBits; }
    }

    [UnscopedRef]
    public ref uint dwTableSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwTableSize; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwNumBits;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwTableSize;
    }
}
