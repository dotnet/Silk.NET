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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_internalformat_query")]
    public unsafe partial class ArbInternalformatQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_internalformat_query";
        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public ArbInternalformatQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

