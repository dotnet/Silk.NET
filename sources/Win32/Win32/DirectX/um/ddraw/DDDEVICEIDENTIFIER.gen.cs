// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDDEVICEIDENTIFIER
{
    [NativeTypeName("char[512]")]
    public _szDriver_e__FixedBuffer szDriver;

    [NativeTypeName("char[512]")]
    public _szDescription_e__FixedBuffer szDescription;
    public LARGE_INTEGER liDriverVersion;

    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    [NativeTypeName("DWORD")]
    public uint dwRevision;
    public Guid guidDeviceIdentifier;

    [InlineArray(512)]
    public partial struct _szDriver_e__FixedBuffer
    {
        public sbyte e0;
    }

    [InlineArray(512)]
    public partial struct _szDescription_e__FixedBuffer
    {
        public sbyte e0;
    }
}
