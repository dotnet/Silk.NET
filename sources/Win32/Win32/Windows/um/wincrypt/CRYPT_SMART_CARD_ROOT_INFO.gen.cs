// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRYPT_SMART_CARD_ROOT_INFO
{
    [NativeTypeName("BYTE[16]")]
    public _rgbCardID_e__FixedBuffer rgbCardID;
    public ROOT_INFO_LUID luid;

    [InlineArray(16)]
    public partial struct _rgbCardID_e__FixedBuffer
    {
        public byte e0;
    }
}
