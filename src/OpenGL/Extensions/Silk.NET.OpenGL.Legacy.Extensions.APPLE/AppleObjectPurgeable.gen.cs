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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_object_purgeable")]
    public abstract unsafe partial class AppleObjectPurgeable : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_object_purgeable";
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public abstract unsafe void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public abstract void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glObjectPurgeableAPPLE")]
        public abstract APPLE ObjectPurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        [NativeApi(EntryPoint = "glObjectUnpurgeableAPPLE")]
        public abstract APPLE ObjectUnpurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        public AppleObjectPurgeable(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

