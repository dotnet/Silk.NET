// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_window_rectangles")]
    public unsafe partial class ExtWindowRectangles : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_window_rectangles";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="box">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        [NativeApi(EntryPoint = "glWindowRectanglesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void WindowRectangles([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* box)
            => ImplWindowRectangles(mode, count, box);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="box">
        /// To be added.
        /// This parameter's element count is computed from count.
        /// </param>
        [NativeApi(EntryPoint = "glWindowRectanglesEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void WindowRectangles([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int box)
            => ImplWindowRectangles(mode, count, box);

        public ExtWindowRectangles(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

