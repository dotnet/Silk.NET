// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct AMCOPPStatusOutput
{
    public Guid macKDI;

    [NativeTypeName("DWORD")]
    public uint cbSizeData;

    [NativeTypeName("BYTE[4076]")]
    public _COPPStatus_e__FixedBuffer COPPStatus;

    [InlineArray(4076)]
    public partial struct _COPPStatus_e__FixedBuffer
    {
        public byte e0;
    }
}
