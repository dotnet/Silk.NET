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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_element_array")]
    public unsafe partial class AppleElementArray : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_element_array";
        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void DrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glElementPointerAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void ElementPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE type, [Count(Computed = "type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glElementPointerAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void ElementPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        [NativeApi(EntryPoint = "glMultiDrawRangeElementArrayAPPLE", Convention = CallingConvention.Winapi)]
        public partial void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint primcount);

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawElementArray(mode, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, first, in count.GetPinnableReference(), (uint) count.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), count, (uint) first.Length);
        }

        public unsafe void MultiDrawRangeElementArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint end, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> first, [Count(Parameter = "primcount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> count)
        {
            // ImplicitCountSpanOverloader
            MultiDrawRangeElementArray(mode, start, end, in first.GetPinnableReference(), in count.GetPinnableReference(), (uint) count.Length);
        }

        public AppleElementArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

