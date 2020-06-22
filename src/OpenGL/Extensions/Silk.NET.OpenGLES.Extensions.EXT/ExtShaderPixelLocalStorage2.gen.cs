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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_shader_pixel_local_storage2")]
    public abstract unsafe partial class ExtShaderPixelLocalStorage2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_pixel_local_storage2";
        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public abstract unsafe void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* values);

        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public abstract void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> values);

        [NativeApi(EntryPoint = "glFramebufferPixelLocalStorageSizeEXT")]
        public abstract void FramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT")]
        public abstract uint GetFramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target);

        public ExtShaderPixelLocalStorage2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

