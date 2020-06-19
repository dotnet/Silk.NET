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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_element_array")]
    public abstract unsafe partial class AtiElementArray : NativeExtension<GL>
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
        public abstract void DrawElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawRangeElementArray([Flow(FlowDirection.In)] ATI mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count);

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
        public abstract unsafe void ElementPointer([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] void* pointer);

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
        public abstract void ElementPointer<T0>([Flow(FlowDirection.In)] ATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

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
        public abstract void DrawElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count);

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
        public abstract void DrawRangeElementArray([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count);

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
        [NativeApi(EntryPoint = "glElementPointerATI")]
        public abstract void ElementPointer<T0>([Flow(FlowDirection.In)] ElementPointerTypeATI type, [Count(Computed = "type"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public AtiElementArray(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

