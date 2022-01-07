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
    public unsafe partial class Assimp : NativeAPI
    {
        [NativeName("Type", "const size_t")]
        [NativeName("Name", "MAXLEN")]
        public const nuint Maxlen = unchecked((nuint) 0x400);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 86, Column 19 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatCount")]
        public partial nuint GetExportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 96, Column 47 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiGetExportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportFormatDesc* GetExportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 103, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseExportFormatDescription([Flow(FlowDirection.In)] ExportFormatDesc* desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 103, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportFormatDescription", Convention = CallingConvention.Winapi)]
        public partial void ReleaseExportFormatDescription([Flow(FlowDirection.In)] in ExportFormatDesc desc);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] Scene* pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] Scene* pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] in Scene pIn, Scene** pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiCopyScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void CopyScene([Flow(FlowDirection.In)] in Scene pIn, ref Scene* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene", Convention = CallingConvention.Winapi)]
        public unsafe partial void FreeScene([Flow(FlowDirection.In)] Scene* pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 120, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiFreeScene", Convention = CallingConvention.Winapi)]
        public partial void FreeScene([Flow(FlowDirection.In)] in Scene pIn);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 161, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportScene", Convention = CallingConvention.Winapi)]
        public partial Return ExportScene([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, byte* pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, ref byte pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, FileIO* pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 182, Column 21 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneEx", Convention = CallingConvention.Winapi)]
        public partial Return ExportSceneEx([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFileName, ref FileIO pIO, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, ref byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] Scene* pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, byte* pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, ref byte pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 246, Column 45 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiExportSceneToBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial ExportDataBlob* ExportSceneToBlob([Flow(FlowDirection.In)] in Scene pScene, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFormatId, uint pPreprocessing);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseExportBlob([Flow(FlowDirection.In)] ExportDataBlob* pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 254, Column 17 in src/Assimp/Include\\assimp/cexport.h")]
        [NativeApi(EntryPoint = "aiReleaseExportBlob", Convention = CallingConvention.Winapi)]
        public partial void ReleaseExportBlob([Flow(FlowDirection.In)] in ExportDataBlob pData);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 43 in src/Assimp/Include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc(byte* extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 43 in src/Assimp/Include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc(ref byte extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 144, Column 43 in src/Assimp/Include\\assimp/importerdesc.h")]
        [NativeApi(EntryPoint = "aiGetImporterDesc", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImporterDesc([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string extension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile(byte* pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile(ref byte pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 114, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFile", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFile([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(byte* pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(byte* pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(ref byte pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx(ref byte pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 139, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileEx", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileEx([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(byte* pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties(ref byte pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, FileIO* pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 160, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileExWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileExWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pFile, uint pFlags, ref FileIO pFS, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 197, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemory", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemory([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(byte* pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties(ref byte pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, byte* pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, ref byte pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] PropertyStore* pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 231, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiImportFileFromMemoryWithProperties", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ImportFileFromMemoryWithProperties([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pBuffer, uint pLength, uint pFlags, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pHint, [Flow(FlowDirection.In)] in PropertyStore pProps);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ApplyPostProcessing([Flow(FlowDirection.In)] Scene* pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 253, Column 36 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiApplyPostProcessing", Convention = CallingConvention.Winapi)]
        public unsafe partial Scene* ApplyPostProcessing([Flow(FlowDirection.In)] in Scene pScene, uint pFlags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 277, Column 33 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, byte* file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 277, Column 33 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, ref byte file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 277, Column 33 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetPredefinedLogStream", Convention = CallingConvention.Winapi)]
        public partial LogStream GetPredefinedLogStream(DefaultLogStream pStreams, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string file);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 291, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial void AttachLogStream([Flow(FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 291, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiAttachLogStream", Convention = CallingConvention.Winapi)]
        public partial void AttachLogStream([Flow(FlowDirection.In)] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 301, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiEnableVerboseLogging", Convention = CallingConvention.Winapi)]
        public partial void EnableVerboseLogging(int d);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 28 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream", Convention = CallingConvention.Winapi)]
        public unsafe partial Return DetachLogStream([Flow(FlowDirection.In)] LogStream* stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 312, Column 28 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachLogStream", Convention = CallingConvention.Winapi)]
        public partial Return DetachLogStream([Flow(FlowDirection.In)] in LogStream stream);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 323, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDetachAllLogStreams")]
        public partial void DetachAllLogStreams();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleaseImport([Flow(FlowDirection.In)] Scene* pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 331, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleaseImport", Convention = CallingConvention.Winapi)]
        public partial void ReleaseImport([Flow(FlowDirection.In)] in Scene pScene);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 341, Column 24 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetErrorString")]
        public unsafe partial byte* GetErrorString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 341, Column 24 in src/Assimp/Include\\assimp/cimport.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetErrorString", Convention = CallingConvention.Winapi)]
        public partial string GetErrorStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 19 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public unsafe partial int IsExtensionSupported(byte* szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 19 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public partial int IsExtensionSupported(ref byte szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 350, Column 19 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIsExtensionSupported", Convention = CallingConvention.Winapi)]
        public partial int IsExtensionSupported([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szExtension);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetExtensionList(AssimpString* szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 361, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetExtensionList", Convention = CallingConvention.Winapi)]
        public partial void GetExtensionList(ref AssimpString szOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] Scene* pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] Scene* pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetMemoryRequirements([Flow(FlowDirection.In)] in Scene pIn, MemoryInfo* @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 369, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetMemoryRequirements", Convention = CallingConvention.Winapi)]
        public partial void GetMemoryRequirements([Flow(FlowDirection.In)] in Scene pIn, ref MemoryInfo @in);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 381, Column 38 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreatePropertyStore")]
        public unsafe partial PropertyStore* CreatePropertyStore();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore", Convention = CallingConvention.Winapi)]
        public unsafe partial void ReleasePropertyStore(PropertyStore* p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 387, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiReleasePropertyStore", Convention = CallingConvention.Winapi)]
        public partial void ReleasePropertyStore(ref PropertyStore p);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, ref byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyInteger(ref PropertyStore store, byte* szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyInteger(ref PropertyStore store, ref byte szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 401, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyInteger", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyInteger(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, int value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, ref byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyFloat(ref PropertyStore store, byte* szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyFloat(ref PropertyStore store, ref byte szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 418, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyFloat", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyFloat(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, float value);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, byte* szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, byte* szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, ref byte szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, ref byte szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, byte* szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, byte* szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, ref byte szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyString(ref PropertyStore store, ref byte szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyString(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] AssimpString* st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 435, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyString", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyString(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, [Flow(FlowDirection.In)] in AssimpString st);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, byte* szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, ref byte szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, ref byte szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(PropertyStore* store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, byte* szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, byte* szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, ref byte szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, ref byte szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void SetImportPropertyMatrix(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 452, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiSetImportPropertyMatrix", Convention = CallingConvention.Winapi)]
        public partial void SetImportPropertyMatrix(ref PropertyStore store, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string szName, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(System.Numerics.Quaternion* quat, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(System.Numerics.Quaternion* quat, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreateQuaternionFromMatrix(ref System.Numerics.Quaternion quat, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 463, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiCreateQuaternionFromMatrix", Convention = CallingConvention.Winapi)]
        public partial void CreateQuaternionFromMatrix(ref System.Numerics.Quaternion quat, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Quaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, System.Numerics.Vector3* scaling, ref System.Numerics.Quaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, System.Numerics.Quaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Quaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(System.Numerics.Matrix4x4* mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Quaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, System.Numerics.Quaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Quaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, System.Numerics.Vector3* scaling, ref System.Numerics.Quaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Quaternion* rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, System.Numerics.Quaternion* rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public unsafe partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Quaternion rotation, System.Numerics.Vector3* position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 477, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiDecomposeMatrix", Convention = CallingConvention.Winapi)]
        public partial void DecomposeMatrix(ref System.Numerics.Matrix4x4 mat, ref System.Numerics.Vector3 scaling, ref System.Numerics.Quaternion rotation, ref System.Numerics.Vector3 position);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransposeMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 487, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix4", Convention = CallingConvention.Winapi)]
        public partial void TransposeMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransposeMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 494, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransposeMatrix3", Convention = CallingConvention.Winapi)]
        public partial void TransposeMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(System.Numerics.Vector3* vec, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 502, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix3", Convention = CallingConvention.Winapi)]
        public partial void TransformVecByMatrix3(ref System.Numerics.Vector3 vec, ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(System.Numerics.Vector3* vec, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 511, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiTransformVecByMatrix4", Convention = CallingConvention.Winapi)]
        public partial void TransformVecByMatrix4(ref System.Numerics.Vector3 vec, ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(System.Numerics.Matrix4x4* dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, System.Numerics.Matrix4x4* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 520, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix4", Convention = CallingConvention.Winapi)]
        public partial void MultiplyMatrix4(ref System.Numerics.Matrix4x4 dst, ref System.Numerics.Matrix4x4 src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(Silk.NET.Maths.Matrix3X3<float>* dst, ref Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, Silk.NET.Maths.Matrix3X3<float>* src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 529, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiMultiplyMatrix3", Convention = CallingConvention.Winapi)]
        public partial void MultiplyMatrix3(ref Silk.NET.Maths.Matrix3X3<float> dst, ref Silk.NET.Maths.Matrix3X3<float> src);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 537, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3", Convention = CallingConvention.Winapi)]
        public unsafe partial void IdentityMatrix3(Silk.NET.Maths.Matrix3X3<float>* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 537, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix3", Convention = CallingConvention.Winapi)]
        public partial void IdentityMatrix3(ref Silk.NET.Maths.Matrix3X3<float> mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 544, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4", Convention = CallingConvention.Winapi)]
        public unsafe partial void IdentityMatrix4(System.Numerics.Matrix4x4* mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 544, Column 17 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiIdentityMatrix4", Convention = CallingConvention.Winapi)]
        public partial void IdentityMatrix4(ref System.Numerics.Matrix4x4 mat);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 551, Column 19 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatCount")]
        public partial nuint GetImportFormatCount();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 560, Column 43 in src/Assimp/Include\\assimp/cimport.h")]
        [NativeApi(EntryPoint = "aiGetImportFormatDescription", Convention = CallingConvention.Winapi)]
        public unsafe partial ImporterDesc* GetImportFormatDescription(nuint pIndex);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] MaterialProperty** pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1368, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialProperty", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialProperty([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, [Flow(FlowDirection.In)] in MaterialProperty* pPropOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, float* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1401, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialFloatArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialFloatArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref float pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, int* pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, uint* pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1454, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialIntegerArray", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialIntegerArray([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref int pOut, ref uint pMax);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, System.Numerics.Vector4* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1491, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialColor", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialColor([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref System.Numerics.Vector4 pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, UVTransform* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1503, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialUVTransform", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialUVTransform([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref UVTransform pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, ref byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] Material* pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, byte* pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, ref byte pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, AssimpString* pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1515, Column 28 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialString", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialString([Flow(FlowDirection.In)] in Material pMat, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pKey, uint type, uint index, ref AssimpString pOut);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 25 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount", Convention = CallingConvention.Winapi)]
        public unsafe partial uint GetMaterialTextureCount([Flow(FlowDirection.In)] Material* pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1528, Column 25 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTextureCount", Convention = CallingConvention.Winapi)]
        public partial uint GetMaterialTextureCount([Flow(FlowDirection.In)] in Material pMat, TextureType type);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] Material* mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, AssimpString* path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, TextureMapping* mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, uint* uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, float* blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, TextureOp* op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, TextureMapMode* mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public unsafe partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, uint* flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 1569, Column 21 in src/Assimp/Include\\assimp/material.h")]
        [NativeApi(EntryPoint = "aiGetMaterialTexture", Convention = CallingConvention.Winapi)]
        public partial Return GetMaterialTexture([Flow(FlowDirection.In)] in Material mat, TextureType type, uint index, ref AssimpString path, ref TextureMapping mapping, ref uint uvindex, ref float blend, ref TextureOp op, ref TextureMapMode mapmode, ref uint flags);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetLegalString")]
        public unsafe partial byte* GetLegalString();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 63, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetLegalString", Convention = CallingConvention.Winapi)]
        public partial string GetLegalStringS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 70, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMinor")]
        public partial uint GetVersionMinor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 77, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionMajor")]
        public partial uint GetVersionMajor();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 84, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetVersionRevision")]
        public partial uint GetVersionRevision();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 24 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetBranchName")]
        public unsafe partial byte* GetBranchName();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 90, Column 24 in src/Assimp/Include\\assimp/version.h")]
        [return: UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)]
        [NativeApi(EntryPoint = "aiGetBranchName", Convention = CallingConvention.Winapi)]
        public partial string GetBranchNameS();

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 108, Column 25 in src/Assimp/Include\\assimp/version.h")]
        [NativeApi(EntryPoint = "aiGetCompileFlags")]
        public partial uint GetCompileFlags();


        public Assimp(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

