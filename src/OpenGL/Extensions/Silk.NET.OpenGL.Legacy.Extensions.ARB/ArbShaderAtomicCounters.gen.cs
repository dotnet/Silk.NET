// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_shader_atomic_counters")]
    public unsafe partial class ArbShaderAtomicCounters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_atomic_counters";
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv")]
        public partial void GetActiveAtomicCounterBuffer([Flow(FlowDirection.In)] uint program, [Flow(FlowDirection.In)] uint bufferIndex, [Flow(FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public ArbShaderAtomicCounters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

