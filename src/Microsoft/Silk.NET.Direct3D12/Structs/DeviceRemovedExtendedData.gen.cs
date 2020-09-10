// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA")]
    public unsafe partial struct DeviceRemovedExtendedData
    {
        public DeviceRemovedExtendedData
        (
            DredFlags flags = default,
            AutoBreadcrumbNode* pHeadAutoBreadcrumbNode = default
        )
        {
            Flags = flags;
            PHeadAutoBreadcrumbNode = pHeadAutoBreadcrumbNode;
        }


        [NativeName("Type", "D3D12_DRED_FLAGS")]
        [NativeName("Type.Name", "D3D12_DRED_FLAGS")]
        [NativeName("Name", "Flags")]
        public DredFlags Flags;

        [NativeName("Type", "D3D12_AUTO_BREADCRUMB_NODE *")]
        [NativeName("Type.Name", "D3D12_AUTO_BREADCRUMB_NODE *")]
        [NativeName("Name", "pHeadAutoBreadcrumbNode")]
        public AutoBreadcrumbNode* PHeadAutoBreadcrumbNode;
    }
}
