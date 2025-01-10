// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_PROTOCOL_SPECIFIC_DATA_EXT
{
    public STORAGE_PROTOCOL_TYPE ProtocolType;

    [NativeTypeName("DWORD")]
    public uint DataType;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataValue;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataOffset;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataLength;

    [NativeTypeName("DWORD")]
    public uint FixedProtocolReturnData;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue2;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue3;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue4;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue5;

    [NativeTypeName("DWORD")]
    public uint ProtocolDataSubValue6;

    [NativeTypeName("DWORD[4]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(4)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
