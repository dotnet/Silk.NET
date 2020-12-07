// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_object_purgeable")]
    public unsafe partial class AppleObjectPurgeable : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_object_purgeable";
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public unsafe partial void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE")]
        public partial void GetObjectParameter([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glObjectPurgeableAPPLE")]
        public partial APPLE ObjectPurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        [NativeApi(EntryPoint = "glObjectUnpurgeableAPPLE")]
        public partial APPLE ObjectUnpurgeable([Flow(FlowDirection.In)] APPLE objectType, [Flow(FlowDirection.In)] uint name, [Flow(FlowDirection.In)] APPLE option);

        public AppleObjectPurgeable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

