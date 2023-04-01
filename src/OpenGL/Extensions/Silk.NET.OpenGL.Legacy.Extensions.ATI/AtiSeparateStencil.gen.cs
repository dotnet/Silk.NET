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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_separate_stencil")]
    public unsafe partial class AtiSeparateStencil : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_separate_stencil";
        [NativeApi(EntryPoint = "glStencilFuncSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI frontfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI backfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI frontfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilFunction backfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilFunction frontfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI backfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilFuncSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilFuncSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilFunction frontfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilFunction backfunc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int @ref, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI dppass);

        [NativeApi(EntryPoint = "glStencilOpSeparateATI", Convention = CallingConvention.Winapi)]
        public partial void StencilOpSeparate([Flow(Silk.NET.Core.Native.FlowDirection.In)] TriangleFace face, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp sfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dpfail, [Flow(Silk.NET.Core.Native.FlowDirection.In)] StencilOp dppass);

        public AtiSeparateStencil(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

