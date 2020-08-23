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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_blend_func_extended")]
    public unsafe partial class ArbBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_blend_func_extended";
        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public unsafe partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexed")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public unsafe partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataIndex")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        public ArbBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

