// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CERT_CHAIN_ENGINE_CONFIG
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public HCERTSTORE hRestrictedRoot;
    public HCERTSTORE hRestrictedTrust;
    public HCERTSTORE hRestrictedOther;

    [NativeTypeName("DWORD")]
    public uint cAdditionalStore;
    public HCERTSTORE* rghAdditionalStore;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint dwUrlRetrievalTimeout;

    [NativeTypeName("DWORD")]
    public uint MaximumCachedCertificates;

    [NativeTypeName("DWORD")]
    public uint CycleDetectionModulus;
    public HCERTSTORE hExclusiveRoot;
    public HCERTSTORE hExclusiveTrustedPeople;

    [NativeTypeName("DWORD")]
    public uint dwExclusiveFlags;
}
