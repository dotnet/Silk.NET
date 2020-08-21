// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_blend_func_extended")]
    public unsafe partial class ExtBlendFuncExtended : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_blend_func_extended";
        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public unsafe partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationEXT")]
        public partial void BindFragDataLocation([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint color, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public unsafe partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glBindFragDataLocationIndexedEXT")]
        public partial void BindFragDataLocationIndexed([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint colorNumber, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public unsafe partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetFragDataIndexEXT")]
        public partial int GetFragDataIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] EXT programInterface, [Flow(FlowDirection.In)] string name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public unsafe partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] byte* name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Count(Computed = "name"), Flow(FlowDirection.In)] in byte name);

        [NativeApi(EntryPoint = "glGetProgramResourceLocationIndexEXT")]
        public partial int GetProgramResourceLocationIndex([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] ProgramInterface programInterface, [Flow(FlowDirection.In)] string name);

        public ExtBlendFuncExtended(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

