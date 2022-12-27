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
        public unsafe partial int ChoosePixelFormat([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] PixelFormatDescriptor* pPfd);

        [NativeApi(EntryPoint = "ChoosePixelFormat", Convention = CallingConvention.Winapi)]
        public partial int ChoosePixelFormat([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] in PixelFormatDescriptor pPfd);

        [NativeApi(EntryPoint = "wglCopyContext", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 CopyContext([Flow(FlowDirection.In)] nint hglrcSrc, [Flow(FlowDirection.In)] nint hglrcDst, [Flow(FlowDirection.In)] uint mask);

        [NativeApi(EntryPoint = "wglCreateContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateContext([Flow(FlowDirection.In)] nint hDc);

        [NativeApi(EntryPoint = "wglCreateLayerContext", Convention = CallingConvention.Winapi)]
        public partial nint CreateLayerContext([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] int level);

        [NativeApi(EntryPoint = "wglDeleteContext", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DeleteContext([Flow(FlowDirection.In)] nint oldContext);

        [NativeApi(EntryPoint = "wglDescribeLayerPlane", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 DescribeLayerPlane([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] int pixelFormat, [Flow(FlowDirection.In)] int layerPlane, [Flow(FlowDirection.In)] uint nBytes, [Flow(FlowDirection.Out)] LayerPlaneDescriptor* plpd);

        [NativeApi(EntryPoint = "wglDescribeLayerPlane", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DescribeLayerPlane([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] int pixelFormat, [Flow(FlowDirection.In)] int layerPlane, [Flow(FlowDirection.In)] uint nBytes, [Flow(FlowDirection.Out)] out LayerPlaneDescriptor plpd);

        [NativeApi(EntryPoint = "DescribePixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial int DescribePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int ipfd, [Flow(FlowDirection.In)] uint cjpfd, [Flow(FlowDirection.Out)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "DescribePixelFormat", Convention = CallingConvention.Winapi)]
        public partial int DescribePixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int ipfd, [Flow(FlowDirection.In)] uint cjpfd, [Flow(FlowDirection.Out)] out PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglGetCurrentContext", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentContext();

        [NativeApi(EntryPoint = "wglGetCurrentDC", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentDC();

        [NativeApi(EntryPoint = "GetEnhMetaFilePixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetEnhMetaFilePixelFormat([Flow(FlowDirection.In)] nint hemf, [Flow(FlowDirection.In)] uint cbBuffer, [Flow(FlowDirection.Out)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "GetEnhMetaFilePixelFormat", Convention = CallingConvention.Winapi)]
        public partial uint GetEnhMetaFilePixelFormat([Flow(FlowDirection.In)] nint hemf, [Flow(FlowDirection.In)] uint cbBuffer, [Flow(FlowDirection.Out)] out PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglGetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public unsafe partial int GetLayerPaletteEntries([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] int iStart, [Flow(FlowDirection.In)] int cEntries, [Flow(FlowDirection.Out)] uint* pcr);

        [NativeApi(EntryPoint = "wglGetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public partial int GetLayerPaletteEntries([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] int iStart, [Flow(FlowDirection.In)] int cEntries, [Flow(FlowDirection.Out)] out uint pcr);

        [NativeApi(EntryPoint = "GetPixelFormat", Convention = CallingConvention.Winapi)]
        public partial int GetPixelFormat([Flow(FlowDirection.In)] nint hdc);

        [NativeApi(EntryPoint = "wglGetProcAddress", Convention = CallingConvention.Winapi)]
        public partial nint GetProcAddress([Flow(FlowDirection.In)] string lpszProc);

        [NativeApi(EntryPoint = "wglMakeCurrent", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeCurrent([Flow(FlowDirection.In)] nint hDc, [Flow(FlowDirection.In)] nint newContext);

        [NativeApi(EntryPoint = "wglRealizeLayerPalette", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 RealizeLayerPalette([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] Silk.NET.Core.Bool32 bRealize);

        [NativeApi(EntryPoint = "wglSetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public unsafe partial int SetLayerPaletteEntries([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] int iStart, [Flow(FlowDirection.In)] int cEntries, [Flow(FlowDirection.In)] uint* pcr);

        [NativeApi(EntryPoint = "wglSetLayerPaletteEntries", Convention = CallingConvention.Winapi)]
        public partial int SetLayerPaletteEntries([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int iLayerPlane, [Flow(FlowDirection.In)] int iStart, [Flow(FlowDirection.In)] int cEntries, [Flow(FlowDirection.In)] in uint pcr);

        [NativeApi(EntryPoint = "SetPixelFormat", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetPixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int ipfd, [Flow(FlowDirection.In)] PixelFormatDescriptor* ppfd);

        [NativeApi(EntryPoint = "SetPixelFormat", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetPixelFormat([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] int ipfd, [Flow(FlowDirection.In)] in PixelFormatDescriptor ppfd);

        [NativeApi(EntryPoint = "wglShareLists", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ShareLists([Flow(FlowDirection.In)] nint hrcSrvShare, [Flow(FlowDirection.In)] nint hrcSrvSource);

        [NativeApi(EntryPoint = "SwapBuffers", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SwapBuffers([Flow(FlowDirection.In)] nint hdc);

        [NativeApi(EntryPoint = "wglSwapLayerBuffers", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SwapLayerBuffers([Flow(FlowDirection.In)] nint hdc, [Flow(FlowDirection.In)] uint fuFlags);

        [NativeApi(EntryPoint = "wglUseFontBitmaps", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmap([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontBitmapsA", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmapsA([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontBitmapsW", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontBitmapsW([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase);

        [NativeApi(EntryPoint = "wglUseFontOutlines", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlines([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlines", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlines([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] in GlyphMetricsFloat lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesA", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlinesA([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesA", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlinesA([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] in GlyphMetricsFloat lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesW", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 UseFontOutlinesW([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] GlyphMetricsFloat* lpgmf);

        [NativeApi(EntryPoint = "wglUseFontOutlinesW", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 UseFontOutlinesW([Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint listBase, [Flow(FlowDirection.In)] float deviation, [Flow(FlowDirection.In)] float extrusion, [Flow(FlowDirection.In)] int format, [Flow(FlowDirection.In)] in GlyphMetricsFloat lpgmf);


        public WGL(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

