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
    [NativeName("Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS_CLEAR_PARAMETERS")]
    public unsafe partial struct RenderPassBeginningAccessClearParameters
    {
        public RenderPassBeginningAccessClearParameters
        (
            ClearValue? clearValue = null
        ) : this()
        {
            if (clearValue is not null)
            {
                ClearValue = clearValue.Value;
            }
        }


        [NativeName("Type", "D3D12_CLEAR_VALUE")]
        [NativeName("Type.Name", "D3D12_CLEAR_VALUE")]
        [NativeName("Name", "ClearValue")]
        public ClearValue ClearValue;
    }
}
