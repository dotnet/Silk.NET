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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixSpriteOverloads
    {
        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpriteModeSGIX> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

        public static unsafe void SpriteParameter(this SgixSprite thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SpriteParameterNameSGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SpriteModeSGIX> @params)
        {
            // SpanOverloader
            thisApi.SpriteParameter(pname, in @params.GetPinnableReference());
        }

    }
}

