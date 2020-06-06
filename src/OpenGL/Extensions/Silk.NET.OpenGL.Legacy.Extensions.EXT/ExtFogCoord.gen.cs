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
    [Extension("EXT_fog_coord")]
    public unsafe partial class ExtFogCoord : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fog_coord";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordfEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoord([Flow(FlowDirection.In)] float coord)
            => ImplFogCoord(coord);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] float* coord)
            => ImplFogCoord(coord);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref float coord)
            => ImplFogCoord(coord);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoorddEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoord([Flow(FlowDirection.In)] double coord)
            => ImplFogCoord(coord);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] double* coord)
            => ImplFogCoord(coord);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="coord">
        /// To be added.
        /// This parameter contains 1 elements.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref double coord)
            => ImplFogCoord(coord);

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
        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplFogCoordPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoordPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplFogCoordPointer<T0>(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void FogCoordPointer([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplFogCoordPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoordPointer<T0>([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplFogCoordPointer<T0>(type, stride, pointer);

        public ExtFogCoord(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

