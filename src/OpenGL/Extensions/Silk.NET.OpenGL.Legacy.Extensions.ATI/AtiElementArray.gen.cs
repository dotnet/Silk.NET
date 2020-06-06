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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_element_array")]
    public unsafe partial class AtiElementArray : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_element_array";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementArrayATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint count)
            => ImplDrawElementArray(mode, count);

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
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count)
            => ImplDrawRangeElementArray(mode, start, end, count);

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
        [NativeApi(EntryPoint = "glElementPointerATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ElementPointer([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer)
            => ImplElementPointer(type, pointer);

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
        [NativeApi(EntryPoint = "glElementPointerATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ElementPointer<T0>([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplElementPointer<T0>(type, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawElementArrayATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count)
            => ImplDrawElementArray(mode, count);

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
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawRangeElementArrayATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count)
            => ImplDrawRangeElementArray(mode, start, end, count);

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
        [NativeApi(EntryPoint = "glElementPointerATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ElementPointer([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer)
            => ImplElementPointer(type, pointer);

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
        [NativeApi(EntryPoint = "glElementPointerATI")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ElementPointer<T0>([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplElementPointer<T0>(type, pointer);

        public AtiElementArray(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

