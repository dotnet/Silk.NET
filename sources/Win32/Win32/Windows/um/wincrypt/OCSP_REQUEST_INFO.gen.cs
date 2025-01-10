// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OCSP_REQUEST_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("PCERT_ALT_NAME_ENTRY")]
    public CERT_ALT_NAME_ENTRY* pRequestorName;

    [NativeTypeName("DWORD")]
    public uint cRequestEntry;

    [NativeTypeName("POCSP_REQUEST_ENTRY")]
    public OCSP_REQUEST_ENTRY* rgRequestEntry;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
