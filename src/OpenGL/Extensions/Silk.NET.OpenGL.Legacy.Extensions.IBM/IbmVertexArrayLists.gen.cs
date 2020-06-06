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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_vertex_array_lists")]
    public unsafe partial class IbmVertexArrayLists : NativeExtension<GL>
    {
        public const string ExtensionName = "IBM_vertex_array_lists";
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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplColorPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplColorPointerList<T0>(size, type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] bool** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplEdgeFlagPointerList(stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEdgeFlagPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] ref bool* pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplEdgeFlagPointerList(stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplFogCoordPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplFogCoordPointerList<T0>(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplIndexPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplIndexPointerList<T0>(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplNormalPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplNormalPointerList<T0>(type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplSecondaryColorPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplSecondaryColorPointerList<T0>(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplTexCoordPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplTexCoordPointerList<T0>(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplVertexPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplVertexPointerList<T0>(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplColorPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplColorPointerList<T0>(size, type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointerList([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplFogCoordPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointerList<T0>([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplFogCoordPointerList<T0>(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointerList([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplIndexPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void IndexPointerList<T0>([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplIndexPointerList<T0>(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointerList([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplNormalPointerList(type, stride, pointer, ptrstride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from type and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void NormalPointerList<T0>([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplNormalPointerList<T0>(type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplSecondaryColorPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplSecondaryColorPointerList<T0>(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplTexCoordPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplTexCoordPointerList<T0>(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride)
            => ImplVertexPointerList(size, type, stride, pointer, ptrstride);

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
        /// <param name="pointer">
        /// To be added.
        /// This parameter's element count is computed from size, type, and stride.
        /// </param>
        /// <param name="ptrstride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexPointerListIBM")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged
            => ImplVertexPointerList<T0>(size, type, stride, pointer, ptrstride);

        public IbmVertexArrayLists(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

