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
    [Extension("EXT_coordinate_frame")]
    public unsafe partial class ExtCoordinateFrame : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_coordinate_frame";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bx">
        /// To be added.
        /// </param>
        /// <param name="by">
        /// To be added.
        /// </param>
        /// <param name="bz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3bEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Flow(FlowDirection.In)] sbyte bx, [Flow(FlowDirection.In)] sbyte by, [Flow(FlowDirection.In)] sbyte bz)
            => ImplBinormal3(bx, by, bz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bx">
        /// To be added.
        /// </param>
        /// <param name="by">
        /// To be added.
        /// </param>
        /// <param name="bz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Flow(FlowDirection.In)] double bx, [Flow(FlowDirection.In)] double by, [Flow(FlowDirection.In)] double bz)
            => ImplBinormal3(bx, by, bz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bx">
        /// To be added.
        /// </param>
        /// <param name="by">
        /// To be added.
        /// </param>
        /// <param name="bz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Flow(FlowDirection.In)] float bx, [Flow(FlowDirection.In)] float by, [Flow(FlowDirection.In)] float bz)
            => ImplBinormal3(bx, by, bz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bx">
        /// To be added.
        /// </param>
        /// <param name="by">
        /// To be added.
        /// </param>
        /// <param name="bz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Flow(FlowDirection.In)] int bx, [Flow(FlowDirection.In)] int by, [Flow(FlowDirection.In)] int bz)
            => ImplBinormal3(bx, by, bz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="bx">
        /// To be added.
        /// </param>
        /// <param name="by">
        /// To be added.
        /// </param>
        /// <param name="bz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3sEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Flow(FlowDirection.In)] short bx, [Flow(FlowDirection.In)] short by, [Flow(FlowDirection.In)] short bz)
            => ImplBinormal3(bx, by, bz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplBinormal3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplBinormal3(v);

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
        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BinormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplBinormalPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BinormalPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplBinormalPointer<T0>(type, stride, pointer);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tx">
        /// To be added.
        /// </param>
        /// <param name="ty">
        /// To be added.
        /// </param>
        /// <param name="tz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3bEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Flow(FlowDirection.In)] sbyte tx, [Flow(FlowDirection.In)] sbyte ty, [Flow(FlowDirection.In)] sbyte tz)
            => ImplTangent3(tx, ty, tz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tx">
        /// To be added.
        /// </param>
        /// <param name="ty">
        /// To be added.
        /// </param>
        /// <param name="tz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3dEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Flow(FlowDirection.In)] double tx, [Flow(FlowDirection.In)] double ty, [Flow(FlowDirection.In)] double tz)
            => ImplTangent3(tx, ty, tz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] double* v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tx">
        /// To be added.
        /// </param>
        /// <param name="ty">
        /// To be added.
        /// </param>
        /// <param name="tz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3fEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Flow(FlowDirection.In)] float tx, [Flow(FlowDirection.In)] float ty, [Flow(FlowDirection.In)] float tz)
            => ImplTangent3(tx, ty, tz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] float* v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tx">
        /// To be added.
        /// </param>
        /// <param name="ty">
        /// To be added.
        /// </param>
        /// <param name="tz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3iEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Flow(FlowDirection.In)] int tx, [Flow(FlowDirection.In)] int ty, [Flow(FlowDirection.In)] int tz)
            => ImplTangent3(tx, ty, tz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] int* v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="tx">
        /// To be added.
        /// </param>
        /// <param name="ty">
        /// To be added.
        /// </param>
        /// <param name="tz">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3sEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Flow(FlowDirection.In)] short tx, [Flow(FlowDirection.In)] short ty, [Flow(FlowDirection.In)] short tz)
            => ImplTangent3(tx, ty, tz);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] short* v)
            => ImplTangent3(v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="v">
        /// To be added.
        /// This parameter contains 3 elements.
        /// </param>
        [NativeApi(EntryPoint = "glTangent3svEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v)
            => ImplTangent3(v);

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
        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TangentPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplTangentPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TangentPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplTangentPointer<T0>(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BinormalPointer([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplBinormalPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BinormalPointer<T0>([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplBinormalPointer<T0>(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void TangentPointer([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer)
            => ImplTangentPointer(type, stride, pointer);

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
        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TangentPointer<T0>([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged
            => ImplTangentPointer<T0>(type, stride, pointer);

        public ExtCoordinateFrame(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

