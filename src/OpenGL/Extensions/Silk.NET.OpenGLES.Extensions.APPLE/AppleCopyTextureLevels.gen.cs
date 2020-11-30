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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_copy_texture_levels")]
    public unsafe partial class AppleCopyTextureLevels : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_copy_texture_levels";
        [NativeApi(EntryPoint = "glCopyTextureLevelsAPPLE")]
        public partial void CopyTextureLevel([Flow(FlowDirection.In)] uint destinationTexture, [Flow(FlowDirection.In)] uint sourceTexture, [Flow(FlowDirection.In)] int sourceBaseLevel, [Flow(FlowDirection.In)] uint sourceLevelCount);

        public AppleCopyTextureLevels(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

