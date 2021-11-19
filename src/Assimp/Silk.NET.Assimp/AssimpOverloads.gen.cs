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

namespace Silk.NET.Assimp
{
    public static class AssimpOverloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 103, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe void ReleaseExportFormatDescription(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ExportFormatDesc> desc)
        {
            // SpanOverloader
            thisApi.ReleaseExportFormatDescription(in desc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe void CopyScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pIn, Scene** pOut)
        {
            // SpanOverloader
            thisApi.CopyScene(in pIn.GetPinnableReference(), pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe void CopyScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pIn, ref Scene* pOut)
        {
            // SpanOverloader
            thisApi.CopyScene(in pIn.GetPinnableReference(), ref pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe void FreeScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pIn)
        {
            // SpanOverloader
            thisApi.FreeScene(in pIn.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, pFormatId, ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, ref pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, ref pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, pFormatId, ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, ref pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, Span<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, ref pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pScene, Span<byte> pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(pScene, ref pFormatId.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, byte* pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), pFormatId, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, Span<byte> pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), ref pFormatId.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), pFormatId, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        public static unsafe void ReleaseExportBlob(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<ExportDataBlob> pData)
        {
            // SpanOverloader
            thisApi.ReleaseExportBlob(in pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 43 in src/Assimp/Include\\assimp/importerdesc.h")]
        public static unsafe ImporterDesc* GetImporterDesc(this Assimp thisApi, Span<byte> extension)
        {
            // SpanOverloader
            return thisApi.GetImporterDesc(ref extension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFile(this Assimp thisApi, Span<byte> pFile, uint pFlags)
        {
            // SpanOverloader
            return thisApi.ImportFile(ref pFile.GetPinnableReference(), pFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, byte* pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(pFile, pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, Span<byte> pFile, uint pFlags, FileIO* pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(ref pFile.GetPinnableReference(), pFlags, pFS);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, Span<byte> pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(ref pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(pFile, pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, byte* pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, byte* pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, byte* pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, Span<byte> pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(ref pFile.GetPinnableReference(), pFlags, pFS, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, Span<byte> pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(ref pFile.GetPinnableReference(), pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, Span<byte> pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(ref pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, Span<byte> pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(ref pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, byte* pBuffer, uint pLength, uint pFlags, Span<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, byte* pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(ref pBuffer.GetPinnableReference(), pLength, pFlags, ref pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, Span<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, byte* pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, byte* pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, byte* pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, ref pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, ref pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, Span<byte> pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(ref pBuffer.GetPinnableReference(), pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, Span<byte> pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, ref pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Scene* ApplyPostProcessing(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene, uint pFlags)
        {
            // SpanOverloader
            return thisApi.ApplyPostProcessing(in pScene.GetPinnableReference(), pFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 277, Column 33 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe LogStream GetPredefinedLogStream(this Assimp thisApi, DefaultLogStream pStreams, Span<byte> file)
        {
            // SpanOverloader
            return thisApi.GetPredefinedLogStream(pStreams, ref file.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 291, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void AttachLogStream(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<LogStream> stream)
        {
            // SpanOverloader
            thisApi.AttachLogStream(in stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 28 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe Return DetachLogStream(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<LogStream> stream)
        {
            // SpanOverloader
            return thisApi.DetachLogStream(in stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void ReleaseImport(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pScene)
        {
            // SpanOverloader
            thisApi.ReleaseImport(in pScene.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 19 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe int IsExtensionSupported(this Assimp thisApi, Span<byte> szExtension)
        {
            // SpanOverloader
            return thisApi.IsExtensionSupported(ref szExtension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void GetExtensionList(this Assimp thisApi, Span<AssimpString> szOut)
        {
            // SpanOverloader
            thisApi.GetExtensionList(ref szOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(FlowDirection.In)] Scene* pIn, Span<MemoryInfo> @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(pIn, ref @in.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pIn, MemoryInfo* @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(in pIn.GetPinnableReference(), @in);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Scene> pIn, Span<MemoryInfo> @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(in pIn.GetPinnableReference(), ref @in.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void ReleasePropertyStore(this Assimp thisApi, Span<PropertyStore> p)
        {
            // SpanOverloader
            thisApi.ReleasePropertyStore(ref p.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, PropertyStore* store, Span<byte> szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(store, ref szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, byte* szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, PropertyStore* store, Span<byte> szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(store, ref szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, byte* szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, byte* szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, Span<byte> szName, [Flow(FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, ref szName.GetPinnableReference(), st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, Span<byte> szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, ref szName.GetPinnableReference(), in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, byte* szName, [Flow(FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, byte* szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, [Flow(FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, byte* szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, szName, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, Span<byte> szName, System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, ref szName.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, Span<byte> szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, ref szName.GetPinnableReference(), ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, szName, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, byte* szName, System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, byte* szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, Span<byte> szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), ref szName.GetPinnableReference(), ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, System.Numerics.Quaternion* quat, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(quat, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, Span<System.Numerics.Quaternion> quat, Silk.NET.Maths.Matrix3X3<float>* mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(ref quat.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, Span<System.Numerics.Quaternion> quat, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(ref quat.GetPinnableReference(), ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Quaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Quaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), scaling, rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Quaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Quaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Quaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(ref mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransposeMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransposeMatrix4(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransposeMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransposeMatrix3(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, System.Numerics.Vector3* vec, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(vec, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, Span<System.Numerics.Vector3> vec, Silk.NET.Maths.Matrix3X3<float>* mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(ref vec.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, Span<System.Numerics.Vector3> vec, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(ref vec.GetPinnableReference(), ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, System.Numerics.Vector3* vec, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(vec, ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, Span<System.Numerics.Vector3> vec, System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(ref vec.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, Span<System.Numerics.Vector3> vec, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(ref vec.GetPinnableReference(), ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, System.Numerics.Matrix4x4* dst, Span<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(dst, ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, System.Numerics.Matrix4x4* src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, Span<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(ref dst.GetPinnableReference(), ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* dst, Span<Silk.NET.Maths.Matrix3X3<float>> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(dst, ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, Silk.NET.Maths.Matrix3X3<float>* src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, Span<Silk.NET.Maths.Matrix3X3<float>> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(ref dst.GetPinnableReference(), ref src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 537, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void IdentityMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.IdentityMatrix3(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 544, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        public static unsafe void IdentityMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.IdentityMatrix4(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(pMat, ref pKey.GetPinnableReference(), type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(pMat, ref pKey.GetPinnableReference(), type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, ref pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, ref pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, ref pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, ref pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, Span<byte> pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, byte* pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, Span<byte> pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), ref pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 25 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe uint GetMaterialTextureCount(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> pMat, TextureType type)
        {
            // SpanOverloader
            return thisApi.GetMaterialTextureCount(in pMat.GetPinnableReference(), type);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

    }
}

