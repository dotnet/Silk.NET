// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_internalformat_sample_query")]
    public unsafe partial class NVInternalformatSampleQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_internalformat_sample_query";
        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] NV internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public unsafe partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetInternalformatSampleivNV")]
        public partial void GetInternalformatSample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormatPName pname, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.Out)] out int @params);

        public NVInternalformatSampleQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

