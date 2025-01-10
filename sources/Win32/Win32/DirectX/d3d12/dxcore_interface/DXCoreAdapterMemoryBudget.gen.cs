// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudget
{
    [NativeTypeName("uint64_t")]
    public ulong budget;

    [NativeTypeName("uint64_t")]
    public ulong currentUsage;

    [NativeTypeName("uint64_t")]
    public ulong availableForReservation;

    [NativeTypeName("uint64_t")]
    public ulong currentReservation;
}
