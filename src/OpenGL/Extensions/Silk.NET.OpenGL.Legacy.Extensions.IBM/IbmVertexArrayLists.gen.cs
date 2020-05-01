// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    [Extension("IBM_vertex_array_lists")]
    public abstract unsafe partial class IbmVertexArrayLists : NativeExtension<GL>
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
        public abstract unsafe void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] bool** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void EdgeFlagPointerList([Flow(FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(FlowDirection.In)] ref bool* pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void FogCoordPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void FogCoordPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void IndexPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void IndexPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void NormalPointerList([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void NormalPointerList<T0>([Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] IBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void ColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void ColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void FogCoordPointerList([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void FogCoordPointerList<T0>([Flow(FlowDirection.In)] FogPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void IndexPointerList([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void IndexPointerList<T0>([Flow(FlowDirection.In)] IndexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void NormalPointerList([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void NormalPointerList<T0>([Flow(FlowDirection.In)] NormalPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void SecondaryColorPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void SecondaryColorPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void TexCoordPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void TexCoordPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] TexCoordPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

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
        public abstract unsafe void VertexPointerList([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void** pointer, [Flow(FlowDirection.In)] int ptrstride);

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
        public abstract unsafe void VertexPointerList<T0>([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0* pointer, [Flow(FlowDirection.In)] int ptrstride) where T0 : unmanaged;

        public IbmVertexArrayLists(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

