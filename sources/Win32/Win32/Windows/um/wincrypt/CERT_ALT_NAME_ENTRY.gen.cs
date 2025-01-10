// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_ALT_NAME_ENTRY
{
    [NativeTypeName("DWORD")]
    public uint dwAltNameChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L4000_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CERT_OTHER_NAME* pOtherName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pOtherName; }
    }

    [UnscopedRef]
    public ref ushort* pwszRfc822Name
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszRfc822Name; }
    }

    [UnscopedRef]
    public ref ushort* pwszDNSName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszDNSName; }
    }

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB DirectoryName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.DirectoryName; }
    }

    [UnscopedRef]
    public ref ushort* pwszURL
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pwszURL; }
    }

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB IPAddress
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.IPAddress; }
    }

    [UnscopedRef]
    public ref sbyte* pszRegisteredID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pszRegisteredID; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCERT_OTHER_NAME")]
        public CERT_OTHER_NAME* pOtherName;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszRfc822Name;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszDNSName;

        [FieldOffset(0)]
        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB DirectoryName;

        [FieldOffset(0)]
        [NativeTypeName("LPWSTR")]
        public ushort* pwszURL;

        [FieldOffset(0)]
        public CRYPT_DATA_BLOB IPAddress;

        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszRegisteredID;
    }
}
