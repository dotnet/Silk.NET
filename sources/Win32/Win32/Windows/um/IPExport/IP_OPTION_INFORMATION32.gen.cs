// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IP_OPTION_INFORMATION32
{
    [NativeTypeName("UCHAR")]
    public byte Ttl;

    [NativeTypeName("UCHAR")]
    public byte Tos;

    [NativeTypeName("UCHAR")]
    public byte Flags;

    [NativeTypeName("UCHAR")]
    public byte OptionsSize;

    [NativeTypeName("UCHAR * __ptr32")]
    public byte* OptionsData;
}
