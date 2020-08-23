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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_framebuffer_sample_positions")]
    public unsafe partial class AmdFramebufferSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_sample_positions";
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public unsafe partial void FramebufferSamplePositions([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public partial void FramebufferSamplePositions([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] in float values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public unsafe partial void FramebufferSamplePositions([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD")]
        public partial void FramebufferSamplePositions([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] in float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public unsafe partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD")]
        public partial void GetFramebufferParameter([Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD")]
        public unsafe partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD")]
        public partial void GetNamedFramebufferParameter([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD")]
        public unsafe partial void NamedFramebufferSamplePositions([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD")]
        public partial void NamedFramebufferSamplePositions([Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] in float values);

        public AmdFramebufferSamplePositions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

