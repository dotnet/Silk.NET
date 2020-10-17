// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_tessellation_shader")]
    public unsafe partial class ArbTessellationShader : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_tessellation_shader";
        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameteri")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public unsafe partial void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public partial void PatchParameter([Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public unsafe partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* values);

        [NativeApi(EntryPoint = "glPatchParameterfv")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float values);

        public ArbTessellationShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

