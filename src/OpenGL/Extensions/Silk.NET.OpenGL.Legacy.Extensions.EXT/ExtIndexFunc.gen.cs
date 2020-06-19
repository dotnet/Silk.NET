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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_index_func")]
    public abstract unsafe partial class ExtIndexFunc : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_index_func";
        [NativeApi(EntryPoint = "glIndexFuncEXT")]
        public abstract void IndexFunc([Flow(FlowDirection.In)] EXT func, [Flow(FlowDirection.In)] float @ref);

        [NativeApi(EntryPoint = "glIndexFuncEXT")]
        public abstract void IndexFunc([Flow(FlowDirection.In)] IndexFunctionEXT func, [Flow(FlowDirection.In)] float @ref);

        public ExtIndexFunc(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

