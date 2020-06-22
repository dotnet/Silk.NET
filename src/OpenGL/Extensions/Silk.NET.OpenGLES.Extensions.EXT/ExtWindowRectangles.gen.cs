// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_window_rectangles")]
    public abstract unsafe partial class ExtWindowRectangles : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_window_rectangles";
        [NativeApi(EntryPoint = "glWindowRectanglesEXT")]
        public abstract unsafe void WindowRectangles([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* box);

        [NativeApi(EntryPoint = "glWindowRectanglesEXT")]
        public abstract void WindowRectangles([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int box);

        public ExtWindowRectangles(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

