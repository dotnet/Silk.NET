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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_fence")]
    public unsafe partial class AppleFence : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_fence";
        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        public unsafe partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* fences);

        [NativeApi(EntryPoint = "glDeleteFencesAPPLE")]
        public partial void DeleteFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint fences);

        [NativeApi(EntryPoint = "glFinishFenceAPPLE")]
        public partial void FinishFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        public partial void FinishObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "glFinishObjectAPPLE")]
        public partial void FinishObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] int name);

        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        public unsafe partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* fences);

        [NativeApi(EntryPoint = "glGenFencesAPPLE")]
        public partial void GenFences([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint fences);

        [NativeApi(EntryPoint = "glIsFenceAPPLE")]
        public partial bool IsFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glSetFenceAPPLE")]
        public partial void SetFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestFenceAPPLE")]
        public partial bool TestFence([Flow(FlowDirection.In)] uint fence);

        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        public partial bool TestObject([Flow(FlowDirection.In)] APPLE @object, [Flow(FlowDirection.In)] uint name);

        [NativeApi(EntryPoint = "glTestObjectAPPLE")]
        public partial bool TestObject([Flow(FlowDirection.In)] ObjectTypeAPPLE @object, [Flow(FlowDirection.In)] uint name);

        public unsafe void DeleteFence([Count(Parameter = "n"), Flow(FlowDirection.In)] uint fences)
        {
            // ArrayParameterOverloader
            DeleteFences(1, &fences);
        }

        public unsafe uint GenFence()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenFences(n, &ret);
            return ret;
        }

        public AppleFence(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

