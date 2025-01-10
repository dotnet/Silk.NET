// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CMC_TAGGED_REQUEST
{
    [NativeTypeName("DWORD")]
    public uint dwTaggedRequestChoice;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5274_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pTaggedCertRequest; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PCMC_TAGGED_CERT_REQUEST")]
        public CMC_TAGGED_CERT_REQUEST* pTaggedCertRequest;
    }
}
