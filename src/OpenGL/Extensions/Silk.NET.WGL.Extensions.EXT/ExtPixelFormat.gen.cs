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
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int* piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] float* pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] int* piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] uint* nNumFormats);

        [NativeApi(EntryPoint = "wglChoosePixelFormatEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ChoosePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] in int piAttribIList, [Flow(FlowDirection.In)] in float pfAttribFList, [Flow(FlowDirection.In)] uint nMaxFormats, [Flow(FlowDirection.Out)] out int piFormats, [Flow(FlowDirection.Out)] out uint nNumFormats);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] int* piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] out int piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] out int piAttributes, [Flow(FlowDirection.Out)] int* piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribivEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] out int piAttributes, [Flow(FlowDirection.Out)] out int piValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] float* pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] int* piAttributes, [Flow(FlowDirection.Out)] out float pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] out int piAttributes, [Flow(FlowDirection.Out)] float* pfValues);

        [NativeApi(EntryPoint = "wglGetPixelFormatAttribfvEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetPixelFormatAttrib([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] uint nAttributes, [Flow(FlowDirection.Out)] out int piAttributes, [Flow(FlowDirection.Out)] out float pfValues);

        public ExtPixelFormat(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

