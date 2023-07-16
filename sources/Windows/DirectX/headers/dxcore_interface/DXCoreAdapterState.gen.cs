// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState"]/*'/>
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreAdapterState : uint
{
    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.IsDriverUpdateInProgress"]/*'/>
    IsDriverUpdateInProgress = 0,
    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterMemoryBudget"]/*'/>
    AdapterMemoryBudget = 1,
}