// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SIGNER_SIGNATURE_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("ALG_ID")]
    public uint algidHash;

    [NativeTypeName("DWORD")]
    public uint dwAttrChoice;

    [NativeTypeName("__AnonymousRecord_mssign32_L55_C9")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* psAuthenticated;

    [NativeTypeName("PCRYPT_ATTRIBUTES")]
    public CRYPT_ATTRIBUTES* psUnauthenticated;

    [UnscopedRef]
    public ref SIGNER_ATTR_AUTHCODE* pAttrAuthcode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pAttrAuthcode; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public SIGNER_ATTR_AUTHCODE* pAttrAuthcode;
    }
}
