// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.EXT
{
    [Extension("EXT_EGL_image_storage")]
    public abstract unsafe partial class ExtEglImageStorage : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT")]
        public abstract unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEGLImageTargetTexStorageEXT")]
        public abstract void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT")]
        public abstract unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] int* attrib_list);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEGLImageTargetTextureStorageEXT")]
        public abstract void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] IntPtr image, [Flow(FlowDirection.In)] Span<int> attrib_list);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        /// <param name="attrib_list">
        /// To be added.
        /// </param>
        public unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTexStorage(target, new IntPtr(image), attrib_list);
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
        /// <param name="attrib_list">
        /// To be added.
        /// </param>
        public unsafe void EglimageTargetTexStorage([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTexStorage(target, new IntPtr(image), attrib_list);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        /// <param name="attrib_list">
        /// To be added.
        /// </param>
        public unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTextureStorage(texture, new IntPtr(image), attrib_list);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="texture">
        /// To be added.
        /// </param>
        /// <param name="image">
        /// To be added.
        /// </param>
        /// <param name="attrib_list">
        /// To be added.
        /// </param>
        public unsafe void EglimageTargetTextureStorage([Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int image, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            EglimageTargetTextureStorage(texture, new IntPtr(image), attrib_list);
        }

        public ExtEglImageStorage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

