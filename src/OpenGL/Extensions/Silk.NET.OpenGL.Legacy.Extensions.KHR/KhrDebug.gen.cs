// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.KHR
{
    [Extension("KHR_debug")]
    public abstract unsafe partial class KhrDebug : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_debug";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract unsafe void DebugMessageCallback([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] void* userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallback")]
        public abstract void DebugMessageCallback<T0>([Flow(FlowDirection.In), Ultz.SuperInvoke.InteropServices.PinObjectAttribute(Ultz.SuperInvoke.InteropServices.PinMode.UntilNextCall)] DebugProc callback, [Flow(FlowDirection.In)] Span<T0> userParam) where T0 : unmanaged;

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
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

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
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

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
        /// This parameter's element count is computed from buf and length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract unsafe void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] char* buf);

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
        /// This parameter's element count is computed from buf and length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] KHR type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] KHR severity, [Flow(FlowDirection.In)] uint length, [Count(Computed = "buf, length"), Flow(FlowDirection.In)] ref char buf);

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
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] KHR* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* messageLog);

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
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<KHR> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<KHR> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<KHR> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> label) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer([Flow(FlowDirection.In)] KHR pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer<T0>([Flow(FlowDirection.In)] KHR pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract unsafe void ObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] KHR identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] char* label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// This parameter's element count is computed from label and length.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Count(Computed = "label, length"), Flow(FlowDirection.In)] ref char label) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glPopDebugGroup")]
        public abstract void PopDebugGroup();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is computed from message and length.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract unsafe void PushDebugGroup([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] char* message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is computed from message and length.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] KHR source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Computed = "message, length"), Flow(FlowDirection.In)] ref char message);

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
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract unsafe void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled);

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
        [NativeApi(EntryPoint = "glDebugMessageControl")]
        public abstract void DebugMessageControl([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled);

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
        [NativeApi(EntryPoint = "glDebugMessageInsert")]
        public abstract void DebugMessageInsert([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] DebugType type, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf);

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
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSource* sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugType* types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] DebugSeverity* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

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
        [NativeApi(EntryPoint = "glGetDebugMessageLog")]
        public abstract uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSource> sources, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugType> types, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<DebugSeverity> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -6)] out string messageLog);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract unsafe void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectLabel")]
        public abstract void GetObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract unsafe void GetObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glGetObjectPtrLabel")]
        public abstract void GetObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint bufSize, [Count(Count = 1), Flow(FlowDirection.Out)] out uint length, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -2)] out string label) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        [NativeApi(EntryPoint = "glGetPointerv")]
        public abstract unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="identifier">
        /// To be added.
        /// </param>
        /// <param name="name">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectLabel")]
        public abstract void ObjectLabel([Flow(FlowDirection.In)] ObjectIdentifier identifier, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract unsafe void ObjectPtrLabel([Flow(FlowDirection.In)] void* ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="ptr">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="label">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glObjectPtrLabel")]
        public abstract void ObjectPtrLabel<T0>([Flow(FlowDirection.In)] Span<T0> ptr, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string label) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="source">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glPushDebugGroup")]
        public abstract void PushDebugGroup([Flow(FlowDirection.In)] DebugSource source, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] KHR pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Obsolete("Deprecated in version ")]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GetPointervPName pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public KhrDebug(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

