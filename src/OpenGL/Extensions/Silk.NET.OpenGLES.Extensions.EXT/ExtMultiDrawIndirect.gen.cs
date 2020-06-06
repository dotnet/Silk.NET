// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_multi_draw_indirect")]
    public unsafe partial class ExtMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multi_draw_indirect";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirect(mode, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirect<T0>(mode, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirect<T0>(mode, type, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawArraysIndirect(mode, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawArraysIndirect<T0>(mode, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride)
            => ImplMultiDrawElementsIndirect(mode, type, indirect, drawcount, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="indirect">
        /// To be added.
        /// This parameter's element count is computed from drawcount and stride.
        /// </param>
        /// <param name="drawcount">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
            => ImplMultiDrawElementsIndirect<T0>(mode, type, indirect, drawcount, stride);

        public ExtMultiDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

