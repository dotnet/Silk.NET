// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_RPMB_DATA_FRAME
{
    [NativeTypeName("BYTE[196]")]
    public _Stuff_e__FixedBuffer Stuff;

    [NativeTypeName("BYTE[32]")]
    public _KeyOrMAC_e__FixedBuffer KeyOrMAC;

    [NativeTypeName("BYTE[256]")]
    public _Data_e__FixedBuffer Data;

    [NativeTypeName("BYTE[16]")]
    public _Nonce_e__FixedBuffer Nonce;

    [NativeTypeName("BYTE[4]")]
    public _WriteCounter_e__FixedBuffer WriteCounter;

    [NativeTypeName("BYTE[2]")]
    public _Address_e__FixedBuffer Address;

    [NativeTypeName("BYTE[2]")]
    public _BlockCount_e__FixedBuffer BlockCount;

    [NativeTypeName("BYTE[2]")]
    public _OperationResult_e__FixedBuffer OperationResult;

    [NativeTypeName("BYTE[2]")]
    public _RequestOrResponseType_e__FixedBuffer RequestOrResponseType;

    [InlineArray(196)]
    public partial struct _Stuff_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(32)]
    public partial struct _KeyOrMAC_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(256)]
    public partial struct _Data_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(16)]
    public partial struct _Nonce_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(4)]
    public partial struct _WriteCounter_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _Address_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _BlockCount_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _OperationResult_e__FixedBuffer
    {
        public byte e0;
    }

    [InlineArray(2)]
    public partial struct _RequestOrResponseType_e__FixedBuffer
    {
        public byte e0;
    }
}
