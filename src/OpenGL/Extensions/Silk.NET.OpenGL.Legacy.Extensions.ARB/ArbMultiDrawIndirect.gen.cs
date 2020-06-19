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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multi_draw_indirect")]
    public abstract unsafe partial class ArbMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multi_draw_indirect";
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
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

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
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

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
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract unsafe void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

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
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirect")]
        public abstract void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract unsafe void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

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
        [NativeApi(EntryPoint = "glMultiDrawElementsIndirect")]
        public abstract void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] ref T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        public ArbMultiDrawIndirect(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

