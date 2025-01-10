// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CTL_INFO
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    public CTL_USAGE SubjectUsage;
    public CRYPT_DATA_BLOB ListIdentifier;

    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SequenceNumber;
    public FILETIME ThisUpdate;
    public FILETIME NextUpdate;
    public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;

    [NativeTypeName("DWORD")]
    public uint cCTLEntry;

    [NativeTypeName("PCTL_ENTRY")]
    public CTL_ENTRY* rgCTLEntry;

    [NativeTypeName("DWORD")]
    public uint cExtension;

    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}
