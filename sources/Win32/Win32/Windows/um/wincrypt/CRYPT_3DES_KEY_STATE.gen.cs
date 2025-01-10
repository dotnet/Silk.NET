// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRYPT_3DES_KEY_STATE
{
    [NativeTypeName("unsigned char[24]")]
    public _Key_e__FixedBuffer Key;

    [NativeTypeName("unsigned char[8]")]
    public _IV_e__FixedBuffer IV;

    [NativeTypeName("unsigned char[8]")]
    public _Feedback_e__FixedBuffer Feedback;

    [InlineArray(24)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _IV_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(8)]
    public partial struct _Feedback_e__FixedBuffer
    {
        public byte e0;
    }
}
