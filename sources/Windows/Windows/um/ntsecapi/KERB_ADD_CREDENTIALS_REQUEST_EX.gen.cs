// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='KERB_ADD_CREDENTIALS_REQUEST_EX.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST_EX"]/*' />
public partial struct KERB_ADD_CREDENTIALS_REQUEST_EX
{
    /// <include file='KERB_ADD_CREDENTIALS_REQUEST_EX.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST_EX.Credentials"]/*' />
    public KERB_ADD_CREDENTIALS_REQUEST Credentials;

    /// <include file='KERB_ADD_CREDENTIALS_REQUEST_EX.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST_EX.PrincipalNameCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint PrincipalNameCount;

    /// <include file='KERB_ADD_CREDENTIALS_REQUEST_EX.xml' path='doc/member[@name="KERB_ADD_CREDENTIALS_REQUEST_EX.PrincipalNames"]/*' />
    [NativeTypeName("UNICODE_STRING[1]")]
    public _PrincipalNames_e__FixedBuffer PrincipalNames;

    /// <include file='_PrincipalNames_e__FixedBuffer.xml' path='doc/member[@name="_PrincipalNames_e__FixedBuffer"]/*' />
    public partial struct _PrincipalNames_e__FixedBuffer
    {
        public LSA_UNICODE_STRING e0;

        [UnscopedRef]
        public ref LSA_UNICODE_STRING this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<LSA_UNICODE_STRING> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
