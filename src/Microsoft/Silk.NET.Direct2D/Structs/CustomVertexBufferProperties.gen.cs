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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES")]
    public unsafe partial struct CustomVertexBufferProperties
    {
        public CustomVertexBufferProperties
        (
            byte* shaderBufferWithInputSignature = null,
            uint? shaderBufferSize = null,
            InputElementDesc* inputElements = null,
            uint? elementCount = null,
            uint? stride = null
        ) : this()
        {
            if (shaderBufferWithInputSignature is not null)
            {
                ShaderBufferWithInputSignature = shaderBufferWithInputSignature;
            }

            if (shaderBufferSize is not null)
            {
                ShaderBufferSize = shaderBufferSize.Value;
            }

            if (inputElements is not null)
            {
                InputElements = inputElements;
            }

            if (elementCount is not null)
            {
                ElementCount = elementCount.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }
        }


        [NativeName("Type", "const BYTE *")]
        [NativeName("Type.Name", "const BYTE *")]
        [NativeName("Name", "shaderBufferWithInputSignature")]
        public byte* ShaderBufferWithInputSignature;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "shaderBufferSize")]
        public uint ShaderBufferSize;

        [NativeName("Type", "const D2D1_INPUT_ELEMENT_DESC *")]
        [NativeName("Type.Name", "const D2D1_INPUT_ELEMENT_DESC *")]
        [NativeName("Name", "inputElements")]
        public InputElementDesc* InputElements;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "elementCount")]
        public uint ElementCount;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "stride")]
        public uint Stride;
    }
}
