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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_parallel_arrays")]
    public abstract unsafe partial class IntelParallelArrays : NativeExtension<GL>
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
        public abstract unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void NormalPointer([Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

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
        public abstract unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(FlowDirection.In)] void** pointer);

        public IntelParallelArrays(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

