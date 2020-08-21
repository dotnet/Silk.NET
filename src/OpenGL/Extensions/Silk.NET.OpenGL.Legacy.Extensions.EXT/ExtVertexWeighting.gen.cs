// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_weighting")]
    public unsafe partial class ExtVertexWeighting : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_weighting";
        [NativeApi(EntryPoint = "glVertexWeightfEXT")]
        public partial void VertexWeight([Flow(FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        public unsafe partial void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] float* weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        public partial void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] in float weight);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public unsafe partial void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public partial void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public unsafe partial void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public partial void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public ExtVertexWeighting(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

