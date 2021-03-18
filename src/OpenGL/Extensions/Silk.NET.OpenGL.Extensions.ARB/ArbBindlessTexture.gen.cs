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
    [Extension("ARB_bindless_texture")]
    public unsafe partial class ArbBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_bindless_texture";
        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glGetImageHandleARB")]
        public partial ulong GetImageHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] PixelFormat format);

        [NativeApi(EntryPoint = "glGetTextureHandleARB")]
        public partial ulong GetTextureHandle([Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleARB")]
        public partial ulong GetTextureSamplerHandle([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB")]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glIsImageHandleResidentARB")]
        public partial bool IsImageHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glIsTextureHandleResidentARB")]
        public partial bool IsTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentARB")]
        public partial void MakeImageHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleResidentARB")]
        public partial void MakeImageHandleResident([Flow(FlowDirection.In)] ulong handle, [Flow(FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentARB")]
        public partial void MakeTextureHandleNonResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeTextureHandleResidentARB")]
        public partial void MakeTextureHandleResident([Flow(FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64ARB")]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public unsafe partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB")]
        public partial void ProgramUniformHandle([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong values);

        [NativeApi(EntryPoint = "glUniformHandleui64ARB")]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public unsafe partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glUniformHandleui64vARB")]
        public partial void UniformHandle([Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] in ulong value);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64ARB")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB")]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in ulong v);

        public ArbBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

