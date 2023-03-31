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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbTextureMultisampleOverloads
    {
        public static unsafe void GetMultisample(this ArbTextureMultisample thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

        public static unsafe void GetMultisample(this ArbTextureMultisample thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetMultisamplePNameNV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> val)
        {
            // SpanOverloader
            thisApi.GetMultisample(pname, index, out val.GetPinnableReference());
        }

    }
}

