// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_BIOMETRIC_DATA
{
    [NativeTypeName("DWORD")]
    public uint dwTypeOfBiometricDataChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5596_C5")]
    public _Anonymous_e__Union Anonymous;
    public CERT_HASHED_URL HashedUrl;

    [UnscopedRef]
    public ref uint dwPredefined
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwPredefined; }
    }

    [UnscopedRef]
    public ref sbyte* pszObjId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pszObjId; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwPredefined;

        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszObjId;
    }
}
