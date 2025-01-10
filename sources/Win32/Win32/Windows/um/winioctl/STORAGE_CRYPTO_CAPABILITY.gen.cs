// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_CRYPTO_CAPABILITY
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint CryptoCapabilityIndex;
    public STORAGE_CRYPTO_ALGORITHM_ID AlgorithmId;
    public STORAGE_CRYPTO_KEY_SIZE KeySize;

    [NativeTypeName("DWORD")]
    public uint DataUnitSizeBitmask;
}
