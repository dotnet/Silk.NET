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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_triangle_list")]
    public unsafe partial class SunTriangleList : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_triangle_list";
        [NativeApi(EntryPoint = "glReplacementCodeuiSUN")]
        public partial void ReplacementCode([Flow(FlowDirection.In)] uint code);

        [NativeApi(EntryPoint = "glReplacementCodeusSUN")]
        public partial void ReplacementCode([Flow(FlowDirection.In)] ushort code);

        [NativeApi(EntryPoint = "glReplacementCodeubSUN")]
        public partial void ReplacementCode([Flow(FlowDirection.In)] byte code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] uint* code);

        [NativeApi(EntryPoint = "glReplacementCodeuivSUN")]
        public partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] in uint code);

        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] ushort* code);

        [NativeApi(EntryPoint = "glReplacementCodeusvSUN")]
        public partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] in ushort code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public unsafe partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] byte* code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public partial void ReplacementCode([Count(Count = 0), Flow(FlowDirection.In)] in byte code);

        [NativeApi(EntryPoint = "glReplacementCodeubvSUN")]
        public partial void ReplacementCode([Flow(FlowDirection.In)] string code);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public unsafe partial void ReplacementCodePointer([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public unsafe partial void ReplacementCodePointer([Flow(FlowDirection.In)] SUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in void* pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public unsafe partial void ReplacementCodePointer([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer);

        [NativeApi(EntryPoint = "glReplacementCodePointerSUN")]
        public unsafe partial void ReplacementCodePointer([Flow(FlowDirection.In)] ReplacementCodeTypeSUN type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in void* pointer);

        public SunTriangleList(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

