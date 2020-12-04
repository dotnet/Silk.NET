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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_multi_draw_indirect")]
    public unsafe partial class ExtMultiDrawIndirect : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_multi_draw_indirect";
        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        public unsafe partial void MultiDrawArraysIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawArraysIndirectEXT")]
        public partial void MultiDrawArraysIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public unsafe partial void MultiDrawElementsIndirect([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] void* indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glMultiDrawElementsIndirectEXT")]
        public partial void MultiDrawElementsIndirect<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] in T0 indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged;

        public ExtMultiDrawIndirect(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

