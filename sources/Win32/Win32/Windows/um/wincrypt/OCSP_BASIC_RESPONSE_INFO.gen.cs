// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OCSP_BASIC_RESPONSE_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwResponderIdChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5749_C5")]
    public _Anonymous_e__Union Anonymous;
    public FILETIME ProducedAt;

    [NativeTypeName("DWORD")]
    public uint cResponseEntry;

    [NativeTypeName("POCSP_BASIC_RESPONSE_ENTRY")]
    public OCSP_BASIC_RESPONSE_ENTRY* rgResponseEntry;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB ByNameResponderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ByNameResponderId; }
    }

    [UnscopedRef]
    public ref CRYPT_DATA_BLOB ByKeyResponderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.ByKeyResponderId; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB ByNameResponderId;

        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB ByKeyResponderId;
    }
}
