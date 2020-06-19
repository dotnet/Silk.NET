// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_buffers_indexed")]
    public abstract unsafe partial class ExtDrawBuffersIndexed : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers_indexed";
        [NativeApi(EntryPoint = "glBlendEquationiEXT")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT modeRGB, [Flow(FlowDirection.In)] EXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciEXT")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT src, [Flow(FlowDirection.In)] EXT dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] EXT srcRGB, [Flow(FlowDirection.In)] EXT dstRGB, [Flow(FlowDirection.In)] EXT srcAlpha, [Flow(FlowDirection.In)] EXT dstAlpha);

        [NativeApi(EntryPoint = "glColorMaskiEXT")]
        public abstract void ColorMask([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableiEXT")]
        public abstract void Disable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT")]
        public abstract void Enable([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glBlendEquationiEXT")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        [NativeApi(EntryPoint = "glBlendEquationSeparateiEXT")]
        public abstract void BlendEquationSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendEquationModeEXT modeRGB, [Flow(FlowDirection.In)] BlendEquationModeEXT modeAlpha);

        [NativeApi(EntryPoint = "glBlendFunciEXT")]
        public abstract void BlendFunc([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor src, [Flow(FlowDirection.In)] BlendingFactor dst);

        [NativeApi(EntryPoint = "glBlendFuncSeparateiEXT")]
        public abstract void BlendFuncSeparate([Flow(FlowDirection.In)] uint buf, [Flow(FlowDirection.In)] BlendingFactor srcRGB, [Flow(FlowDirection.In)] BlendingFactor dstRGB, [Flow(FlowDirection.In)] BlendingFactor srcAlpha, [Flow(FlowDirection.In)] BlendingFactor dstAlpha);

        [NativeApi(EntryPoint = "glDisableiEXT")]
        public abstract void Disable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableiEXT")]
        public abstract void Enable([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnablediEXT")]
        public abstract bool IsEnabled([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public ExtDrawBuffersIndexed(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

