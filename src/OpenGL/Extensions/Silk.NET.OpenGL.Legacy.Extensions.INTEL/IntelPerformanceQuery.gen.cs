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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_performance_query")]
    public unsafe partial class IntelPerformanceQuery : NativeExtension<GL>
    {
        public const string ExtensionName = "INTEL_performance_query";
        [NativeApi(EntryPoint = "glBeginPerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void BeginPerfQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void CreatePerfQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* queryHandle);

        [NativeApi(EntryPoint = "glDeletePerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void DeletePerfQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glEndPerfQueryINTEL", Convention = CallingConvention.Winapi)]
        public partial void EndPerfQuery([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle);

        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetFirstPerfQueryId([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetNextPerfQueryId([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* nextQueryId);

        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfCounterInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterNameLength, [Count(Parameter = "counterNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint counterDescLength, [Count(Parameter = "counterDescLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* counterDesc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterOffset, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* rawCounterMaxValue);

        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryHandle, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint flags, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* data, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* bytesWritten);

        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryIdByName([Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* queryId);

        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPerfQueryInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryId, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint queryNameLength, [Count(Parameter = "queryNameLength"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] byte* queryName, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* dataSize, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noCounters, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* noInstances, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* capsMask);

        public IntelPerformanceQuery(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

