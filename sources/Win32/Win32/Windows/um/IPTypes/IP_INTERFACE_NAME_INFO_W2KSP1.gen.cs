// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IP_INTERFACE_NAME_INFO_W2KSP1
{
    [NativeTypeName("ULONG")]
    public uint Index;

    [NativeTypeName("ULONG")]
    public uint MediaType;

    [NativeTypeName("UCHAR")]
    public byte ConnectionType;

    [NativeTypeName("UCHAR")]
    public byte AccessType;
    public Guid DeviceGuid;
    public Guid InterfaceGuid;
}
