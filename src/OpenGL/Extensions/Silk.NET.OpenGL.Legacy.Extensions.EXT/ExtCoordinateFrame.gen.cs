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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_coordinate_frame")]
    public abstract unsafe partial class ExtCoordinateFrame : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_coordinate_frame";
        [NativeApi(EntryPoint = "glBinormal3bEXT")]
        public abstract void Binormal3([Flow(FlowDirection.In)] sbyte bx, [Flow(FlowDirection.In)] sbyte by, [Flow(FlowDirection.In)] sbyte bz);

        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        public abstract unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        public abstract void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glBinormal3dEXT")]
        public abstract void Binormal3([Flow(FlowDirection.In)] double bx, [Flow(FlowDirection.In)] double by, [Flow(FlowDirection.In)] double bz);

        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        public abstract unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        public abstract void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glBinormal3fEXT")]
        public abstract void Binormal3([Flow(FlowDirection.In)] float bx, [Flow(FlowDirection.In)] float by, [Flow(FlowDirection.In)] float bz);

        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        public abstract unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        public abstract void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glBinormal3iEXT")]
        public abstract void Binormal3([Flow(FlowDirection.In)] int bx, [Flow(FlowDirection.In)] int by, [Flow(FlowDirection.In)] int bz);

        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        public abstract unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        public abstract void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glBinormal3sEXT")]
        public abstract void Binormal3([Flow(FlowDirection.In)] short bx, [Flow(FlowDirection.In)] short by, [Flow(FlowDirection.In)] short bz);

        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        public abstract unsafe void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        public abstract void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public abstract unsafe void BinormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public abstract void BinormalPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTangent3bEXT")]
        public abstract void Tangent3([Flow(FlowDirection.In)] sbyte tx, [Flow(FlowDirection.In)] sbyte ty, [Flow(FlowDirection.In)] sbyte tz);

        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        public abstract unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        public abstract void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glTangent3dEXT")]
        public abstract void Tangent3([Flow(FlowDirection.In)] double tx, [Flow(FlowDirection.In)] double ty, [Flow(FlowDirection.In)] double tz);

        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        public abstract unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        public abstract void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<double> v);

        [NativeApi(EntryPoint = "glTangent3fEXT")]
        public abstract void Tangent3([Flow(FlowDirection.In)] float tx, [Flow(FlowDirection.In)] float ty, [Flow(FlowDirection.In)] float tz);

        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        public abstract unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        public abstract void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glTangent3iEXT")]
        public abstract void Tangent3([Flow(FlowDirection.In)] int tx, [Flow(FlowDirection.In)] int ty, [Flow(FlowDirection.In)] int tz);

        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        public abstract unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        public abstract void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glTangent3sEXT")]
        public abstract void Tangent3([Flow(FlowDirection.In)] short tx, [Flow(FlowDirection.In)] short ty, [Flow(FlowDirection.In)] short tz);

        [NativeApi(EntryPoint = "glTangent3svEXT")]
        public abstract unsafe void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glTangent3svEXT")]
        public abstract void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public abstract unsafe void TangentPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public abstract void TangentPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public abstract unsafe void BinormalPointer([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public abstract void BinormalPointer<T0>([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public abstract unsafe void TangentPointer([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public abstract void TangentPointer<T0>([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtCoordinateFrame(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

