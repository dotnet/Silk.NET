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
    [Extension("ARB_bindless_texture")]
    public unsafe partial class ArbBindlessTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_bindless_texture";
        [NativeApi(EntryPoint = "glGetImageHandleARB", Convention = CallingConvention.Winapi)]
        public partial ulong GetImageHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool layered, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glGetTextureHandleARB", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glGetTextureSamplerHandleARB", Convention = CallingConvention.Winapi)]
        public partial ulong GetTextureSamplerHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sampler);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glIsImageHandleResidentARB", Convention = CallingConvention.Winapi)]
        public partial bool IsImageHandleResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glIsTextureHandleResidentARB", Convention = CallingConvention.Winapi)]
        public partial bool IsTextureHandleResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleNonResidentARB", Convention = CallingConvention.Winapi)]
        public partial void MakeImageHandleNonResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeImageHandleResidentARB", Convention = CallingConvention.Winapi)]
        public partial void MakeImageHandleResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB access);

        [NativeApi(EntryPoint = "glMakeTextureHandleNonResidentARB", Convention = CallingConvention.Winapi)]
        public partial void MakeTextureHandleNonResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glMakeTextureHandleResidentARB", Convention = CallingConvention.Winapi)]
        public partial void MakeTextureHandleResident([Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong handle);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64ARB", Convention = CallingConvention.Winapi)]
        public partial void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glProgramUniformHandleui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void ProgramUniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* values);

        [NativeApi(EntryPoint = "glUniformHandleui64ARB", Convention = CallingConvention.Winapi)]
        public partial void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong value);

        [NativeApi(EntryPoint = "glUniformHandleui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void UniformHandle([Flow(Silk.NET.Core.Native.FlowDirection.In)] int location, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* value);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64ARB", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* v);

        public ArbBindlessTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

