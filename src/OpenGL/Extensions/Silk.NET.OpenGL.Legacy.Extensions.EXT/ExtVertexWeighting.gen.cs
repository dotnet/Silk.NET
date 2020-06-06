// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_weighting")]
    public unsafe partial class ExtVertexWeighting : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_weighting";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeight([Flow(FlowDirection.In)] float weight)
            => ImplVertexWeight(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] float* weight)
            => ImplVertexWeight(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="weight">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeight([Count(Count = 1), Flow(FlowDirection.In)] ref float weight)
            => ImplVertexWeight(weight);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexWeightPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexWeightPointer<T0>(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexWeightPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexWeightPointer(size, type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        [NativeApi(EntryPoint = "glVertexWeightPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexWeightPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexWeightPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexWeightPointer<T0>(size, type, stride, pointer);

        public ExtVertexWeighting(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

