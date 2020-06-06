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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_draw_buffers2")]
    public unsafe partial class ExtDrawBuffers2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers2";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="r">
        /// To be added.
        /// </param>
        /// <param name="g">
        /// To be added.
        /// </param>
        /// <param name="b">
        /// To be added.
        /// </param>
        /// <param name="a">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorMaskIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a)
            => ImplColorMaskIndexed(index, r, g, b, a);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplDisableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplEnableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data)
            => ImplGetIntegerIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data)
            => ImplGetIntegerIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabledIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplDisableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplEnableIndexed(target, index);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// This parameter's element count is computed from target.
        /// </param>
        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data)
            => ImplGetBooleanIndexed(target, index, data);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index)
            => ImplIsEnabledIndexed(target, index);

        public ExtDrawBuffers2(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

