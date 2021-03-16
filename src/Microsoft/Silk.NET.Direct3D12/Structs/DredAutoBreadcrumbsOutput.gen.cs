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
    [NativeName("Name", "D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT")]
    public unsafe partial struct DredAutoBreadcrumbsOutput
    {
        public DredAutoBreadcrumbsOutput
        (
            AutoBreadcrumbNode* pHeadAutoBreadcrumbNode = null
        ) : this()
        {
            if (pHeadAutoBreadcrumbNode is not null)
            {
                PHeadAutoBreadcrumbNode = pHeadAutoBreadcrumbNode;
            }
        }


        [NativeName("Type", "const D3D12_AUTO_BREADCRUMB_NODE *")]
        [NativeName("Type.Name", "const D3D12_AUTO_BREADCRUMB_NODE *")]
        [NativeName("Name", "pHeadAutoBreadcrumbNode")]
        public AutoBreadcrumbNode* PHeadAutoBreadcrumbNode;
    }
}
