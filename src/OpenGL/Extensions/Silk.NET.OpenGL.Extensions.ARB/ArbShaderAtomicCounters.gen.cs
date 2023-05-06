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
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_shader_atomic_counters")]
    public unsafe partial class ArbShaderAtomicCounters : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_atomic_counters";
        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetActiveAtomicCounterBufferiv", Convention = CallingConvention.Winapi)]
        public partial void GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AtomicCounterBufferPName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        public unsafe int GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveAtomicCounterBuffer(program, bufferIndex, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetActiveAtomicCounterBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint program, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint bufferIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AtomicCounterBufferPName pname)
        {
            // NonKhrReturnTypeOverloader
            GetActiveAtomicCounterBuffer(program, bufferIndex, pname, out int silkRet);
            return silkRet;
        }

        public ArbShaderAtomicCounters(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

