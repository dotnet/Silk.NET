// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0")]
public partial struct D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA
{
    public uint PrivateDataSize;
    public uint HWProtectionDataSize;

    [NativeTypeName("BYTE[4]")]
    public _pbInput_e__FixedBuffer pbInput;

    [InlineArray(4)]
    public partial struct _pbInput_e__FixedBuffer
    {
        public byte e0;
    }
}
