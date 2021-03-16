// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DEVICE_REMOVED_EXTENDED_DATA2")]
    public unsafe partial struct DeviceRemovedExtendedData2
    {
        public DeviceRemovedExtendedData2
        (
            int? deviceRemovedReason = null,
            DredAutoBreadcrumbsOutput1? autoBreadcrumbsOutput = null,
            DredPageFaultOutput1? pageFaultOutput = null
        ) : this()
        {
            if (deviceRemovedReason is not null)
            {
                DeviceRemovedReason = deviceRemovedReason.Value;
            }

            if (autoBreadcrumbsOutput is not null)
            {
                AutoBreadcrumbsOutput = autoBreadcrumbsOutput.Value;
            }

            if (pageFaultOutput is not null)
            {
                PageFaultOutput = pageFaultOutput.Value;
            }
        }


        [NativeName("Type", "HRESULT")]
        [NativeName("Type.Name", "HRESULT")]
        [NativeName("Name", "DeviceRemovedReason")]
        public int DeviceRemovedReason;

        [NativeName("Type", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1")]
        [NativeName("Type.Name", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1")]
        [NativeName("Name", "AutoBreadcrumbsOutput")]
        public DredAutoBreadcrumbsOutput1 AutoBreadcrumbsOutput;

        [NativeName("Type", "D3D12_DRED_PAGE_FAULT_OUTPUT1")]
        [NativeName("Type.Name", "D3D12_DRED_PAGE_FAULT_OUTPUT1")]
        [NativeName("Name", "PageFaultOutput")]
        public DredPageFaultOutput1 PageFaultOutput;
    }
}
