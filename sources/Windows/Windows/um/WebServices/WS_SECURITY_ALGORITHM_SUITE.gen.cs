// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE"]/*' />
public unsafe partial struct WS_SECURITY_ALGORITHM_SUITE
{
    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.canonicalizationAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID canonicalizationAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.digestAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID digestAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.symmetricSignatureAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID symmetricSignatureAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.asymmetricSignatureAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID asymmetricSignatureAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.encryptionAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID encryptionAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.keyDerivationAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID keyDerivationAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.symmetricKeyWrapAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID symmetricKeyWrapAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.asymmetricKeyWrapAlgorithm"]/*' />
    public WS_SECURITY_ALGORITHM_ID asymmetricKeyWrapAlgorithm;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.minSymmetricKeyLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint minSymmetricKeyLength;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.maxSymmetricKeyLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxSymmetricKeyLength;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.minAsymmetricKeyLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint minAsymmetricKeyLength;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.maxAsymmetricKeyLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint maxAsymmetricKeyLength;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.properties"]/*' />
    public WS_SECURITY_ALGORITHM_PROPERTY* properties;

    /// <include file='WS_SECURITY_ALGORITHM_SUITE.xml' path='doc/member[@name="WS_SECURITY_ALGORITHM_SUITE.propertyCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint propertyCount;
}
