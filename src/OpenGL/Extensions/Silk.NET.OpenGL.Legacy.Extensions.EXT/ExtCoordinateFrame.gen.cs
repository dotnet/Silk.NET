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
        public partial void Binormal3([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte bx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte by, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte bz);

        [NativeApi(EntryPoint = "glBinormal3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glBinormal3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte v);

        [NativeApi(EntryPoint = "glBinormal3dEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(Silk.NET.Core.Native.FlowDirection.In)] double bx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double by, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double bz);

        [NativeApi(EntryPoint = "glBinormal3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glBinormal3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glBinormal3fEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float bx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float by, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float bz);

        [NativeApi(EntryPoint = "glBinormal3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glBinormal3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glBinormal3iEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int bx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int by, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int bz);

        [NativeApi(EntryPoint = "glBinormal3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glBinormal3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glBinormal3sEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Flow(Silk.NET.Core.Native.FlowDirection.In)] short bx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short by, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short bz);

        [NativeApi(EntryPoint = "glBinormal3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glBinormal3svEXT", Convention = CallingConvention.Winapi)]
        public partial void Binormal3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BinormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void BinormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void BinormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glBinormalPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void BinormalPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] BinormalPointerTypeEXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glTangent3bEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte tx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte ty, [Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte tz);

        [NativeApi(EntryPoint = "glTangent3bvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glTangent3bvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in sbyte v);

        [NativeApi(EntryPoint = "glTangent3dEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(Silk.NET.Core.Native.FlowDirection.In)] double tx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double ty, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double tz);

        [NativeApi(EntryPoint = "glTangent3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glTangent3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glTangent3fEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(Silk.NET.Core.Native.FlowDirection.In)] float tx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ty, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float tz);

        [NativeApi(EntryPoint = "glTangent3fvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTangent3fvEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glTangent3iEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(Silk.NET.Core.Native.FlowDirection.In)] int tx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ty, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int tz);

        [NativeApi(EntryPoint = "glTangent3ivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glTangent3ivEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int v);

        [NativeApi(EntryPoint = "glTangent3sEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Flow(Silk.NET.Core.Native.FlowDirection.In)] short tx, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short ty, [Flow(Silk.NET.Core.Native.FlowDirection.In)] short tz);

        [NativeApi(EntryPoint = "glTangent3svEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glTangent3svEXT", Convention = CallingConvention.Winapi)]
        public partial void Tangent3([Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in short v);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TangentPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void TangentPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void TangentPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] TangentPointerTypeEXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glTangentPointerEXT", Convention = CallingConvention.Winapi)]
        public partial void TangentPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] TangentPointerTypeEXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] nint pointer);

        public ExtCoordinateFrame(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

