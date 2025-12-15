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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUVertexBufferLayout")]
    public unsafe partial struct VertexBufferLayout
    {
        public VertexBufferLayout
        (
            ulong? arrayStride = null,
            VertexStepMode? stepMode = null,
            nuint? attributeCount = null,
            VertexAttribute* attributes = null
        ) : this()
        {
            if (arrayStride is not null)
            {
                ArrayStride = arrayStride.Value;
            }

            if (stepMode is not null)
            {
                StepMode = stepMode.Value;
            }

            if (attributeCount is not null)
            {
                AttributeCount = attributeCount.Value;
            }

            if (attributes is not null)
            {
                Attributes = attributes;
            }
        }


        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "arrayStride")]
        public ulong ArrayStride;

        [NativeName("Type", "WGPUVertexStepMode")]
        [NativeName("Type.Name", "WGPUVertexStepMode")]
        [NativeName("Name", "stepMode")]
        public VertexStepMode StepMode;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "attributeCount")]
        public nuint AttributeCount;

        [NativeName("Type", "const WGPUVertexAttribute *")]
        [NativeName("Type.Name", "const WGPUVertexAttribute *")]
        [NativeName("Name", "attributes")]
        public VertexAttribute* Attributes;
    }
}
