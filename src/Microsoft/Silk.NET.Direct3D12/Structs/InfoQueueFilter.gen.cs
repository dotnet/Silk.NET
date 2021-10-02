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
    [NativeName("Name", "D3D12_INFO_QUEUE_FILTER")]
    public unsafe partial struct InfoQueueFilter
    {
        public InfoQueueFilter
        (
            InfoQueueFilterDesc? allowList = null,
            InfoQueueFilterDesc? denyList = null
        ) : this()
        {
            if (allowList is not null)
            {
                AllowList = allowList.Value;
            }

            if (denyList is not null)
            {
                DenyList = denyList.Value;
            }
        }


        [NativeName("Type", "D3D12_INFO_QUEUE_FILTER_DESC")]
        [NativeName("Type.Name", "D3D12_INFO_QUEUE_FILTER_DESC")]
        [NativeName("Name", "AllowList")]
        public InfoQueueFilterDesc AllowList;

        [NativeName("Type", "D3D12_INFO_QUEUE_FILTER_DESC")]
        [NativeName("Type.Name", "D3D12_INFO_QUEUE_FILTER_DESC")]
        [NativeName("Name", "DenyList")]
        public InfoQueueFilterDesc DenyList;
    }
}
