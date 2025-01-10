// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FSCTL_QUERY_FAT_BPB_BUFFER
{
    [NativeTypeName("BYTE[36]")]
    public _First0x24BytesOfBootSector_e__FixedBuffer First0x24BytesOfBootSector;

    [InlineArray(36)]
    public partial struct _First0x24BytesOfBootSector_e__FixedBuffer
    {
        public byte e0;
    }
}
