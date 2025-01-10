// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AMCOPPCommand
{
    public Guid macKDI;
    public Guid guidCommandID;

    [NativeTypeName("DWORD")]
    public uint dwSequence;

    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    [NativeTypeName("BYTE[4056]")]
    public _CommandData_e__FixedBuffer CommandData;

    [InlineArray(4056)]
    public partial struct _CommandData_e__FixedBuffer
    {
        public byte e0;
    }
}
