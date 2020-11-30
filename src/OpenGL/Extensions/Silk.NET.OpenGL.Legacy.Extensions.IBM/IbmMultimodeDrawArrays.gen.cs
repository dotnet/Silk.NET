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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_multimode_draw_arrays")]
    public unsafe partial class IbmMultimodeDrawArrays : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_multimode_draw_arrays";
        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] int* first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public unsafe partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawArraysIBM")]
        public partial void MultiModeDrawArrays([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in int first, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] IBM* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in IBM mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] IBM type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] PrimitiveType* mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] uint* count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] void** indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        [NativeApi(EntryPoint = "glMultiModeDrawElementsIBM")]
        public unsafe partial void MultiModeDrawElements([Count(Computed = "primcount"), Flow(FlowDirection.In)] in PrimitiveType mode, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount"), Flow(FlowDirection.In)] in void* indices, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] int modestride);

        public IbmMultimodeDrawArrays(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

