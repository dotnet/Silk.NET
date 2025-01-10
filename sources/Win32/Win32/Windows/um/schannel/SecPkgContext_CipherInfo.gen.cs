// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SecPkgContext_CipherInfo
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwProtocol;

    [NativeTypeName("DWORD")]
    public uint dwCipherSuite;

    [NativeTypeName("DWORD")]
    public uint dwBaseCipherSuite;

    [NativeTypeName("WCHAR[64]")]
    public _szCipherSuite_e__FixedBuffer szCipherSuite;

    [NativeTypeName("WCHAR[64]")]
    public _szCipher_e__FixedBuffer szCipher;

    [NativeTypeName("DWORD")]
    public uint dwCipherLen;

    [NativeTypeName("DWORD")]
    public uint dwCipherBlockLen;

    [NativeTypeName("WCHAR[64]")]
    public _szHash_e__FixedBuffer szHash;

    [NativeTypeName("DWORD")]
    public uint dwHashLen;

    [NativeTypeName("WCHAR[64]")]
    public _szExchange_e__FixedBuffer szExchange;

    [NativeTypeName("DWORD")]
    public uint dwMinExchangeLen;

    [NativeTypeName("DWORD")]
    public uint dwMaxExchangeLen;

    [NativeTypeName("WCHAR[64]")]
    public _szCertificate_e__FixedBuffer szCertificate;

    [NativeTypeName("DWORD")]
    public uint dwKeyType;

    [InlineArray(64)]
    public partial struct _szCipherSuite_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(64)]
    public partial struct _szCipher_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(64)]
    public partial struct _szHash_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(64)]
    public partial struct _szExchange_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(64)]
    public partial struct _szCertificate_e__FixedBuffer
    {
        public ushort e0;
    }
}
