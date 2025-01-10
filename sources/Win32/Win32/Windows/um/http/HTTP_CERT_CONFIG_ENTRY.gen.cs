// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_CERT_CONFIG_ENTRY
{
    [NativeTypeName("BYTE[20]")]
    public _CertHash_e__FixedBuffer CertHash;

    [NativeTypeName("WCHAR[128]")]
    public _CertStoreName_e__FixedBuffer CertStoreName;

    [InlineArray(20)]
    public partial struct _CertHash_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(128)]
    public partial struct _CertStoreName_e__FixedBuffer
    {
        public ushort e0;
    }
}
