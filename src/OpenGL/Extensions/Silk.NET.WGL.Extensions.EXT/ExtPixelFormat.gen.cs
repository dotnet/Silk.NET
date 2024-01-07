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

namespace Silk.NET.WGL.Extensions.EXT
{
    [Extension("EXT_pixel_format")]
    public unsafe partial class ExtPixelFormat : NativeExtension<WGL>
    {
        public const string ExtensionName = "EXT_pixel_format";
        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piAttribIList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float pfAttribFList, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nMaxFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piFormats, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iPixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piAttributes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pfValues);

        public ExtPixelFormat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

