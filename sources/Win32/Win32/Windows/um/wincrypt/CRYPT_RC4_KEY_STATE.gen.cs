// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRYPT_RC4_KEY_STATE
{
    [NativeTypeName("unsigned char[16]")]
    public _Key_e__FixedBuffer Key;

    [NativeTypeName("unsigned char[256]")]
    public _SBox_e__FixedBuffer SBox;

    [NativeTypeName("unsigned char")]
    public byte i;

    [NativeTypeName("unsigned char")]
    public byte j;

    [InlineArray(16)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _SBox_e__FixedBuffer
    {
        public byte e0;
    }
}
