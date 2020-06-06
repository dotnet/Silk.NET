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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_tessellation_shader")]
    public unsafe partial class ExtTessellationShader : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_tessellation_shader";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPatchParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PatchParameter([Flow(FlowDirection.In)] EXT pname, [Flow(FlowDirection.In)] int value)
            => ImplPatchParameter(pname, value);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="value">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPatchParameteriEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void PatchParameter([Flow(FlowDirection.In)] PatchParameterName pname, [Flow(FlowDirection.In)] int value)
            => ImplPatchParameter(pname, value);

        public ExtTessellationShader(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

