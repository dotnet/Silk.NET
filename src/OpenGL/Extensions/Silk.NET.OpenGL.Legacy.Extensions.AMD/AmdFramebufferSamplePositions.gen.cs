// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_framebuffer_sample_positions")]
    public unsafe partial class AmdFramebufferSamplePositions : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_framebuffer_sample_positions";
        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void FramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public partial void FramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public partial void GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* values);

        [NativeApi(EntryPoint = "glGetNamedFramebufferParameterfvAMD", Convention = CallingConvention.Winapi)]
        public partial void GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float values);

        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void NamedFramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glNamedFramebufferSamplePositionsfvAMD", Convention = CallingConvention.Winapi)]
        public partial void NamedFramebufferSamplePositions([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float values);

        public unsafe float GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out float silkRet);
            return silkRet;
        }

        public unsafe float GetFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out float silkRet);
            return silkRet;
        }

        public unsafe float GetNamedFramebufferParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size)
        {
            // NonKhrReturnTypeOverloader
            GetNamedFramebufferParameter(framebuffer, pname, numsamples, pixelindex, size, out float silkRet);
            return silkRet;
        }

        public AmdFramebufferSamplePositions(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

