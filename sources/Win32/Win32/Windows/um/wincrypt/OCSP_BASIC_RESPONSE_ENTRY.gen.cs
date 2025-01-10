// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OCSP_BASIC_RESPONSE_ENTRY
{
    public OCSP_CERT_ID CertId;

    [NativeTypeName("DWORD")]
    public uint dwCertStatus;

    [NativeTypeName("__AnonymousRecord_wincrypt_L5725_C5")]
    public _Anonymous_e__Union Anonymous;
    public FILETIME ThisUpdate;
    public FILETIME NextUpdate;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;

    [UnscopedRef]
    public ref OCSP_BASIC_REVOKED_INFO* pRevokedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.pRevokedInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("POCSP_BASIC_REVOKED_INFO")]
        public OCSP_BASIC_REVOKED_INFO* pRevokedInfo;
    }
}
