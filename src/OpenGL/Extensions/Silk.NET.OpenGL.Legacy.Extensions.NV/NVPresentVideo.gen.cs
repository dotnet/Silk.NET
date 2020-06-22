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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_present_video")]
    public abstract unsafe partial class NVPresentVideo : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_present_video";
        [NativeApi(EntryPoint = "glGetVideoivNV")]
        public abstract unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoivNV")]
        public abstract void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideouivNV")]
        public abstract unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVideouivNV")]
        public abstract void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glGetVideoi64vNV")]
        public abstract unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetVideoi64vNV")]
        public abstract void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetVideoui64vNV")]
        public abstract unsafe void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVideoui64vNV")]
        public abstract void GetVideo([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glPresentFrameDualFillNV")]
        public abstract void PresentFrameDualFill([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] ulong minPresentTime, [Flow(FlowDirection.In)] uint beginPresentTimeId, [Flow(FlowDirection.In)] uint presentDurationId, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] NV target0, [Flow(FlowDirection.In)] uint fill0, [Flow(FlowDirection.In)] NV target1, [Flow(FlowDirection.In)] uint fill1, [Flow(FlowDirection.In)] NV target2, [Flow(FlowDirection.In)] uint fill2, [Flow(FlowDirection.In)] NV target3, [Flow(FlowDirection.In)] uint fill3);

        [NativeApi(EntryPoint = "glPresentFrameKeyedNV")]
        public abstract void PresentFrameKeye([Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] ulong minPresentTime, [Flow(FlowDirection.In)] uint beginPresentTimeId, [Flow(FlowDirection.In)] uint presentDurationId, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] NV target0, [Flow(FlowDirection.In)] uint fill0, [Flow(FlowDirection.In)] uint key0, [Flow(FlowDirection.In)] NV target1, [Flow(FlowDirection.In)] uint fill1, [Flow(FlowDirection.In)] uint key1);

        public NVPresentVideo(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

