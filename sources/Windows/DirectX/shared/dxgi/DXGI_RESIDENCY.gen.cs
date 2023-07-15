// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY"]/*'/>
public enum DXGI_RESIDENCY
{
    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_FULLY_RESIDENT"]/*'/>
    DXGI_RESIDENCY_FULLY_RESIDENT = 1,
    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY"]/*'/>
    DXGI_RESIDENCY_RESIDENT_IN_SHARED_MEMORY = 2,
    /// <include file='DXGI_RESIDENCY.xml' path='doc/member[@name="DXGI_RESIDENCY.DXGI_RESIDENCY_EVICTED_TO_DISK"]/*'/>
    DXGI_RESIDENCY_EVICTED_TO_DISK = 3,
}