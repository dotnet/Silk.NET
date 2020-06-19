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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_framebuffer_sample_positions")]
    public abstract unsafe partial class AmdFramebufferSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_sample_positions";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public abstract unsafe void FramebufferSamplePositions([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public abstract void FramebufferSamplePositions([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] Span<float> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD")]
        public abstract unsafe void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD")]
        public abstract void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD")]
        public abstract unsafe void NamedFramebufferSamplePositions([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD")]
        public abstract void NamedFramebufferSamplePositions([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] Span<float> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public abstract unsafe void FramebufferSamplePositions([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public abstract void FramebufferSamplePositions([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] Span<float> values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public abstract unsafe void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="numsamples">
        /// To be added.
        /// </param>
        /// <param name="pixelindex">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="values">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public abstract void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values);

        public AmdFramebufferSamplePositions(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

