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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_ERROR_PARAMETERS_SIGNAL")]
    public unsafe partial struct ErrorParametersSignal
    {
        public ErrorParametersSignal
        (
            Silk.NET.Direct3D12.ID3D12Fence* fence = null,
            ulong? value = null
        ) : this()
        {
            if (fence is not null)
            {
                Fence = fence;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "ID3D12Fence *")]
        [NativeName("Type.Name", "ID3D12Fence *")]
        [NativeName("Name", "Fence")]
        public Silk.NET.Direct3D12.ID3D12Fence* Fence;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Value")]
        public ulong Value;
    }
}
