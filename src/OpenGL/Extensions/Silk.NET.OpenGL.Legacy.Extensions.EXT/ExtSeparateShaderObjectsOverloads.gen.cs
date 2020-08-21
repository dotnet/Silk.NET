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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtSeparateShaderObjectsOverloads
    {
        public static unsafe uint CreateShaderProgram(this ExtSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // SpanOverloader
            return thisApi.CreateShaderProgram(type, in @string.GetPinnableReference());
        }

        public static unsafe uint CreateShaderProgram(this ExtSeparateShaderObjects thisApi, [Flow(FlowDirection.In)] ShaderType type, [Flow(FlowDirection.In)] ReadOnlySpan<byte> @string)
        {
            // SpanOverloader
            return thisApi.CreateShaderProgram(type, in @string.GetPinnableReference());
        }

    }
}

