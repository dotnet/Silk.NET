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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_parallel_arrays")]
    public unsafe partial class IntelParallelArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_parallel_arrays";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplColorPointer(size, type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointer([Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplNormalPointer(type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplTexCoordPointer(size, type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplVertexPointer(size, type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplColorPointer(size, type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplNormalPointer(type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplTexCoordPointer(size, type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter contains 4 elements.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointervINTEL")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer)
            => ImplVertexPointer(size, type, pointer);

        public IntelParallelArrays(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

