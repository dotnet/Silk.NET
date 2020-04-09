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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_igloo_interface")]
    public abstract unsafe partial class SgixIglooInterface : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIglooInterfaceSGIX")]
        public abstract unsafe void IglooInterface([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] void* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIglooInterfaceSGIX")]
        public abstract void IglooInterface<T0>([Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref T0 @params) where T0 : unmanaged;

        public SgixIglooInterface(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

