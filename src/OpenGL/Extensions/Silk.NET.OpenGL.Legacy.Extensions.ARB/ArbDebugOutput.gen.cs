// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_debug_output")]
    public unsafe partial class ArbDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_debug_output";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// This parameter's element count is computed from callback.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallbackARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(FlowDirection.In)] void* userParam)
            => ImplDebugMessageCallback(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// This parameter's element count is computed from callback.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallbackARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcArb callback, [Count(Computed = "callback"), Flow(FlowDirection.In)] ref T0 userParam) where T0 : unmanaged
            => ImplDebugMessageCallback<T0>(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageControl([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageControl([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageInsert([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] char* buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] ARB source, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB severity, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<char> buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] ARB* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<ARB> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="enabled">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageControlARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageControl(source, type, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf)
            => ImplDebugMessageInsert(source, type, id, severity, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="sources">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="types">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="messageLog">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogARB")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog)
            => ImplGetDebugMessageLog(count, bufSize, sources, types, ids, severities, lengths, messageLog);

        public ArbDebugOutput(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

