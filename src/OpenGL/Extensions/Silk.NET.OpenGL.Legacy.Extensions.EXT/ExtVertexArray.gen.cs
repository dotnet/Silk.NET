// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_array")]
    public unsafe partial class ExtVertexArray : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_array";
        [NativeApi(EntryPoint = "glArrayElementEXT", Convention = CallingConvention.Winapi)]
        public partial void ArrayElement([Flow(FlowDirection.In)] int i);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glDrawArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArrays([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] bool* pointer);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] in bool pointer);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] Boolean* pointer);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] in Boolean pointer);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointer([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer);

        public unsafe void* GetPointer([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public ExtVertexArray(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

