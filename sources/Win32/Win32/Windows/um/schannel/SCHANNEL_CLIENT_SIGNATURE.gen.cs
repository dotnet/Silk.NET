// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCHANNEL_CLIENT_SIGNATURE
{
    [NativeTypeName("DWORD")]
    public uint cbLength;

    [NativeTypeName("ALG_ID")]
    public uint aiHash;

    [NativeTypeName("DWORD")]
    public uint cbHash;

    [NativeTypeName("BYTE[36]")]
    public _HashValue_e__FixedBuffer HashValue;

    [NativeTypeName("BYTE[20]")]
    public _CertThumbprint_e__FixedBuffer CertThumbprint;

    [InlineArray(36)]
    public partial struct _HashValue_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(20)]
    public partial struct _CertThumbprint_e__FixedBuffer
    {
        public byte e0;
    }
}
