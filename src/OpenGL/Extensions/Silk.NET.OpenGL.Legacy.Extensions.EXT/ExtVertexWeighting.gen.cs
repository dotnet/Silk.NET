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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_weighting")]
    public unsafe partial class ExtVertexWeighting : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_weighting";
        [NativeApi(EntryPoint = "glVertexWeightfEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexWeight([Flow(Silk.NET.Core.Native.FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexWeight([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexWeight([Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float weight);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexWeightPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexWeightPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        public ExtVertexWeighting(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

