// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_igloo_interface")]
    public unsafe partial class SgixIglooInterface : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_igloo_interface";
        [NativeApi(EntryPoint = "glIglooInterfaceSGIX")]
        public unsafe partial void IglooInterface([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] void* @params);

        [NativeApi(EntryPoint = "glIglooInterfaceSGIX")]
        public partial void IglooInterface<T0>([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref T0 @params) where T0 : unmanaged;

        public SgixIglooInterface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

