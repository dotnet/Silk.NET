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
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ", Convention = CallingConvention.Winapi)]
        public partial void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname)
        {
            const uint count = 1;
            // ReturnTypeOverloader
            int ret = default;
            GetInternalformat(target, internalformat, pname, count, &ret);
            return ret;
        }

        public unsafe void GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // ImplicitCountSpanOverloader
            GetInternalformat(target, internalformat, pname, (uint) @params.Length, out @params.GetPinnableReference());
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public unsafe int GetInternalformat([Flow(Silk.NET.Core.Native.FlowDirection.In)] TextureTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormat internalformat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InternalFormatPName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // NonKhrReturnTypeOverloader
            GetInternalformat(target, internalformat, pname, count, out int silkRet);
            return silkRet;
        }

        public ArbInternalformatQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

