// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DXCoreProcessMemoryQueryOutput
{
    public DXCoreMemoryUsage memoryUsage;

    [NativeTypeName("bool")]
    public byte processQuerySucceeded;
}
