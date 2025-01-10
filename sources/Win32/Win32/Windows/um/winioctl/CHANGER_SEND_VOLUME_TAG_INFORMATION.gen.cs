// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct CHANGER_SEND_VOLUME_TAG_INFORMATION
{
    public CHANGER_ELEMENT StartingElement;

    [NativeTypeName("DWORD")]
    public uint ActionCode;

    [NativeTypeName("BYTE[40]")]
    public _VolumeIDTemplate_e__FixedBuffer VolumeIDTemplate;

    [InlineArray(40)]
    public partial struct _VolumeIDTemplate_e__FixedBuffer
    {
        public byte e0;
    }
}
