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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtBlendFuncExtendedOverloads
    {
        public static unsafe void BindFragDataLocation(this ExtBlendFuncExtended thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocation(program, color, in name.GetPinnableReference());
        }

        public static unsafe void BindFragDataLocationIndexed(this ExtBlendFuncExtended thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint colorNumber, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            thisApi.BindFragDataLocationIndexed(program, colorNumber, index, in name.GetPinnableReference());
        }

        public static unsafe int GetFragDataIndex(this ExtBlendFuncExtended thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetFragDataIndex(program, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ExtBlendFuncExtended thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

        public static unsafe int GetProgramResourceLocationIndex(this ExtBlendFuncExtended thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> name)
        {
            // SpanOverloader
            return thisApi.GetProgramResourceLocationIndex(program, programInterface, in name.GetPinnableReference());
        }

    }
}

