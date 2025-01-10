// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct DEVICE_DSM_OFFLOAD_READ_PARAMETERS
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint TimeToLive;

    [NativeTypeName("DWORD[2]")]
    public _Reserved_e__FixedBuffer Reserved;

    [InlineArray(2)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public uint e0;
    }
}
