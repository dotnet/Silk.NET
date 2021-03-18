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
    [Extension("EXT_shader_pixel_local_storage2")]
    public unsafe partial class ExtShaderPixelLocalStorage2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_shader_pixel_local_storage2";
        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public unsafe partial void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* values);

        [NativeApi(EntryPoint = "glClearPixelLocalStorageuiEXT")]
        public partial void ClearPixelLocalStorage([Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint values);

        [NativeApi(EntryPoint = "glFramebufferPixelLocalStorageSizeEXT")]
        public partial void FramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target, [Flow(FlowDirection.In)] uint size);

        [NativeApi(EntryPoint = "glGetFramebufferPixelLocalStorageSizeEXT")]
        public partial uint GetFramebufferPixelLocalStorageSize([Flow(FlowDirection.In)] uint target);

        public ExtShaderPixelLocalStorage2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

