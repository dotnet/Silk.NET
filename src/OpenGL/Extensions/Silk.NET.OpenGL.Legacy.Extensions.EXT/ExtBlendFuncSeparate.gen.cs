// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_func_separate")]
    public unsafe partial class ExtBlendFuncSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_separate";
        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] EXT sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] EXT dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] EXT sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT")]
        public partial void BlendFuncSeparate([Flow(FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(FlowDirection.In)] BlendingFactor dfactorAlpha);

        public ExtBlendFuncSeparate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

