// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CRYPT_AES_256_KEY_STATE
{
    [NativeTypeName("unsigned char[32]")]
    public _Key_e__FixedBuffer Key;

    [NativeTypeName("unsigned char[16]")]
    public _IV_e__FixedBuffer IV;

    [NativeTypeName("unsigned char[15][16]")]
    public _EncryptionState_e__FixedBuffer EncryptionState;

    [NativeTypeName("unsigned char[15][16]")]
    public _DecryptionState_e__FixedBuffer DecryptionState;

    [NativeTypeName("unsigned char[16]")]
    public _Feedback_e__FixedBuffer Feedback;

    [InlineArray(32)]
    public partial struct _Key_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _IV_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(15 * 16)]
    public partial struct _EncryptionState_e__FixedBuffer
    {
        public byte e0_0;
    }

    [InlineArray(15 * 16)]
    public partial struct _DecryptionState_e__FixedBuffer
    {
        public byte e0_0;
    }

    [InlineArray(16)]
    public partial struct _Feedback_e__FixedBuffer
    {
        public byte e0;
    }
}
