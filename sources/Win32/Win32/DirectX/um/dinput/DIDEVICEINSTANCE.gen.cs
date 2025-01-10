// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DIDEVICEINSTANCE
{
    [NativeTypeName("DWORD")]
    public uint dwSize;
    public Guid guidInstance;
    public Guid guidProduct;

    [NativeTypeName("DWORD")]
    public uint dwDevType;

    [NativeTypeName("WCHAR[260]")]
    public _tszInstanceName_e__FixedBuffer tszInstanceName;

    [NativeTypeName("WCHAR[260]")]
    public _tszProductName_e__FixedBuffer tszProductName;
    public Guid guidFFDriver;

    [NativeTypeName("WORD")]
    public ushort wUsagePage;

    [NativeTypeName("WORD")]
    public ushort wUsage;

    [InlineArray(260)]
    public partial struct _tszInstanceName_e__FixedBuffer
    {
        public ushort e0;
    }

    [InlineArray(260)]
    public partial struct _tszProductName_e__FixedBuffer
    {
        public ushort e0;
    }
}
