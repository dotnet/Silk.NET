// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct D3D12_PROGRAM_IDENTIFIER
{
    [NativeTypeName("UINT64[4]")]
    public _OpaqueData_e__FixedBuffer OpaqueData;

    [InlineArray(4)]
    public partial struct _OpaqueData_e__FixedBuffer
    {
        public ulong e0;
    }
}
