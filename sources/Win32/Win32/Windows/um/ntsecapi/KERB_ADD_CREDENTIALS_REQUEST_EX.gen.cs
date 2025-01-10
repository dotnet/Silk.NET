// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct KERB_ADD_CREDENTIALS_REQUEST_EX
{
    public KERB_ADD_CREDENTIALS_REQUEST Credentials;

    [NativeTypeName("ULONG")]
    public uint PrincipalNameCount;

    [NativeTypeName("UNICODE_STRING[1]")]
    public _PrincipalNames_e__FixedBuffer PrincipalNames;

    public partial struct _PrincipalNames_e__FixedBuffer
    {
        public LSA_UNICODE_STRING e0;

        [UnscopedRef]
        public ref LSA_UNICODE_STRING this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return ref Unsafe.Add(ref e0, index); }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LSA_UNICODE_STRING> AsSpan(int length) =>
            MemoryMarshal.CreateSpan(ref e0, length);
    }
}
