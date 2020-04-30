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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_object_purgeable")]
    public abstract unsafe partial class AppleObjectPurgeable : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public abstract unsafe void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public abstract void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectPurgeableAPPLE")]
        public abstract APPLE ObjectPurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glObjectUnpurgeableAPPLE")]
        public abstract APPLE ObjectUnpurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        public AppleObjectPurgeable(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

