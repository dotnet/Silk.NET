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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_triangle_list")]
    public abstract unsafe partial class SunTriangleList : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_triangle_list";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] uint code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] ushort code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] byte code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] uint* code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref uint code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ushort* code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref ushort code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] byte* code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref byte code);

        /// <summary>
        /// To be added.
        /// </summary>
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
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        /// <summary>
        /// To be added.
        /// </summary>
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
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public abstract void ReplacementCode([Flow(FlowDirection.In)] string code);

        /// <summary>
        /// To be added.
        /// </summary>
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
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        /// <summary>
        /// To be added.
        /// </summary>
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
        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public abstract unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged;

        public SunTriangleList(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

