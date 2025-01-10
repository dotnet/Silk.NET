// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_TARGET_PREFERRED_MODE
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    [NativeTypeName("UINT32")]
    public uint width;

    [NativeTypeName("UINT32")]
    public uint height;
    public DISPLAYCONFIG_TARGET_MODE targetMode;
}
