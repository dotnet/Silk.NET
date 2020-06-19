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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_element_array")]
    public abstract unsafe partial class AppleElementArray : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_element_array";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE")]
        public abstract void DrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE")]
        public abstract void DrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type.
        /// </param>
        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public abstract unsafe void ElementPointer([Flow(FlowDirection.In)] APPLE type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type.
        /// </param>
        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public abstract void ElementPointer<T0>([Flow(FlowDirection.In)] APPLE type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public abstract unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public abstract void MultiDrawElementArray([Flow(FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<uint> count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public abstract unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public abstract void MultiDrawRangeElementArray([Flow(FlowDirection.In)] APPLE mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<uint> count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE")]
        public abstract void DrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE")]
        public abstract void DrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type.
        /// </param>
        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public abstract unsafe void ElementPointer([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type.
        /// </param>
        [NativeApi(EntryPoint = "glElementPointerAPPLE")]
        public abstract void ElementPointer<T0>([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public abstract unsafe void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE")]
        public abstract void MultiDrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<uint> count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public abstract unsafe void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="end">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// This parameter's element count is taken from primcount.
        /// </param>
        /// <param name="primcount">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE")]
        public abstract void MultiDrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<int> first, [Count(Parameter = "primcount"), Flow(FlowDirection.In)] Span<uint> count, [Flow(FlowDirection.In)] uint primcount);

        public AppleElementArray(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

