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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.I3D
{
    [Extension("I3D_gamma")]
    public unsafe partial class I3DGamma : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_gamma";
        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ushort puBlue);

        [NativeApi(EntryPoint = "wglGetGammaTableParametersI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGammaTableParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValue);

        [NativeApi(EntryPoint = "wglGetGammaTableParametersI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGammaTableParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piValue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ushort* puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetGammaTableI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puRed, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puGreen, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ushort puBlue);

        [NativeApi(EntryPoint = "wglSetGammaTableParametersI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetGammaTableParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piValue);

        [NativeApi(EntryPoint = "wglSetGammaTableParametersI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetGammaTableParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piValue);

        public I3DGamma(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

