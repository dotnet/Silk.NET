// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIDEVICEINSTANCE_DX3A
{
    [NativeTypeName("DWORD")]
    public uint dwSize;
    public Guid guidInstance;
    public Guid guidProduct;

    [NativeTypeName("DWORD")]
    public uint dwDevType;

    [NativeTypeName("CHAR[260]")]
    public _tszInstanceName_e__FixedBuffer tszInstanceName;

    [NativeTypeName("CHAR[260]")]
    public _tszProductName_e__FixedBuffer tszProductName;

    [InlineArray(260)]
    public partial struct _tszInstanceName_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(260)]
    public partial struct _tszProductName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
