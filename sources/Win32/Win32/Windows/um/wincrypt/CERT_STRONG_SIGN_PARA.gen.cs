// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CERT_STRONG_SIGN_PARA
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwInfoChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L6576_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref void* pvInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pvInfo; }
    }

    [UnscopedRef]
    public ref CERT_STRONG_SIGN_SERIALIZED_INFO* pSerializedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pSerializedInfo; }
    }

    [UnscopedRef]
    public ref sbyte* pszOID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pszOID; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public void* pvInfo;

        [FieldOffset(0)]
        [NativeTypeName("PCERT_STRONG_SIGN_SERIALIZED_INFO")]
        public CERT_STRONG_SIGN_SERIALIZED_INFO* pSerializedInfo;

        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszOID;
    }
}
