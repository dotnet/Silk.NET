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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_triangle_list")]
    public unsafe partial class SunTriangleList : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_triangle_list";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuiSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Flow(FlowDirection.In)] uint code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Flow(FlowDirection.In)] ushort code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Flow(FlowDirection.In)] byte code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] uint* code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref uint code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ushort* code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref ushort code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] byte* code)
            => ImplReplacementCode(code);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// This parameter contains 0 elements.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ref byte code)
            => ImplReplacementCode(code);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer)
            => ImplReplacementCodePointer(type, stride, pointer);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged
            => ImplReplacementCodePointer<T0>(type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="code">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ReplacementCode([Flow(FlowDirection.In)] string code)
            => ImplReplacementCode(code);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCodePointer([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer)
            => ImplReplacementCodePointer(type, stride, pointer);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ReplacementCodePointer<T0>([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer) where T0 : unmanaged
            => ImplReplacementCodePointer<T0>(type, stride, pointer);

        public SunTriangleList(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

