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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_present_video")]
    public unsafe partial class NVPresentVideo : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_present_video";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideouivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideouivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoi64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoi64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoui64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoui64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params)
            => ImplGetVideo(video_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="minPresentTime">
        /// To be added.
        /// </param>
        /// <param name="beginPresentTimeId">
        /// To be added.
        /// </param>
        /// <param name="presentDurationId">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="target0">
        /// To be added.
        /// </param>
        /// <param name="fill0">
        /// To be added.
        /// </param>
        /// <param name="target1">
        /// To be added.
        /// </param>
        /// <param name="fill1">
        /// To be added.
        /// </param>
        /// <param name="target2">
        /// To be added.
        /// </param>
        /// <param name="fill2">
        /// To be added.
        /// </param>
        /// <param name="target3">
        /// To be added.
        /// </param>
        /// <param name="fill3">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPresentFrameDualFillNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PresentFrameDualFill([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] ulong minPresentTime, [Flow(FlowDirection.In)] uint beginPresentTimeId, [Flow(FlowDirection.In)] uint presentDurationId, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] NV target0, [Flow(FlowDirection.In)] uint fill0, [Flow(FlowDirection.In)] NV target1, [Flow(FlowDirection.In)] uint fill1, [Flow(FlowDirection.In)] NV target2, [Flow(FlowDirection.In)] uint fill2, [Flow(FlowDirection.In)] NV target3, [Flow(FlowDirection.In)] uint fill3)
            => ImplPresentFrameDualFill(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, target1, fill1, target2, fill2, target3, fill3);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_slot">
        /// To be added.
        /// </param>
        /// <param name="minPresentTime">
        /// To be added.
        /// </param>
        /// <param name="beginPresentTimeId">
        /// To be added.
        /// </param>
        /// <param name="presentDurationId">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="target0">
        /// To be added.
        /// </param>
        /// <param name="fill0">
        /// To be added.
        /// </param>
        /// <param name="key0">
        /// To be added.
        /// </param>
        /// <param name="target1">
        /// To be added.
        /// </param>
        /// <param name="fill1">
        /// To be added.
        /// </param>
        /// <param name="key1">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPresentFrameKeyedNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PresentFrameKeye([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] ulong minPresentTime, [Flow(FlowDirection.In)] uint beginPresentTimeId, [Flow(FlowDirection.In)] uint presentDurationId, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] NV target0, [Flow(FlowDirection.In)] uint fill0, [Flow(FlowDirection.In)] uint key0, [Flow(FlowDirection.In)] NV target1, [Flow(FlowDirection.In)] uint fill1, [Flow(FlowDirection.In)] uint key1)
            => ImplPresentFrameKeye(video_slot, minPresentTime, beginPresentTimeId, presentDurationId, type, target0, fill0, key0, target1, fill1, key1);

        public NVPresentVideo(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

