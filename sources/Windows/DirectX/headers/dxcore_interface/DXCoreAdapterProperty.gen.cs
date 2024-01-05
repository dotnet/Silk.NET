// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;

/// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty"]/*'/>
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreAdapterProperty : uint
{
    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.InstanceLuid"]/*'/>

    InstanceLuid = 0,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.DriverVersion"]/*'/>

    DriverVersion = 1,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.DriverDescription"]/*'/>

    DriverDescription = 2,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.HardwareID"]/*'/>

    HardwareID = 3,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.KmdModelVersion"]/*'/>

    KmdModelVersion = 4,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.ComputePreemptionGranularity"]/*'/>

    ComputePreemptionGranularity = 5,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.GraphicsPreemptionGranularity"]/*'/>

    GraphicsPreemptionGranularity = 6,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.DedicatedAdapterMemory"]/*'/>

    DedicatedAdapterMemory = 7,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.DedicatedSystemMemory"]/*'/>

    DedicatedSystemMemory = 8,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.SharedSystemMemory"]/*'/>

    SharedSystemMemory = 9,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.AcgCompatible"]/*'/>

    AcgCompatible = 10,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.IsHardware"]/*'/>

    IsHardware = 11,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.IsIntegrated"]/*'/>

    IsIntegrated = 12,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.IsDetachable"]/*'/>

    IsDetachable = 13,

    /// <include file='DXCoreAdapterProperty.xml' path='doc/member[@name="DXCoreAdapterProperty.HardwareIDParts"]/*'/>

    HardwareIDParts = 14,
}
