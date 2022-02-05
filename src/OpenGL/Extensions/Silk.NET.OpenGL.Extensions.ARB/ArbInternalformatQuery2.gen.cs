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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_internalformat_query2")]
    public unsafe partial class ArbInternalformatQuery2 : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_internalformat_query2";
        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetInternalformati64v", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out long @params);

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public ArbInternalformatQuery2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

