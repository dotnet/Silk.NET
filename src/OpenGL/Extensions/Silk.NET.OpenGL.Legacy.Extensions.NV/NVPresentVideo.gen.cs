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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_present_video")]
    public unsafe partial class NVPresentVideo : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_present_video";
        [NativeApi(EntryPoint = "glGetVideoivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideouivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVideouivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVideoi64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetVideoi64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetVideoui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVideoui64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glPresentFrameDualFillNV", Convention = CallingConvention.Winapi)]
        public partial void PresentFrameDualFill([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong minPresentTime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint beginPresentTimeId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint presentDurationId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill2, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target3, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill3);

        [NativeApi(EntryPoint = "glPresentFrameKeyedNV", Convention = CallingConvention.Winapi)]
        public partial void PresentFrameKeye([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong minPresentTime, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint beginPresentTimeId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint presentDurationId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint key0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fill1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint key1);

        public unsafe int GetVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetVideo(video_slot, pname, out int silkRet);
            return silkRet;
        }

        public NVPresentVideo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

