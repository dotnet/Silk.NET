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
        public partial void ArrayElement([Flow(Silk.NET.Core.Native.FlowDirection.In)] int i);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void ColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glColorPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glDrawArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glDrawArraysEXT", Convention = CallingConvention.Winapi)]
        public partial void DrawArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void EdgeFlagPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] bool* pointer);

        [Obsolete("This overload exposes native-sized integer parameters (which are expressed as pointers in the original C function) as C# references due to a historical error, please consider using overloads that expose the following parameters as raw pointers or native integers instead: pointer")]
        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in bool pointer);

        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] void** @params);

        [NativeApi(EntryPoint = "glGetPointervEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out void* @params);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void IndexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glIndexPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void IndexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void NormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void NormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glNormalPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void NormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void TexCoordPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TexCoordPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTexCoordPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void TexCoordPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        public unsafe void* GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public unsafe void* GetPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPointervPName pname)
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

