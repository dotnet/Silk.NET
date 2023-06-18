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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_elements_base_vertex")]
    public unsafe partial class ArbDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_elements_base_vertex";
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB mode, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB type, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void** indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawcount, [Count(Parameter = "drawcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* basevertex);

        public ArbDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

