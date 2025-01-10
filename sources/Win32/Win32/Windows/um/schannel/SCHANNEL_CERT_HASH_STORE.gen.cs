// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCHANNEL_CERT_HASH_STORE
{
    [NativeTypeName("DWORD")]
    public uint dwLength;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public HCRYPTPROV hProv;

    [NativeTypeName("BYTE[20]")]
    public _ShaHash_e__FixedBuffer ShaHash;

    [NativeTypeName("WCHAR[128]")]
    public _pwszStoreName_e__FixedBuffer pwszStoreName;

    [InlineArray(20)]
    public partial struct _ShaHash_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(128)]
    public partial struct _pwszStoreName_e__FixedBuffer
    {
        public ushort e0;
    }
}
