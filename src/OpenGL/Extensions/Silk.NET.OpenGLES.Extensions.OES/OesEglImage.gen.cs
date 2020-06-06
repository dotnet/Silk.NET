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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_EGL_image")]
    public unsafe partial class OesEglImage : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_EGL_image";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEGLImageTargetRenderbufferStorageOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EglimageTargetRenderbufferStorage([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image)
            => ImplEglimageTargetRenderbufferStorage(target, image);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEGLImageTargetTexture2DOES")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EglimageTargetTexture2D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] IntPtr image)
            => ImplEglimageTargetTexture2D(target, image);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EglimageTargetRenderbufferStorage([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            EglimageTargetRenderbufferStorage(target, new IntPtr(image));
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EglimageTargetTexture2D([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            EglimageTargetTexture2D(target, new IntPtr(image));
        }

        public OesEglImage(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

