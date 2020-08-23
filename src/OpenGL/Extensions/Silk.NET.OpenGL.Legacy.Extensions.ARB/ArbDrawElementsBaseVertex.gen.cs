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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_draw_elements_base_vertex")]
    public unsafe partial class ArbDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_draw_elements_base_vertex";
        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertex")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertex")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertex")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] ARB mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] ARB type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertex")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        public ArbDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

