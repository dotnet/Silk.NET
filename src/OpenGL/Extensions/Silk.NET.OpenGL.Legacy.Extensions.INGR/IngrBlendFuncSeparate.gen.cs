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

namespace Silk.NET.OpenGL.Legacy.Extensions.INGR
{
    [Extension("INGR_blend_func_separate")]
    public unsafe partial class IngrBlendFuncSeparate : NativeExtension<GL>
    {
        public const string ExtensionName = "INGR_blend_func_separate";
        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INGR dfactorAlpha);

        [NativeApi(EntryPoint = "glBlendFuncSeparateINGR", Convention = CallingConvention.Winapi)]
        public partial void BlendFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorRGB, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor sfactorAlpha, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendingFactor dfactorAlpha);

        public IngrBlendFuncSeparate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

