// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct X509Certificate
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD[4]")]
    public _SerialNumber_e__FixedBuffer SerialNumber;

    [NativeTypeName("ALG_ID")]
    public uint SignatureAlgorithm;
    public FILETIME ValidFrom;
    public FILETIME ValidUntil;

    [NativeTypeName("PSTR")]
    public sbyte* pszIssuer;

    [NativeTypeName("PSTR")]
    public sbyte* pszSubject;
    public PctPublicKey* pPublicKey;

    [InlineArray(4)]
    public partial struct _SerialNumber_e__FixedBuffer
    {
        public uint e0;
    }
}
