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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_coordinate_frame")]
    public unsafe partial class ExtCoordinateFrame : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_coordinate_frame";
        [NativeApi(EntryPoint = "glBinormal3bEXT")]
        public partial void Binormal3([Flow(FlowDirection.In)] sbyte bx, [Flow(FlowDirection.In)] sbyte by, [Flow(FlowDirection.In)] sbyte bz);

        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glBinormal3bvEXT")]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glBinormal3dEXT")]
        public partial void Binormal3([Flow(FlowDirection.In)] double bx, [Flow(FlowDirection.In)] double by, [Flow(FlowDirection.In)] double bz);

        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glBinormal3dvEXT")]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glBinormal3fEXT")]
        public partial void Binormal3([Flow(FlowDirection.In)] float bx, [Flow(FlowDirection.In)] float by, [Flow(FlowDirection.In)] float bz);

        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glBinormal3fvEXT")]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glBinormal3iEXT")]
        public partial void Binormal3([Flow(FlowDirection.In)] int bx, [Flow(FlowDirection.In)] int by, [Flow(FlowDirection.In)] int bz);

        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glBinormal3ivEXT")]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glBinormal3sEXT")]
        public partial void Binormal3([Flow(FlowDirection.In)] short bx, [Flow(FlowDirection.In)] short by, [Flow(FlowDirection.In)] short bz);

        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glBinormal3svEXT")]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public unsafe partial void BinormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public partial void BinormalPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public unsafe partial void BinormalPointer([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT")]
        public partial void BinormalPointer<T0>([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTangent3bEXT")]
        public partial void Tangent3([Flow(FlowDirection.In)] sbyte tx, [Flow(FlowDirection.In)] sbyte ty, [Flow(FlowDirection.In)] sbyte tz);

        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glTangent3bvEXT")]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glTangent3dEXT")]
        public partial void Tangent3([Flow(FlowDirection.In)] double tx, [Flow(FlowDirection.In)] double ty, [Flow(FlowDirection.In)] double tz);

        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glTangent3dvEXT")]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glTangent3fEXT")]
        public partial void Tangent3([Flow(FlowDirection.In)] float tx, [Flow(FlowDirection.In)] float ty, [Flow(FlowDirection.In)] float tz);

        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTangent3fvEXT")]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTangent3iEXT")]
        public partial void Tangent3([Flow(FlowDirection.In)] int tx, [Flow(FlowDirection.In)] int ty, [Flow(FlowDirection.In)] int tz);

        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glTangent3ivEXT")]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glTangent3sEXT")]
        public partial void Tangent3([Flow(FlowDirection.In)] short tx, [Flow(FlowDirection.In)] short ty, [Flow(FlowDirection.In)] short tz);

        [NativeApi(EntryPoint = "glTangent3svEXT")]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glTangent3svEXT")]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public unsafe partial void TangentPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public partial void TangentPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public unsafe partial void TangentPointer([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT")]
        public partial void TangentPointer<T0>([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public ExtCoordinateFrame(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

