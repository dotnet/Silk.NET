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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_multi_draw_arrays")]
    public abstract unsafe partial class ExtMultiDrawArrays : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public abstract unsafe void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawArraysEXT")]
        public abstract void MultiDrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public abstract unsafe void MultiDrawElements([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMultiDrawElementsEXT")]
        public abstract unsafe void MultiDrawElements<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] ref T0* indices, [Flow(FlowDirection.In)] uint primcount) where T0 : unmanaged;

        public ExtMultiDrawArrays(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

