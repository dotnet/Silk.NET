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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_tessellation_shader")]
    public unsafe partial class ExtTessellationShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_tessellation_shader";
        [NativeApi(EntryPoint = "glPatchParameteriEXT")]
        public partial void PatchParameter([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int value);

        [NativeApi(EntryPoint = "glPatchParameteriEXT")]
        public partial void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value);

        public ExtTessellationShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

