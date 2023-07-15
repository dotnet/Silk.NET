// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA2.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2"]/*'/>
public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA2
{
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA2.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2.DeviceRemovedReason"]/*'/>
    public HRESULT DeviceRemovedReason;
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA2.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2.AutoBreadcrumbsOutput"]/*'/>
    public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput;
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA2.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA2.PageFaultOutput"]/*'/>
    public D3D12_DRED_PAGE_FAULT_OUTPUT1 PageFaultOutput;
}