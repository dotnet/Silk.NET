// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CERT_ID
{
    [NativeTypeName("DWORD")]
    public uint dwIdChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L6708_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.IssuerSerialNumber; }
    }

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB KeyId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.KeyId; }
    }

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB HashId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HashId; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber;

        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB KeyId;

        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB HashId;
    }
}
