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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_blend_func_separate")]
    public unsafe partial class ExtBlendFuncSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_separate";
        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateEXT", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        public ExtBlendFuncSeparate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

