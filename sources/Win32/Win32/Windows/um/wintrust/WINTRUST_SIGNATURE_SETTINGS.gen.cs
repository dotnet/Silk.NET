// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WINTRUST_SIGNATURE_SETTINGS
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint cSecondarySigs;

    [NativeTypeName("DWORD")]
    public uint dwVerifiedSigIndex;

    [NativeTypeName("PCERT_STRONG_SIGN_PARA")]
    public CERT_STRONG_SIGN_PARA* pCryptoPolicy;
}
