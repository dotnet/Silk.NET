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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_map_texture")]
    public unsafe partial class IntelMapTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_map_texture";
        [NativeApi(EntryPoint = "glMapTexture2DINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] INTEL* layout);

        [NativeApi(EntryPoint = "glMapTexture2DINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out INTEL layout);

        [NativeApi(EntryPoint = "glMapTexture2DINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] INTEL* layout);

        [NativeApi(EntryPoint = "glMapTexture2DINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void* MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out INTEL layout);

        [NativeApi(EntryPoint = "glSyncTextureINTEL", Convention = CallingConvention.Winapi)]
        public partial void SyncTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glUnmapTexture2DINTEL", Convention = CallingConvention.Winapi)]
        public partial void UnmapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        public unsafe INTEL MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride)
        {
            // NonKhrReturnTypeOverloader
            MapTexture2D(texture, level, access, stride, out INTEL silkRet);
            return silkRet;
        }

        public unsafe INTEL MapTexture2D([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int stride)
        {
            // NonKhrReturnTypeOverloader
            MapTexture2D(texture, level, access, out stride, out INTEL silkRet);
            return silkRet;
        }

        public IntelMapTexture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

