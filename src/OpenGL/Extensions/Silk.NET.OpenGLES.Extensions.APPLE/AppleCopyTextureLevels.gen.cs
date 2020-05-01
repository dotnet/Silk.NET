// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    [Extension("APPLE_copy_texture_levels")]
    public abstract unsafe partial class AppleCopyTextureLevels : NativeExtension<GL>
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
        public abstract void CopyTextureLevel([Flow(FlowDirection.In)] uint destinationTexture, [Flow(FlowDirection.In)] uint sourceTexture, [Flow(FlowDirection.In)] int sourceBaseLevel, [Flow(FlowDirection.In)] uint sourceLevelCount);

        public AppleCopyTextureLevels(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

