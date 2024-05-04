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

#pragma warning disable 1591

namespace Silk.NET.WGL
{
    public unsafe partial class WGL : NativeAPI
    {

        [NativeApi(EntryPoint = "ChoosePixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial int ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormatDescriptor* pPfd);

        [NativeApi(EntryPoint = "ChoosePixelFormat", Convention = CallingConvention.Winapi)]
        public partial int ChoosePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PixelFormatDescriptor pPfd);

        [NativeApi(EntryPoint = "wglCopyContext", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 CopyContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrcSrc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hglrcDst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "wglCreateContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc);

        [NativeApi(EntryPoint = "wglCreateLayerContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateLayerContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "wglDeleteContext", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DeleteContext([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint oldContext);

        [NativeApi(EntryPoint = "wglDescribeLayerPlane", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 DescribeLayerPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int pixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nBytes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] LayerPlaneDescriptor* plpd);

        [NativeApi(EntryPoint = "wglDescribeLayerPlane", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DescribeLayerPlane([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int pixelFormat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int layerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint nBytes, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out LayerPlaneDescriptor plpd);

        [NativeApi(EntryPoint = "DescribePixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial int DescribePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cjpfd, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "DescribePixelFormat", Convention = CallingConvention.Winapi)]
        public partial int DescribePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cjpfd, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglGetCurrentContext", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentContext();

        [NativeApi(EntryPoint = "wglGetCurrentDC", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentDC();

        [NativeApi(EntryPoint = "GetEnhMetaFilePixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetEnhMetaFilePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hemf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cbBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "GetEnhMetaFilePixelFormat", Convention = CallingConvention.Winapi)]
        public partial uint GetEnhMetaFilePixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hemf, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint cbBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglGetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerPaletteEntries([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pcr);

        [NativeApi(EntryPoint = "wglGetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public partial int GetLayerPaletteEntries([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pcr);

        [NativeApi(EntryPoint = "GetPixelFormat", Convention = CallingConvention.Winapi)]
        public partial int GetPixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc);

        [NativeApi(EntryPoint = "wglGetProcAddress", Convention = CallingConvention.Winapi)]
        public partial nint GetProcAddress([Flow(Silk.NET.Core.Native.FlowDirection.In)] string lpszProc);

        [NativeApi(EntryPoint = "wglMakeCurrent", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeCurrent([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint newContext);

        [NativeApi(EntryPoint = "wglRealizeLayerPalette", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 RealizeLayerPalette([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Bool32 bRealize);

        [NativeApi(EntryPoint = "wglSetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetLayerPaletteEntries([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pcr);

        [NativeApi(EntryPoint = "wglSetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public partial int SetLayerPaletteEntries([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iLayerPlane, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iStart, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int cEntries, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint pcr);

        [NativeApi(EntryPoint = "SetPixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetPixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "SetPixelFormat", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetPixelFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ipfd, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglShareLists", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ShareLists([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hrcSrvShare, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hrcSrvSource);

        [NativeApi(EntryPoint = "SwapBuffers", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SwapBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc);

        [NativeApi(EntryPoint = "wglSwapLayerBuffers", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SwapLayerBuffers([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fuFlags);

        [NativeApi(EntryPoint = "wglUseFontBitmaps", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmap([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontBitmapsA", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmapsA([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontBitmapsW", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmapsW([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontOutlines", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlines([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlines", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlines([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphMetricsFloat lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesA", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlinesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesA", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlinesA([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphMetricsFloat lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesW", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlinesW([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesW", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlinesW([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint listBase, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float deviation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float extrusion, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int format, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GlyphMetricsFloat lpgmf);


        public WGL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

