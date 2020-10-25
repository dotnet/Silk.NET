// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.INTEL
{
    [Extension("INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_performance_query";
        [NativeApi(EntryPoint = "glBeginPerfQueryINTEL")]
        public partial void BeginPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        public unsafe partial void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* queryHandle);

        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        public partial void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] out uint queryHandle);

        [NativeApi(EntryPoint = "glDeletePerfQueryINTEL")]
        public partial void DeletePerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glEndPerfQueryINTEL")]
        public partial void EndPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        public unsafe partial void GetFirstPerfQueryId([Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        public partial void GetFirstPerfQueryId([Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        public unsafe partial void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* nextQueryId);

        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        public partial void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] out uint nextQueryId);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] byte* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] out byte counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] byte* counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] out byte counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public unsafe partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public partial void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] out uint counterOffset, [Flow(FlowDirection.Out)] out uint counterDataSize, [Flow(FlowDirection.Out)] out uint counterTypeEnum, [Flow(FlowDirection.Out)] out uint counterDataTypeEnum, [Flow(FlowDirection.Out)] out ulong rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public unsafe partial void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] uint* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public unsafe partial void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] out uint bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public unsafe partial void GetPerfQueryData<T0>([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] out T0 data, [Flow(FlowDirection.Out)] uint* bytesWritten) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public partial void GetPerfQueryData<T0>([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] out T0 data, [Flow(FlowDirection.Out)] out uint bytesWritten) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public unsafe partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public partial void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] byte* queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] out byte queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public unsafe partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public partial void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] out uint dataSize, [Flow(FlowDirection.Out)] out uint noCounters, [Flow(FlowDirection.Out)] out uint noInstances, [Flow(FlowDirection.Out)] out uint capsMask);

        public unsafe uint CreatePerfQuery()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreatePerfQuery(queryId, &ret);
            return ret;
        }

        public unsafe uint GetFirstPerfQueryId()
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetFirstPerfQueryId(&ret);
            return ret;
        }

        public unsafe uint GetNextPerfQueryId()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetNextPerfQueryId(queryId, &ret);
            return ret;
        }

        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] byte* queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

