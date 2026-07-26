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
        [NativeName("Src", "Line 107, Column 17 in cexport.h")]
        public static unsafe void ReleaseExportFormatDescription(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExportFormatDesc> desc)
        {
            // SpanOverloader
            thisApi.ReleaseExportFormatDescription(in desc.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        public static unsafe void CopyScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, Scene** pOut)
        {
            // SpanOverloader
            thisApi.CopyScene(in pIn.GetPinnableReference(), pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 17 in cexport.h")]
        public static unsafe void CopyScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, ref Scene* pOut)
        {
            // SpanOverloader
            thisApi.CopyScene(in pIn.GetPinnableReference(), ref pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 123, Column 17 in cexport.h")]
        public static unsafe void FreeScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn)
        {
            // SpanOverloader
            thisApi.FreeScene(in pIn.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, pFormatId, in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, in pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, in pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(pScene, pFormatId, in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 21 in cexport.h")]
        public static unsafe Return ExportScene(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportScene(in pScene.GetPinnableReference(), pFormatId, pFileName, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, in pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(pScene, pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, in pFileName.GetPinnableReference(), ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, pIO, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 184, Column 21 in cexport.h")]
        public static unsafe Return ExportSceneEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, Span<FileIO> pIO, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneEx(in pScene.GetPinnableReference(), pFormatId, pFileName, ref pIO.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(pScene, in pFormatId.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), pFormatId, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), in pFormatId.GetPinnableReference(), pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 45 in cexport.h")]
        public static unsafe ExportDataBlob* ExportSceneToBlob(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing)
        {
            // SpanOverloader
            return thisApi.ExportSceneToBlob(in pScene.GetPinnableReference(), pFormatId, pPreprocessing);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 266, Column 17 in cexport.h")]
        public static unsafe void ReleaseExportBlob(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ExportDataBlob> pData)
        {
            // SpanOverloader
            thisApi.ReleaseExportBlob(in pData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 148, Column 43 in importerdesc.h")]
        public static unsafe ImporterDesc* GetImporterDesc(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> extension)
        {
            // SpanOverloader
            return thisApi.GetImporterDesc(in extension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 118, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFile(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags)
        {
            // SpanOverloader
            return thisApi.ImportFile(in pFile.GetPinnableReference(), pFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(pFile, pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, FileIO* pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(in pFile.GetPinnableReference(), pFlags, pFS);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(in pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 143, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileEx(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS)
        {
            // SpanOverloader
            return thisApi.ImportFileEx(pFile, pFlags, ref pFS.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(in pFile.GetPinnableReference(), pFlags, pFS, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(in pFile.GetPinnableReference(), pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(in pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(in pFile.GetPinnableReference(), pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, pFS, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 164, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileExWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, Span<FileIO> pFS, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileExWithProperties(pFile, pFlags, ref pFS.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(pBuffer, pLength, pFlags, in pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(in pBuffer.GetPinnableReference(), pLength, pFlags, in pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 202, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemory(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemory(pBuffer, pLength, pFlags, in pHint.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, in pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, in pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, in pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, in pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint, pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(in pBuffer.GetPinnableReference(), pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PropertyStore* pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, in pHint.GetPinnableReference(), pProps);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, in pHint.GetPinnableReference(), in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 236, Column 36 in cimport.h")]
        public static unsafe Scene* ImportFileFromMemoryWithProperties(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PropertyStore> pProps)
        {
            // SpanOverloader
            return thisApi.ImportFileFromMemoryWithProperties(pBuffer, pLength, pFlags, pHint, in pProps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 258, Column 36 in cimport.h")]
        public static unsafe Scene* ApplyPostProcessing(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene, uint pFlags)
        {
            // SpanOverloader
            return thisApi.ApplyPostProcessing(in pScene.GetPinnableReference(), pFlags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 282, Column 33 in cimport.h")]
        public static unsafe LogStream GetPredefinedLogStream(this Assimp thisApi, DefaultLogStream pStreams, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> file)
        {
            // SpanOverloader
            return thisApi.GetPredefinedLogStream(pStreams, in file.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 296, Column 17 in cimport.h")]
        public static unsafe void AttachLogStream(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LogStream> stream)
        {
            // SpanOverloader
            thisApi.AttachLogStream(in stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 28 in cimport.h")]
        public static unsafe Return DetachLogStream(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LogStream> stream)
        {
            // SpanOverloader
            return thisApi.DetachLogStream(in stream.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 336, Column 17 in cimport.h")]
        public static unsafe void ReleaseImport(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pScene)
        {
            // SpanOverloader
            thisApi.ReleaseImport(in pScene.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 355, Column 19 in cimport.h")]
        public static unsafe int IsExtensionSupported(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szExtension)
        {
            // SpanOverloader
            return thisApi.IsExtensionSupported(in szExtension.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 366, Column 17 in cimport.h")]
        public static unsafe void GetExtensionList(this Assimp thisApi, Span<AssimpString> szOut)
        {
            // SpanOverloader
            thisApi.GetExtensionList(ref szOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 17 in cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, Span<MemoryInfo> @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(pIn, ref @in.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 17 in cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, MemoryInfo* @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(in pIn.GetPinnableReference(), @in);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 374, Column 17 in cimport.h")]
        public static unsafe void GetMemoryRequirements(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, Span<MemoryInfo> @in)
        {
            // SpanOverloader
            thisApi.GetMemoryRequirements(in pIn.GetPinnableReference(), ref @in.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 38 in cimport.h")]
        public static unsafe Texture* GetEmbeddedTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Scene* pIn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filename)
        {
            // SpanOverloader
            return thisApi.GetEmbeddedTexture(pIn, in filename.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 38 in cimport.h")]
        public static unsafe Texture* GetEmbeddedTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* filename)
        {
            // SpanOverloader
            return thisApi.GetEmbeddedTexture(in pIn.GetPinnableReference(), filename);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 38 in cimport.h")]
        public static unsafe Texture* GetEmbeddedTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> filename)
        {
            // SpanOverloader
            return thisApi.GetEmbeddedTexture(in pIn.GetPinnableReference(), in filename.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 383, Column 38 in cimport.h")]
        public static unsafe Texture* GetEmbeddedTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Scene> pIn, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string filename)
        {
            // SpanOverloader
            return thisApi.GetEmbeddedTexture(in pIn.GetPinnableReference(), filename);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 397, Column 17 in cimport.h")]
        public static unsafe void ReleasePropertyStore(this Assimp thisApi, Span<PropertyStore> p)
        {
            // SpanOverloader
            thisApi.ReleasePropertyStore(ref p.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(store, in szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), in szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 411, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyInteger(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyInteger(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(store, in szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), in szName.GetPinnableReference(), value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 428, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyFloat(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value)
        {
            // SpanOverloader
            thisApi.SetImportPropertyFloat(ref store.GetPinnableReference(), szName, value);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, in szName.GetPinnableReference(), st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, in szName.GetPinnableReference(), in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(store, szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), in szName.GetPinnableReference(), st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), in szName.GetPinnableReference(), in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpString* st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, st);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 445, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyString(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpString> st)
        {
            // SpanOverloader
            thisApi.SetImportPropertyString(ref store.GetPinnableReference(), szName, in st.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, szName, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, in szName.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, in szName.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, PropertyStore* store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(store, szName, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), in szName.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), in szName.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 462, Column 17 in cimport.h")]
        public static unsafe void SetImportPropertyMatrix(this Assimp thisApi, Span<PropertyStore> store, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.SetImportPropertyMatrix(ref store.GetPinnableReference(), szName, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 17 in cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, AssimpQuaternion* quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(quat, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 17 in cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, Span<AssimpQuaternion> quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(ref quat.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 473, Column 17 in cimport.h")]
        public static unsafe void CreateQuaternionFromMatrix(this Assimp thisApi, Span<AssimpQuaternion> quat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.CreateQuaternionFromMatrix(ref quat.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), scaling, rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, AssimpQuaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in cimport.h")]
        public static unsafe void DecomposeMatrix(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.DecomposeMatrix(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 497, Column 17 in cimport.h")]
        public static unsafe void TransposeMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransposeMatrix4(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 504, Column 17 in cimport.h")]
        public static unsafe void TransposeMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransposeMatrix3(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(vec, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, Span<System.Numerics.Vector3> vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(ref vec.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 512, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix3(this Assimp thisApi, Span<System.Numerics.Vector3> vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix3(ref vec.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, System.Numerics.Vector3* vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(vec, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, Span<System.Numerics.Vector3> vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(ref vec.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 521, Column 17 in cimport.h")]
        public static unsafe void TransformVecByMatrix4(this Assimp thisApi, Span<System.Numerics.Vector3> vec, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.TransformVecByMatrix4(ref vec.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 530, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix4(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 539, Column 17 in cimport.h")]
        public static unsafe void MultiplyMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> src)
        {
            // SpanOverloader
            thisApi.MultiplyMatrix3(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 547, Column 17 in cimport.h")]
        public static unsafe void IdentityMatrix3(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.IdentityMatrix3(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 554, Column 17 in cimport.h")]
        public static unsafe void IdentityMatrix4(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.IdentityMatrix4(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 579, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqualEpsilon(a, in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqualEpsilon(in a.GetPinnableReference(), b, epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 591, Column 16 in cimport.h")]
        public static unsafe int Vector2AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector2AreEqualEpsilon(in a.GetPinnableReference(), in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        public static unsafe void Vector2Add(this Assimp thisApi, System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> src)
        {
            // SpanOverloader
            thisApi.Vector2Add(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        public static unsafe void Vector2Add(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src)
        {
            // SpanOverloader
            thisApi.Vector2Add(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 601, Column 17 in cimport.h")]
        public static unsafe void Vector2Add(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> src)
        {
            // SpanOverloader
            thisApi.Vector2Add(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in cimport.h")]
        public static unsafe void Vector2Subtract(this Assimp thisApi, System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> src)
        {
            // SpanOverloader
            thisApi.Vector2Subtract(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in cimport.h")]
        public static unsafe void Vector2Subtract(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* src)
        {
            // SpanOverloader
            thisApi.Vector2Subtract(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 610, Column 17 in cimport.h")]
        public static unsafe void Vector2Subtract(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> src)
        {
            // SpanOverloader
            thisApi.Vector2Subtract(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 619, Column 17 in cimport.h")]
        public static unsafe void Vector2Scale(this Assimp thisApi, Span<System.Numerics.Vector2> dst, float s)
        {
            // SpanOverloader
            thisApi.Vector2Scale(ref dst.GetPinnableReference(), s);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in cimport.h")]
        public static unsafe void Vector2SymMul(this Assimp thisApi, System.Numerics.Vector2* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> other)
        {
            // SpanOverloader
            thisApi.Vector2SymMul(dst, in other.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in cimport.h")]
        public static unsafe void Vector2SymMul(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* other)
        {
            // SpanOverloader
            thisApi.Vector2SymMul(ref dst.GetPinnableReference(), other);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 629, Column 17 in cimport.h")]
        public static unsafe void Vector2SymMul(this Assimp thisApi, Span<System.Numerics.Vector2> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> other)
        {
            // SpanOverloader
            thisApi.Vector2SymMul(ref dst.GetPinnableReference(), in other.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 638, Column 17 in cimport.h")]
        public static unsafe void Vector2DivideByScalar(this Assimp thisApi, Span<System.Numerics.Vector2> dst, float s)
        {
            // SpanOverloader
            thisApi.Vector2DivideByScalar(ref dst.GetPinnableReference(), s);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 648, Column 17 in cimport.h")]
        public static unsafe void Vector2DivideByVector(this Assimp thisApi, System.Numerics.Vector2* dst, Span<System.Numerics.Vector2> v)
        {
            // SpanOverloader
            thisApi.Vector2DivideByVector(dst, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 648, Column 17 in cimport.h")]
        public static unsafe void Vector2DivideByVector(this Assimp thisApi, Span<System.Numerics.Vector2> dst, System.Numerics.Vector2* v)
        {
            // SpanOverloader
            thisApi.Vector2DivideByVector(ref dst.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 648, Column 17 in cimport.h")]
        public static unsafe void Vector2DivideByVector(this Assimp thisApi, Span<System.Numerics.Vector2> dst, Span<System.Numerics.Vector2> v)
        {
            // SpanOverloader
            thisApi.Vector2DivideByVector(ref dst.GetPinnableReference(), ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 656, Column 20 in cimport.h")]
        public static unsafe float Vector2Length(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> v)
        {
            // SpanOverloader
            return thisApi.Vector2Length(in v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 663, Column 20 in cimport.h")]
        public static unsafe float Vector2SquareLength(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> v)
        {
            // SpanOverloader
            return thisApi.Vector2SquareLength(in v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 670, Column 17 in cimport.h")]
        public static unsafe void Vector2Negate(this Assimp thisApi, Span<System.Numerics.Vector2> dst)
        {
            // SpanOverloader
            thisApi.Vector2Negate(ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 679, Column 20 in cimport.h")]
        public static unsafe float Vector2DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b)
        {
            // SpanOverloader
            return thisApi.Vector2DotProduct(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 679, Column 20 in cimport.h")]
        public static unsafe float Vector2DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* b)
        {
            // SpanOverloader
            return thisApi.Vector2DotProduct(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 679, Column 20 in cimport.h")]
        public static unsafe float Vector2DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> b)
        {
            // SpanOverloader
            return thisApi.Vector2DotProduct(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 687, Column 17 in cimport.h")]
        public static unsafe void Vector2Normalize(this Assimp thisApi, Span<System.Numerics.Vector2> v)
        {
            // SpanOverloader
            thisApi.Vector2Normalize(ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 697, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqualEpsilon(a, in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqualEpsilon(in a.GetPinnableReference(), b, epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 709, Column 16 in cimport.h")]
        public static unsafe int Vector3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Vector3AreEqualEpsilon(in a.GetPinnableReference(), in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 16 in cimport.h")]
        public static unsafe int Vector3LessThan(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3LessThan(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 16 in cimport.h")]
        public static unsafe int Vector3LessThan(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            return thisApi.Vector3LessThan(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 722, Column 16 in cimport.h")]
        public static unsafe int Vector3LessThan(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3LessThan(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        public static unsafe void Vector3Add(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> src)
        {
            // SpanOverloader
            thisApi.Vector3Add(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        public static unsafe void Vector3Add(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src)
        {
            // SpanOverloader
            thisApi.Vector3Add(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 731, Column 17 in cimport.h")]
        public static unsafe void Vector3Add(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> src)
        {
            // SpanOverloader
            thisApi.Vector3Add(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in cimport.h")]
        public static unsafe void Vector3Subtract(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> src)
        {
            // SpanOverloader
            thisApi.Vector3Subtract(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in cimport.h")]
        public static unsafe void Vector3Subtract(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* src)
        {
            // SpanOverloader
            thisApi.Vector3Subtract(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 740, Column 17 in cimport.h")]
        public static unsafe void Vector3Subtract(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> src)
        {
            // SpanOverloader
            thisApi.Vector3Subtract(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 749, Column 17 in cimport.h")]
        public static unsafe void Vector3Scale(this Assimp thisApi, Span<System.Numerics.Vector3> dst, float s)
        {
            // SpanOverloader
            thisApi.Vector3Scale(ref dst.GetPinnableReference(), s);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in cimport.h")]
        public static unsafe void Vector3SymMul(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> other)
        {
            // SpanOverloader
            thisApi.Vector3SymMul(dst, in other.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in cimport.h")]
        public static unsafe void Vector3SymMul(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* other)
        {
            // SpanOverloader
            thisApi.Vector3SymMul(ref dst.GetPinnableReference(), other);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 759, Column 17 in cimport.h")]
        public static unsafe void Vector3SymMul(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> other)
        {
            // SpanOverloader
            thisApi.Vector3SymMul(ref dst.GetPinnableReference(), in other.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 768, Column 17 in cimport.h")]
        public static unsafe void Vector3DivideByScalar(this Assimp thisApi, Span<System.Numerics.Vector3> dst, float s)
        {
            // SpanOverloader
            thisApi.Vector3DivideByScalar(ref dst.GetPinnableReference(), s);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 17 in cimport.h")]
        public static unsafe void Vector3DivideByVector(this Assimp thisApi, System.Numerics.Vector3* dst, Span<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            thisApi.Vector3DivideByVector(dst, ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 17 in cimport.h")]
        public static unsafe void Vector3DivideByVector(this Assimp thisApi, Span<System.Numerics.Vector3> dst, System.Numerics.Vector3* v)
        {
            // SpanOverloader
            thisApi.Vector3DivideByVector(ref dst.GetPinnableReference(), v);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 778, Column 17 in cimport.h")]
        public static unsafe void Vector3DivideByVector(this Assimp thisApi, Span<System.Numerics.Vector3> dst, Span<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            thisApi.Vector3DivideByVector(ref dst.GetPinnableReference(), ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 786, Column 20 in cimport.h")]
        public static unsafe float Vector3Length(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            return thisApi.Vector3Length(in v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 793, Column 20 in cimport.h")]
        public static unsafe float Vector3SquareLength(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            return thisApi.Vector3SquareLength(in v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 800, Column 17 in cimport.h")]
        public static unsafe void Vector3Negate(this Assimp thisApi, Span<System.Numerics.Vector3> dst)
        {
            // SpanOverloader
            thisApi.Vector3Negate(ref dst.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 20 in cimport.h")]
        public static unsafe float Vector3DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3DotProduct(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 20 in cimport.h")]
        public static unsafe float Vector3DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            return thisApi.Vector3DotProduct(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 809, Column 20 in cimport.h")]
        public static unsafe float Vector3DotProduct(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            return thisApi.Vector3DotProduct(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(dst, a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(dst, in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, System.Numerics.Vector3* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(dst, in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(ref dst.GetPinnableReference(), a, b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(ref dst.GetPinnableReference(), a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(ref dst.GetPinnableReference(), in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 820, Column 17 in cimport.h")]
        public static unsafe void Vector3CrossProduct(this Assimp thisApi, Span<System.Numerics.Vector3> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> b)
        {
            // SpanOverloader
            thisApi.Vector3CrossProduct(ref dst.GetPinnableReference(), in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 829, Column 17 in cimport.h")]
        public static unsafe void Vector3Normalize(this Assimp thisApi, Span<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            thisApi.Vector3Normalize(ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 836, Column 17 in cimport.h")]
        public static unsafe void Vector3NormalizeSafe(this Assimp thisApi, Span<System.Numerics.Vector3> v)
        {
            // SpanOverloader
            thisApi.Vector3NormalizeSafe(ref v.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        public static unsafe void Vector3RotateByQuaternion(this Assimp thisApi, System.Numerics.Vector3* v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.Vector3RotateByQuaternion(v, in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        public static unsafe void Vector3RotateByQuaternion(this Assimp thisApi, Span<System.Numerics.Vector3> v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q)
        {
            // SpanOverloader
            thisApi.Vector3RotateByQuaternion(ref v.GetPinnableReference(), q);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 844, Column 17 in cimport.h")]
        public static unsafe void Vector3RotateByQuaternion(this Assimp thisApi, Span<System.Numerics.Vector3> v, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.Vector3RotateByQuaternion(ref v.GetPinnableReference(), in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromMatrix4(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.Matrix3FromMatrix4(dst, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromMatrix4(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat)
        {
            // SpanOverloader
            thisApi.Matrix3FromMatrix4(ref dst.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 853, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromMatrix4(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.Matrix3FromMatrix4(ref dst.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromQuaternion(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.Matrix3FromQuaternion(mat, in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromQuaternion(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q)
        {
            // SpanOverloader
            thisApi.Matrix3FromQuaternion(ref mat.GetPinnableReference(), q);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 862, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromQuaternion(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.Matrix3FromQuaternion(ref mat.GetPinnableReference(), in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> b)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 873, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> b)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqualEpsilon(a, in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqualEpsilon(in a.GetPinnableReference(), b, epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 885, Column 16 in cimport.h")]
        public static unsafe int Matrix3AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix3AreEqualEpsilon(in a.GetPinnableReference(), in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 894, Column 17 in cimport.h")]
        public static unsafe void Matrix3Inverse(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.Matrix3Inverse(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 901, Column 20 in cimport.h")]
        public static unsafe float Matrix3Determinant(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            return thisApi.Matrix3Determinant(in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 909, Column 17 in cimport.h")]
        public static unsafe void Matrix3RotationZ(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, float angle)
        {
            // SpanOverloader
            thisApi.Matrix3RotationZ(ref mat.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromRotationAroundAxis(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix3FromRotationAroundAxis(mat, in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromRotationAroundAxis(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix3FromRotationAroundAxis(ref mat.GetPinnableReference(), axis, angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 919, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromRotationAroundAxis(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix3FromRotationAroundAxis(ref mat.GetPinnableReference(), in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 17 in cimport.h")]
        public static unsafe void Matrix3Translation(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> translation)
        {
            // SpanOverloader
            thisApi.Matrix3Translation(mat, in translation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 17 in cimport.h")]
        public static unsafe void Matrix3Translation(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector2* translation)
        {
            // SpanOverloader
            thisApi.Matrix3Translation(ref mat.GetPinnableReference(), translation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 929, Column 17 in cimport.h")]
        public static unsafe void Matrix3Translation(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector2> translation)
        {
            // SpanOverloader
            thisApi.Matrix3Translation(ref mat.GetPinnableReference(), in translation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(mat, from, in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(mat, in from.GetPinnableReference(), to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Silk.NET.Maths.Matrix3X3<float>* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(mat, in from.GetPinnableReference(), in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(ref mat.GetPinnableReference(), from, to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(ref mat.GetPinnableReference(), from, in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(ref mat.GetPinnableReference(), in from.GetPinnableReference(), to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 939, Column 17 in cimport.h")]
        public static unsafe void Matrix3FromTo(this Assimp thisApi, Span<Silk.NET.Maths.Matrix3X3<float>> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix3FromTo(ref mat.GetPinnableReference(), in from.GetPinnableReference(), in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 949, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromMatrix3(this Assimp thisApi, System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.Matrix4FromMatrix3(dst, in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 949, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromMatrix3(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Matrix3X3<float>* mat)
        {
            // SpanOverloader
            thisApi.Matrix4FromMatrix3(ref dst.GetPinnableReference(), mat);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 949, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromMatrix3(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Matrix3X3<float>> mat)
        {
            // SpanOverloader
            thisApi.Matrix4FromMatrix3(ref dst.GetPinnableReference(), in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, scaling, rotation, in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, scaling, in rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, scaling, in rotation.GetPinnableReference(), in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, in scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, in scaling.GetPinnableReference(), rotation, in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, in scaling.GetPinnableReference(), in rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(mat, in scaling.GetPinnableReference(), in rotation.GetPinnableReference(), in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), scaling, rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), scaling, rotation, in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), scaling, in rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), scaling, in rotation.GetPinnableReference(), in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), in scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), in scaling.GetPinnableReference(), rotation, in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), in scaling.GetPinnableReference(), in rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 960, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromScalingQuaternionPosition(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> rotation, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4FromScalingQuaternionPosition(ref mat.GetPinnableReference(), in scaling.GetPinnableReference(), in rotation.GetPinnableReference(), in position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 17 in cimport.h")]
        public static unsafe void Matrix4Add(this Assimp thisApi, System.Numerics.Matrix4x4* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.Matrix4Add(dst, in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 17 in cimport.h")]
        public static unsafe void Matrix4Add(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* src)
        {
            // SpanOverloader
            thisApi.Matrix4Add(ref dst.GetPinnableReference(), src);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 971, Column 17 in cimport.h")]
        public static unsafe void Matrix4Add(this Assimp thisApi, Span<System.Numerics.Matrix4x4> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> src)
        {
            // SpanOverloader
            thisApi.Matrix4Add(ref dst.GetPinnableReference(), in src.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> b)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 982, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> b)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqualEpsilon(a, in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqualEpsilon(in a.GetPinnableReference(), b, epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 994, Column 16 in cimport.h")]
        public static unsafe int Matrix4AreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.Matrix4AreEqualEpsilon(in a.GetPinnableReference(), in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1003, Column 17 in cimport.h")]
        public static unsafe void Matrix4Inverse(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            thisApi.Matrix4Inverse(ref mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1011, Column 20 in cimport.h")]
        public static unsafe float Matrix4Determinant(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            return thisApi.Matrix4Determinant(in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1020, Column 16 in cimport.h")]
        public static unsafe int Matrix4IsIdentity(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat)
        {
            // SpanOverloader
            return thisApi.Matrix4IsIdentity(in mat.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(mat, ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), scaling, rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), scaling, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), scaling, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1032, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingEulerAnglesPosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingEulerAnglesPosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, axis, angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, axis, ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, axis, ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, ref axis.GetPinnableReference(), angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, ref axis.GetPinnableReference(), angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, scaling, ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), axis, angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), axis, angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), axis, ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), axis, ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(mat, ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, axis, angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, axis, angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, axis, ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, System.Numerics.Vector3* axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, axis, ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, ref axis.GetPinnableReference(), angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, ref axis.GetPinnableReference(), angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, System.Numerics.Vector3* scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), scaling, ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), axis, angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), axis, angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), axis, ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, System.Numerics.Vector3* axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), axis, ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, float* angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), angle, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, float* angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), angle, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1049, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeIntoScalingAxisAnglePosition(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<System.Numerics.Vector3> scaling, Span<System.Numerics.Vector3> axis, Span<float> angle, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeIntoScalingAxisAnglePosition(in mat.GetPinnableReference(), ref scaling.GetPinnableReference(), ref axis.GetPinnableReference(), ref angle.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(mat, rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(mat, ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Matrix4x4* mat, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(mat, ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, AssimpQuaternion* rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(in mat.GetPinnableReference(), rotation, position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, AssimpQuaternion* rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(in mat.GetPinnableReference(), rotation, ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<AssimpQuaternion> rotation, System.Numerics.Vector3* position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(in mat.GetPinnableReference(), ref rotation.GetPinnableReference(), position);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1064, Column 17 in cimport.h")]
        public static unsafe void Matrix4DecomposeNoScaling(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Matrix4x4> mat, Span<AssimpQuaternion> rotation, Span<System.Numerics.Vector3> position)
        {
            // SpanOverloader
            thisApi.Matrix4DecomposeNoScaling(in mat.GetPinnableReference(), ref rotation.GetPinnableReference(), ref position.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1076, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromEulerAngles(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, float x, float y, float z)
        {
            // SpanOverloader
            thisApi.Matrix4FromEulerAngles(ref mat.GetPinnableReference(), x, y, z);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1085, Column 17 in cimport.h")]
        public static unsafe void Matrix4RotationX(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4RotationX(ref mat.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1094, Column 17 in cimport.h")]
        public static unsafe void Matrix4RotationY(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4RotationY(ref mat.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1103, Column 17 in cimport.h")]
        public static unsafe void Matrix4RotationZ(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4RotationZ(ref mat.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1113, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromRotationAroundAxis(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4FromRotationAroundAxis(mat, in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1113, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromRotationAroundAxis(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4FromRotationAroundAxis(ref mat.GetPinnableReference(), axis, angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1113, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromRotationAroundAxis(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.Matrix4FromRotationAroundAxis(ref mat.GetPinnableReference(), in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        public static unsafe void Matrix4Translation(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> translation)
        {
            // SpanOverloader
            thisApi.Matrix4Translation(mat, in translation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        public static unsafe void Matrix4Translation(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* translation)
        {
            // SpanOverloader
            thisApi.Matrix4Translation(ref mat.GetPinnableReference(), translation);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1123, Column 17 in cimport.h")]
        public static unsafe void Matrix4Translation(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> translation)
        {
            // SpanOverloader
            thisApi.Matrix4Translation(ref mat.GetPinnableReference(), in translation.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 17 in cimport.h")]
        public static unsafe void Matrix4Scaling(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling)
        {
            // SpanOverloader
            thisApi.Matrix4Scaling(mat, in scaling.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 17 in cimport.h")]
        public static unsafe void Matrix4Scaling(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* scaling)
        {
            // SpanOverloader
            thisApi.Matrix4Scaling(ref mat.GetPinnableReference(), scaling);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1132, Column 17 in cimport.h")]
        public static unsafe void Matrix4Scaling(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> scaling)
        {
            // SpanOverloader
            thisApi.Matrix4Scaling(ref mat.GetPinnableReference(), in scaling.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(mat, from, in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(mat, in from.GetPinnableReference(), to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, System.Numerics.Matrix4x4* mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(mat, in from.GetPinnableReference(), in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(ref mat.GetPinnableReference(), from, to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(ref mat.GetPinnableReference(), from, in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(ref mat.GetPinnableReference(), in from.GetPinnableReference(), to);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1142, Column 17 in cimport.h")]
        public static unsafe void Matrix4FromTo(this Assimp thisApi, Span<System.Numerics.Matrix4x4> mat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> from, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> to)
        {
            // SpanOverloader
            thisApi.Matrix4FromTo(ref mat.GetPinnableReference(), in from.GetPinnableReference(), in to.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1154, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromEulerAngles(this Assimp thisApi, Span<AssimpQuaternion> q, float x, float y, float z)
        {
            // SpanOverloader
            thisApi.QuaternionFromEulerAngles(ref q.GetPinnableReference(), x, y, z);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1164, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromAxisAngle(this Assimp thisApi, AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.QuaternionFromAxisAngle(q, in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1164, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromAxisAngle(this Assimp thisApi, Span<AssimpQuaternion> q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* axis, float angle)
        {
            // SpanOverloader
            thisApi.QuaternionFromAxisAngle(ref q.GetPinnableReference(), axis, angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1164, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromAxisAngle(this Assimp thisApi, Span<AssimpQuaternion> q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> axis, float angle)
        {
            // SpanOverloader
            thisApi.QuaternionFromAxisAngle(ref q.GetPinnableReference(), in axis.GetPinnableReference(), angle);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1175, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromNormalizedQuaternion(this Assimp thisApi, AssimpQuaternion* q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> normalized)
        {
            // SpanOverloader
            thisApi.QuaternionFromNormalizedQuaternion(q, in normalized.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1175, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromNormalizedQuaternion(this Assimp thisApi, Span<AssimpQuaternion> q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] System.Numerics.Vector3* normalized)
        {
            // SpanOverloader
            thisApi.QuaternionFromNormalizedQuaternion(ref q.GetPinnableReference(), normalized);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1175, Column 17 in cimport.h")]
        public static unsafe void QuaternionFromNormalizedQuaternion(this Assimp thisApi, Span<AssimpQuaternion> q, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<System.Numerics.Vector3> normalized)
        {
            // SpanOverloader
            thisApi.QuaternionFromNormalizedQuaternion(ref q.GetPinnableReference(), in normalized.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1186, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> b)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqual(a, in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1186, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqual(in a.GetPinnableReference(), b);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1186, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqual(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> b)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqual(in a.GetPinnableReference(), in b.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqualEpsilon(a, in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* b, float epsilon)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqualEpsilon(in a.GetPinnableReference(), b, epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1198, Column 16 in cimport.h")]
        public static unsafe int QuaternionAreEqualEpsilon(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> a, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> b, float epsilon)
        {
            // SpanOverloader
            return thisApi.QuaternionAreEqualEpsilon(in a.GetPinnableReference(), in b.GetPinnableReference(), epsilon);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1207, Column 17 in cimport.h")]
        public static unsafe void QuaternionNormalize(this Assimp thisApi, Span<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.QuaternionNormalize(ref q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1215, Column 17 in cimport.h")]
        public static unsafe void QuaternionConjugate(this Assimp thisApi, Span<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.QuaternionConjugate(ref q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1223, Column 17 in cimport.h")]
        public static unsafe void QuaternionMultiply(this Assimp thisApi, AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.QuaternionMultiply(dst, in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1223, Column 17 in cimport.h")]
        public static unsafe void QuaternionMultiply(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* q)
        {
            // SpanOverloader
            thisApi.QuaternionMultiply(ref dst.GetPinnableReference(), q);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1223, Column 17 in cimport.h")]
        public static unsafe void QuaternionMultiply(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> q)
        {
            // SpanOverloader
            thisApi.QuaternionMultiply(ref dst.GetPinnableReference(), in q.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(dst, start, in end.GetPinnableReference(), factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(dst, in start.GetPinnableReference(), end, factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, AssimpQuaternion* dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(dst, in start.GetPinnableReference(), in end.GetPinnableReference(), factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(ref dst.GetPinnableReference(), start, end, factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(ref dst.GetPinnableReference(), start, in end.GetPinnableReference(), factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AssimpQuaternion* end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(ref dst.GetPinnableReference(), in start.GetPinnableReference(), end, factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1234, Column 17 in cimport.h")]
        public static unsafe void QuaternionInterpolate(this Assimp thisApi, Span<AssimpQuaternion> dst, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<AssimpQuaternion> end, float factor)
        {
            // SpanOverloader
            thisApi.QuaternionInterpolate(ref dst.GetPinnableReference(), in start.GetPinnableReference(), in end.GetPinnableReference(), factor);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(pMat, in pKey.GetPinnableReference(), type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(pMat, in pKey.GetPinnableReference(), type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] MaterialProperty** pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1522, Column 28 in material.h")]
        public static unsafe Return GetMaterialProperty(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly MaterialProperty* pPropOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialProperty(in pMat.GetPinnableReference(), pKey, type, index, in pPropOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, in pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, in pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1555, Column 28 in material.h")]
        public static unsafe Return GetMaterialFloatArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<float> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialFloatArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, in pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, in pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(pMat, pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, pOut, ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, uint* pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), pMax);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1595, Column 28 in material.h")]
        public static unsafe Return GetMaterialIntegerArray(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<int> pOut, Span<uint> pMax)
        {
            // SpanOverloader
            return thisApi.GetMaterialIntegerArray(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference(), ref pMax.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1620, Column 28 in material.h")]
        public static unsafe Return GetMaterialColor(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<System.Numerics.Vector4> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialColor(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1631, Column 28 in material.h")]
        public static unsafe Return GetMaterialUVTransform(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<UVTransform> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialUVTransform(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(pMat, pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), in pKey.GetPinnableReference(), type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, pOut);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1642, Column 28 in material.h")]
        public static unsafe Return GetMaterialString(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, Span<AssimpString> pOut)
        {
            // SpanOverloader
            return thisApi.GetMaterialString(in pMat.GetPinnableReference(), pKey, type, index, ref pOut.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1655, Column 25 in material.h")]
        public static unsafe uint GetMaterialTextureCount(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> pMat, TextureType type)
        {
            // SpanOverloader
            return thisApi.GetMaterialTextureCount(in pMat.GetPinnableReference(), type);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Material* mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(mat, type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, AssimpString* path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, path, ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, TextureMapping* mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), mapping, ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, uint* uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), uvindex, ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, float* blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), blend, ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, TextureOp* op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), op, ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, TextureMapMode* mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), mapmode, ref flags.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, uint* flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), flags);
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1696, Column 21 in material.h")]
        public static unsafe Return GetMaterialTexture(this Assimp thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Material> mat, TextureType type, uint index, Span<AssimpString> path, Span<TextureMapping> mapping, Span<uint> uvindex, Span<float> blend, Span<TextureOp> op, Span<TextureMapMode> mapmode, Span<uint> flags)
        {
            // SpanOverloader
            return thisApi.GetMaterialTexture(in mat.GetPinnableReference(), type, index, ref path.GetPinnableReference(), ref mapping.GetPinnableReference(), ref uvindex.GetPinnableReference(), ref blend.GetPinnableReference(), ref op.GetPinnableReference(), ref mapmode.GetPinnableReference(), ref flags.GetPinnableReference());
        }

    }
}

