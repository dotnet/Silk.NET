// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_array")]
    public unsafe partial class ExtVertexArray : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_array";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="i">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glArrayElementEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ArrayElement([Flow(FlowDirection.In)] int i)
            => ImplArrayElement(i);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplColorPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplColorPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArrays([Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count)
            => ImplDrawArrays(mode, first, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from stride and count.
        /// </param>
        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] bool* pointer)
            => ImplEdgeFlagPointer(stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from stride and count.
        /// </param>
        [NativeApi(EntryPoint = "glEdgeFlagPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EdgeFlagPointer([Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "stride, count"), Flow(FlowDirection.In)] ref bool pointer)
            => ImplEdgeFlagPointer(stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer([Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetPointer(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer<T0>([Flow(FlowDirection.In)] EXT pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetPointer<T0>(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplIndexPointer(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void IndexPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplIndexPointer<T0>(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplNormalPointer(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplNormalPointer<T0>(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplTexCoordPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplTexCoordPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplColorPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplColorPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mode">
        /// To be added.
        /// </param>
        /// <param name="first">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glDrawArraysEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DrawArrays([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count)
            => ImplDrawArrays(mode, first, count);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] void** @params)
            => ImplGetPointer(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glGetPointervEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPointer<T0>([Flow(FlowDirection.In)] GetPointervPName pname, [Count(Count = 1), Flow(FlowDirection.Out)] out T0* @params) where T0 : unmanaged
            => ImplGetPointer<T0>(pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointer([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplIndexPointer(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void IndexPointer<T0>([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplIndexPointer<T0>(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointer([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplNormalPointer(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalPointer<T0>([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplNormalPointer<T0>(type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplTexCoordPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplTexCoordPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] void* pointer)
            => ImplVertexPointer(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, stride, and count.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexPointer<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint count, [Count(Computed = "size, type, stride, count"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplVertexPointer<T0>(size, type, stride, count, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] EXT pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void* GetPointer([Flow(FlowDirection.In)] GetPointervPName pname)
        {
            // ReturnTypeOverloader
            void* ret = default;
            GetPointer(pname, &ret);
            return ret;
        }

        public ExtVertexArray(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

