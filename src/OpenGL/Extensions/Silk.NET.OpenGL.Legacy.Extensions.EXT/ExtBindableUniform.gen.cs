// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_bindable_uniform")]
    public unsafe partial class ExtBindableUniform : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_bindable_uniform";
        [NativeApi(EntryPoint = "glGetUniformBufferSizeEXT")]
        public partial int GetUniformBufferSize([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location);

        [NativeApi(EntryPoint = "glGetUniformOffsetEXT")]
        public partial IntPtr GetUniformOffset([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location);

        [NativeApi(EntryPoint = "glUniformBufferEXT")]
        public partial void UniformBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] int location, [Flow(FlowDirection.In)] uint buffer);

        public ExtBindableUniform(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

