// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[NativeTypeName("uint32_t")]
public enum DXCoreHardwareTypeFilterFlags : uint
{
    None = 0x0,
    GPU = 0x1,
    ComputeAccelerator = 0x2,
    NPU = 0x4,
    MediaAccelerator = 0x8,
}
