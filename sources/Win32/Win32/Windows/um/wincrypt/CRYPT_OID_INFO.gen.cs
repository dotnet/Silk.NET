// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_OID_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("LPCSTR")]
    public sbyte* pszOID;

    [NativeTypeName("LPCWSTR")]
    public ushort* pwszName;

    [NativeTypeName("DWORD")]
    public uint dwGroupId;

    [NativeTypeName("__AnonymousRecord_wincrypt_L6249_C5")]
    public _Anonymous_e__Union Anonymous;
    public CRYPT_DATA_BLOB ExtraInfo;

    [UnscopedRef]
    public ref uint dwValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwValue; }
    }

    [UnscopedRef]
    public ref uint Algid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Algid; }
    }

    [UnscopedRef]
    public ref uint dwLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwLength; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwValue;

        [FieldOffset(0)]
        [NativeTypeName("ALG_ID")]
        public uint Algid;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwLength;
    }
}
