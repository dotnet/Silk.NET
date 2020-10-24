// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_draw_elements_base_vertex")]
    public unsafe partial class ExtDrawElementsBaseVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_elements_base_vertex";
        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public unsafe partial void DrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsBaseVertexEXT")]
        public partial void DrawElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public unsafe partial void DrawElementsInstancedBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexEXT")]
        public partial void DrawElementsInstancedBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public unsafe partial void DrawRangeElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] int basevertex);

        [NativeApi(EntryPoint = "glDrawRangeElementsBaseVertexEXT")]
        public partial void DrawRangeElementsBaseVertex<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint end, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "count, type"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] int basevertex) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] EXT mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] int* basevertex);

        [NativeApi(EntryPoint = "glMultiDrawElementsBaseVertexEXT")]
        public unsafe partial void MultiDrawElementsBaseVertex([Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint drawcount, [Count(Computed = "drawcount"), Flow(FlowDirection.In)] in int basevertex);

        public ExtDrawElementsBaseVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

