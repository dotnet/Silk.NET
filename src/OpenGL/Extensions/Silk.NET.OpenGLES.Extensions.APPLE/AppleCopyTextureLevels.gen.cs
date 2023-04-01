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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_copy_texture_levels")]
    public unsafe partial class AppleCopyTextureLevels : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_copy_texture_levels";
        [NativeApi(EntryPoint = "glCopyTextureLevelsAPPLE", Convention = CallingConvention.Winapi)]
        public partial void CopyTextureLevel([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint destinationTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sourceTexture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int sourceBaseLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sourceLevelCount);

        public AppleCopyTextureLevels(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

