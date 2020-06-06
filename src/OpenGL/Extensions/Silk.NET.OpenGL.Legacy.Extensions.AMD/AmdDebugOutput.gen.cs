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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_debug_output")]
    public unsafe partial class AmdDebugOutput : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_debug_output";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageCallback([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] void* userParam)
            => ImplDebugMessageCallback(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="callback">
        /// To be added.
        /// </param>
        /// <param name="userParam">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageCallbackAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageCallback<T0>([Flow(FlowDirection.In), PinObjectAttribute(PinMode.UntilNextCall)] DebugProcAmd callback, [Flow(FlowDirection.Out)] Span<T0> userParam) where T0 : unmanaged
            => ImplDebugMessageCallback<T0>(callback, userParam);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
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
        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageEnable(category, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
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
        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageEnable(category, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] char* buf)
            => ImplDebugMessageInsert(category, severity, id, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// This parameter's element count is taken from length.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] AMD severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] Span<char> buf)
            => ImplDebugMessageInsert(category, severity, id, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="categories">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] char* message)
            => ImplGetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="categories">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// This parameter's element count is taken from bufSize.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Count(Parameter = "bufSize"), Flow(FlowDirection.Out)] Span<char> message)
            => ImplGetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
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
        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] uint* ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageEnable(category, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
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
        [NativeApi(EntryPoint = "glDebugMessageEnableAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageEnable([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] Span<uint> ids, [Flow(FlowDirection.In)] bool enabled)
            => ImplDebugMessageEnable(category, severity, count, ids, enabled);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="category">
        /// To be added.
        /// </param>
        /// <param name="severity">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        /// <param name="buf">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDebugMessageInsertAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DebugMessageInsert([Flow(FlowDirection.In)] AMD category, [Flow(FlowDirection.In)] DebugSeverity severity, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] string buf)
            => ImplDebugMessageInsert(category, severity, id, length, buf);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="categories">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] AMD* categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] uint* lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -5)] out string message)
            => ImplGetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, message);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="bufSize">
        /// To be added.
        /// </param>
        /// <param name="categories">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="severities">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="ids">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="lengths">
        /// To be added.
        /// This parameter's element count is taken from count.
        /// </param>
        /// <param name="message">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glGetDebugMessageLogAMD")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public uint GetDebugMessageLog([Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint bufSize, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<AMD> categories, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> severities, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> ids, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<uint> lengths, [Flow(FlowDirection.Out), Ultz.SuperInvoke.InteropServices.CountAttribute(Ultz.SuperInvoke.InteropServices.CountType.ParameterReference, -5)] out string message)
            => ImplGetDebugMessageLog(count, bufSize, categories, severities, ids, lengths, message);

        public AmdDebugOutput(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

