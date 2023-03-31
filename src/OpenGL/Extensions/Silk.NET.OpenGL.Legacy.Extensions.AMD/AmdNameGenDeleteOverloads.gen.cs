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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdNameGenDeleteOverloads
    {
        public static unsafe void DeleteNames(this AmdNameGenDelete thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> names)
        {
            // SpanOverloader
            thisApi.DeleteNames(identifier, num, in names.GetPinnableReference());
        }

        public static unsafe void GenNames(this AmdNameGenDelete thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD identifier, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> names)
        {
            // SpanOverloader
            thisApi.GenNames(identifier, num, out names.GetPinnableReference());
        }

    }
}

