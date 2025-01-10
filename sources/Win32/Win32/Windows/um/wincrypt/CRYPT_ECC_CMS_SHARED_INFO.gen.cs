// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRYPT_ECC_CMS_SHARED_INFO
{
    public CRYPT_ALGORITHM_IDENTIFIER Algorithm;
    public CRYPT_DATA_BLOB EntityUInfo;

    [NativeTypeName("BYTE[4]")]
    public _rgbSuppPubInfo_e__FixedBuffer rgbSuppPubInfo;

    [InlineArray(4)]
    public partial struct _rgbSuppPubInfo_e__FixedBuffer
    {
        public byte e0;
    }
}
