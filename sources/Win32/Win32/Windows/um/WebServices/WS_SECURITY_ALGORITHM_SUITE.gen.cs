// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct WS_SECURITY_ALGORITHM_SUITE
{
    public WS_SECURITY_ALGORITHM_ID canonicalizationAlgorithm;
    public WS_SECURITY_ALGORITHM_ID digestAlgorithm;
    public WS_SECURITY_ALGORITHM_ID symmetricSignatureAlgorithm;
    public WS_SECURITY_ALGORITHM_ID asymmetricSignatureAlgorithm;
    public WS_SECURITY_ALGORITHM_ID encryptionAlgorithm;
    public WS_SECURITY_ALGORITHM_ID keyDerivationAlgorithm;
    public WS_SECURITY_ALGORITHM_ID symmetricKeyWrapAlgorithm;
    public WS_SECURITY_ALGORITHM_ID asymmetricKeyWrapAlgorithm;

    [NativeTypeName("ULONG")]
    public uint minSymmetricKeyLength;

    [NativeTypeName("ULONG")]
    public uint maxSymmetricKeyLength;

    [NativeTypeName("ULONG")]
    public uint minAsymmetricKeyLength;

    [NativeTypeName("ULONG")]
    public uint maxAsymmetricKeyLength;
    public WS_SECURITY_ALGORITHM_PROPERTY* properties;

    [NativeTypeName("ULONG")]
    public uint propertyCount;
}
