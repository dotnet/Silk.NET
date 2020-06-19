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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_texture_storage_multisample_2d_array")]
    public abstract unsafe partial class OesTextureStorageMultisample2dArray : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_texture_storage_multisample_2d_array";
        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] OES target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] OES internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        [NativeApi(EntryPoint = "glTexStorage3DMultisampleOES")]
        public abstract void TexStorage3DMultisample([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public OesTextureStorageMultisample2dArray(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

