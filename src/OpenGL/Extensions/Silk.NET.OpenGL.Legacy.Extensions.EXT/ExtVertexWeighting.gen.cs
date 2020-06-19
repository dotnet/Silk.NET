// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_weighting")]
    public abstract unsafe partial class ExtVertexWeighting : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_weighting";
        [NativeApi(EntryPoint = "glVertexWeightfEXT")]
        public abstract void VertexWeight([Flow(FlowDirection.In)] float weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        public abstract unsafe void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] float* weight);

        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        public abstract void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] ref float weight);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public abstract unsafe void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public abstract void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public abstract unsafe void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        public abstract void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtVertexWeighting(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

