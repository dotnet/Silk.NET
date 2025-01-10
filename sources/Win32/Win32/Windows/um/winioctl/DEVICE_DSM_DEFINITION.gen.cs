// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DEVICE_DSM_DEFINITION
{
    [NativeTypeName("DEVICE_DSM_ACTION")]
    public uint Action;

    [NativeTypeName("BOOLEAN")]
    public byte SingleRange;

    [NativeTypeName("DWORD")]
    public uint ParameterBlockAlignment;

    [NativeTypeName("DWORD")]
    public uint ParameterBlockLength;

    [NativeTypeName("BOOLEAN")]
    public byte HasOutput;

    [NativeTypeName("DWORD")]
    public uint OutputBlockAlignment;

    [NativeTypeName("DWORD")]
    public uint OutputBlockLength;
}
