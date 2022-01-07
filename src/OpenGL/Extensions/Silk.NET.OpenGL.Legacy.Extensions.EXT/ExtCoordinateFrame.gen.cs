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
    [Extension("EXT_coordinate_frame")]
    public unsafe partial class ExtCoordinateFrame : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_coordinate_frame";
        [NativeApi(EntryPoint = "glBinormal3bEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(FlowDirection.In)] sbyte bx, [Flow(FlowDirection.In)] sbyte by, [Flow(FlowDirection.In)] sbyte bz);

        [NativeApi(EntryPoint = "glBinormal3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glBinormal3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glBinormal3dEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(FlowDirection.In)] double bx, [Flow(FlowDirection.In)] double by, [Flow(FlowDirection.In)] double bz);

        [NativeApi(EntryPoint = "glBinormal3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glBinormal3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glBinormal3fEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(FlowDirection.In)] float bx, [Flow(FlowDirection.In)] float by, [Flow(FlowDirection.In)] float bz);

        [NativeApi(EntryPoint = "glBinormal3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glBinormal3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glBinormal3iEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(FlowDirection.In)] int bx, [Flow(FlowDirection.In)] int by, [Flow(FlowDirection.In)] int bz);

        [NativeApi(EntryPoint = "glBinormal3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glBinormal3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glBinormal3sEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(FlowDirection.In)] short bx, [Flow(FlowDirection.In)] short by, [Flow(FlowDirection.In)] short bz);

        [NativeApi(EntryPoint = "glBinormal3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glBinormal3svEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BinormalPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BinormalPointer([Flow(FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangent3bEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(FlowDirection.In)] sbyte tx, [Flow(FlowDirection.In)] sbyte ty, [Flow(FlowDirection.In)] sbyte tz);

        [NativeApi(EntryPoint = "glTangent3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glTangent3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in sbyte v);

        [NativeApi(EntryPoint = "glTangent3dEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(FlowDirection.In)] double tx, [Flow(FlowDirection.In)] double ty, [Flow(FlowDirection.In)] double tz);

        [NativeApi(EntryPoint = "glTangent3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glTangent3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glTangent3fEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(FlowDirection.In)] float tx, [Flow(FlowDirection.In)] float ty, [Flow(FlowDirection.In)] float tz);

        [NativeApi(EntryPoint = "glTangent3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTangent3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTangent3iEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(FlowDirection.In)] int tx, [Flow(FlowDirection.In)] int ty, [Flow(FlowDirection.In)] int tz);

        [NativeApi(EntryPoint = "glTangent3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glTangent3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in int v);

        [NativeApi(EntryPoint = "glTangent3sEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(FlowDirection.In)] short tx, [Flow(FlowDirection.In)] short ty, [Flow(FlowDirection.In)] short tz);

        [NativeApi(EntryPoint = "glTangent3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glTangent3svEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(FlowDirection.In)] in short v);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TangentPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TangentPointer([Flow(FlowDirection.In)] TangentPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        public ExtCoordinateFrame(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

