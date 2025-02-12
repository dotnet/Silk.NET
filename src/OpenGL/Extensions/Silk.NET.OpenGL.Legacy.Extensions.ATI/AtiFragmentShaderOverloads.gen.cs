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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    public static class AtiFragmentShaderOverloads
    {
        public static unsafe void SetFragmentShaderConstant(this AtiFragmentShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dst, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.SetFragmentShaderConstant(dst, in value.GetPinnableReference());
        }

        public static unsafe void SetFragmentShaderConstant(this AtiFragmentShader thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentShaderConATI dst, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> value)
        {
            // SpanOverloader
            thisApi.SetFragmentShaderConstant(dst, in value.GetPinnableReference());
        }

    }
}

