// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;
/// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudget
{
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.budget"]/*'/>
    [NativeTypeName("uint64_t")]
    public ulong budget;
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentUsage"]/*'/>
    [NativeTypeName("uint64_t")]
    public ulong currentUsage;
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.availableForReservation"]/*'/>
    [NativeTypeName("uint64_t")]
    public ulong availableForReservation;
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentReservation"]/*'/>
    [NativeTypeName("uint64_t")]
    public ulong currentReservation;
}