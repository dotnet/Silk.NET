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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_internalformat_query")]
    public unsafe partial class ArbInternalformatQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_internalformat_query";
        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public unsafe partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformativ")]
        public partial void GetInternalformat([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        public ArbInternalformatQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

