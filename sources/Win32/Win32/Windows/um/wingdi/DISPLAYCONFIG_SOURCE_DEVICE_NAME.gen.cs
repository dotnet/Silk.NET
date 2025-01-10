// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_SOURCE_DEVICE_NAME
{
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    [NativeTypeName("WCHAR[32]")]
    public _viewGdiDeviceName_e__FixedBuffer viewGdiDeviceName;

    [InlineArray(32)]
    public partial struct _viewGdiDeviceName_e__FixedBuffer
    {
        public ushort e0;
    }
}
