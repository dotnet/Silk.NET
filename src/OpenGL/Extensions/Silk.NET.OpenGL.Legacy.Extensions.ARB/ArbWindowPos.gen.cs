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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_window_pos")]
    public abstract unsafe partial class ArbWindowPos : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2dARB")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2dvARB")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2dvARB")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2fARB")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2fvARB")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2fvARB")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2iARB")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2ivARB")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2ivARB")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2sARB")]
        public abstract void WindowPos2([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2svARB")]
        public abstract unsafe void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos2svARB")]
        public abstract void WindowPos2([Count(Count = 2), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3dARB")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3dvARB")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3dvARB")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3fARB")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3fvARB")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3fvARB")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3iARB")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3ivARB")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3ivARB")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3sARB")]
        public abstract void WindowPos3([Flow(FlowDirection.In)] short x, [Flow(FlowDirection.In)] short y, [Flow(FlowDirection.In)] short z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3svARB")]
        public abstract unsafe void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glWindowPos3svARB")]
        public abstract void WindowPos3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        public ArbWindowPos(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

