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
    [Extension("ARB_debug_output")]
    public unsafe partial class ArbDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_debug_output";
        [NativeApi(EntryPoint = "glDebugMessageCallbackARB")]
        public unsafe partial void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(FlowDirection.In)] void* userParam);

        [NativeApi(EntryPoint = "glDebugMessageCallbackARB")]
        public partial void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(FlowDirection.In)] ref T0 userParam) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        public unsafe partial void DebugMessageInsert([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] byte* buf);

        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<byte> buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] byte* messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<byte> messageLog);

        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        public unsafe partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        public partial void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        public partial void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        public unsafe partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        public partial uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] out string messageLog);

        public ArbDebugOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

