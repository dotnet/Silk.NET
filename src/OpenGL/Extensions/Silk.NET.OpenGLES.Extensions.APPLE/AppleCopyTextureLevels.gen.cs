// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_copy_texture_levels")]
    public unsafe partial class AppleCopyTextureLevels : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_copy_texture_levels";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="destinationTexture">
        /// To be added.
        /// </param>
        /// <param name="sourceTexture">
        /// To be added.
        /// </param>
        /// <param name="sourceBaseLevel">
        /// To be added.
        /// </param>
        /// <param name="sourceLevelCount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glCopyTextureLevelsAPPLE")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CopyTextureLevel([Flow(FlowDirection.In)] uint destinationTexture, [Flow(FlowDirection.In)] uint sourceTexture, [Flow(FlowDirection.In)] int sourceBaseLevel, [Flow(FlowDirection.In)] uint sourceLevelCount)
            => ImplCopyTextureLevel(destinationTexture, sourceTexture, sourceBaseLevel, sourceLevelCount);

        public AppleCopyTextureLevels(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

