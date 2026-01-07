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
    [NativeName("Name", "D3D12_GLOBAL_SERIALIZED_ROOT_SIGNATURE")]
    public unsafe partial struct GlobalSerializedRootSignature
    {
        public GlobalSerializedRootSignature
        (
            SerializedRootSignatureDesc? desc = null
        ) : this()
        {
            if (desc is not null)
            {
                Desc = desc.Value;
            }
        }


        [NativeName("Type", "D3D12_SERIALIZED_ROOT_SIGNATURE_DESC")]
        [NativeName("Type.Name", "D3D12_SERIALIZED_ROOT_SIGNATURE_DESC")]
        [NativeName("Name", "Desc")]
        public SerializedRootSignatureDesc Desc;
    }
}
