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

namespace Silk.NET.OpenGLES.Extensions.IMG
{
    public static class ImgBindlessTextureOverloads
    {
        public static unsafe void ProgramUniformHandle(this ImgBindlessTexture thisApi, [Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> values)
        {
            // SpanOverloader
            thisApi.ProgramUniformHandle(program, location, count, in values.GetPinnableReference());
        }

        public static unsafe void UniformHandle(this ImgBindlessTexture thisApi, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<ulong> value)
        {
            // SpanOverloader
            thisApi.UniformHandle(location, count, in value.GetPinnableReference());
        }

    }
}

