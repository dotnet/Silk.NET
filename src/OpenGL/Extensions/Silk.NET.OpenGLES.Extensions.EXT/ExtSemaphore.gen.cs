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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_semaphore")]
    public unsafe partial class ExtSemaphore : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_semaphore";
        [NativeApi(EntryPoint = "glDeleteSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* semaphores);

        [NativeApi(EntryPoint = "glGenSemaphoresEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenSemaphores([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* semaphores);

        [NativeApi(EntryPoint = "glGetSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetSemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetUnsignedBytevEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glGetUnsignedBytei_vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetUnsignedByte([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* data);

        [NativeApi(EntryPoint = "glIsSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore);

        [NativeApi(EntryPoint = "glSemaphoreParameterui64vEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SemaphoreParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* @params);

        [NativeApi(EntryPoint = "glSignalSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SignalSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* dstLayouts);

        [NativeApi(EntryPoint = "glWaitSemaphoreEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void WaitSemaphore([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint semaphore, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numBufferBarriers, [Count(Computed = "numBufferBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* buffers, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numTextureBarriers, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* textures, [Count(Computed = "numTextureBarriers"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* srcLayouts);

        public ExtSemaphore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

