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
    [NativeName("Name", "D3D12_SERIALIZED_ROOT_SIGNATURE_DESC")]
    public unsafe partial struct SerializedRootSignatureDesc
    {
        public SerializedRootSignatureDesc
        (
            void* pSerializedBlob = null,
            nuint? serializedBlobSizeInBytes = null
        ) : this()
        {
            if (pSerializedBlob is not null)
            {
                PSerializedBlob = pSerializedBlob;
            }

            if (serializedBlobSizeInBytes is not null)
            {
                SerializedBlobSizeInBytes = serializedBlobSizeInBytes.Value;
            }
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pSerializedBlob")]
        public void* PSerializedBlob;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SerializedBlobSizeInBytes")]
        public nuint SerializedBlobSizeInBytes;
    }
}
