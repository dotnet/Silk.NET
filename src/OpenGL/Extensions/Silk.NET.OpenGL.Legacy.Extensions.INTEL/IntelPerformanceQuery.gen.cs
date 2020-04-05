// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    [Extension("INTEL_performance_query")]
    public abstract unsafe partial class IntelPerformanceQuery : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginPerfQueryINTEL")]
        public abstract void BeginPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        public abstract unsafe void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* queryHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glCreatePerfQueryINTEL")]
        public abstract void CreatePerfQuery([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] Span<uint> queryHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glDeletePerfQueryINTEL")]
        public abstract void DeletePerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndPerfQueryINTEL")]
        public abstract void EndPerfQuery([Flow(FlowDirection.In)] uint queryHandle);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        public abstract unsafe void GetFirstPerfQueryId([Flow(FlowDirection.Out)] uint* queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetFirstPerfQueryIdINTEL")]
        public abstract void GetFirstPerfQueryId([Flow(FlowDirection.Out)] Span<uint> queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        public abstract unsafe void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] uint* nextQueryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetNextPerfQueryIdINTEL")]
        public abstract void GetNextPerfQueryId([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.Out)] Span<uint> nextQueryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public abstract unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] char* counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] char* counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public abstract void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] Span<char> counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] Span<char> counterDesc, [Flow(FlowDirection.Out)] Span<uint> counterOffset, [Flow(FlowDirection.Out)] Span<uint> counterDataSize, [Flow(FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(FlowDirection.Out)] Span<ulong> rawCounterMaxValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public abstract unsafe void GetPerfQueryData([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] void* data, [Flow(FlowDirection.Out)] uint* bytesWritten);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryDataINTEL")]
        public abstract void GetPerfQueryData<T0>([Flow(FlowDirection.In)] uint queryHandle, [Flow(FlowDirection.In)] uint flags, [Flow(FlowDirection.In)] uint dataSize, [Flow(FlowDirection.Out)] Span<T0> data, [Flow(FlowDirection.Out)] Span<uint> bytesWritten) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public abstract unsafe void GetPerfQueryIdByName([Flow(FlowDirection.Out)] char* queryName, [Flow(FlowDirection.Out)] uint* queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public abstract void GetPerfQueryIdByName([Flow(FlowDirection.Out)] Span<char> queryName, [Flow(FlowDirection.Out)] Span<uint> queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public abstract unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] char* queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public abstract void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] Span<char> queryName, [Flow(FlowDirection.Out)] Span<uint> dataSize, [Flow(FlowDirection.Out)] Span<uint> noCounters, [Flow(FlowDirection.Out)] Span<uint> noInstances, [Flow(FlowDirection.Out)] Span<uint> capsMask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public abstract unsafe void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] uint* counterOffset, [Flow(FlowDirection.Out)] uint* counterDataSize, [Flow(FlowDirection.Out)] uint* counterTypeEnum, [Flow(FlowDirection.Out)] uint* counterDataTypeEnum, [Flow(FlowDirection.Out)] ulong* rawCounterMaxValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfCounterInfoINTEL")]
        public abstract void GetPerfCounterInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint counterId, [Flow(FlowDirection.In)] uint counterNameLength, [Flow(FlowDirection.Out)] string counterName, [Flow(FlowDirection.In)] uint counterDescLength, [Flow(FlowDirection.Out)] string counterDesc, [Flow(FlowDirection.Out)] Span<uint> counterOffset, [Flow(FlowDirection.Out)] Span<uint> counterDataSize, [Flow(FlowDirection.Out)] Span<uint> counterTypeEnum, [Flow(FlowDirection.Out)] Span<uint> counterDataTypeEnum, [Flow(FlowDirection.Out)] Span<ulong> rawCounterMaxValue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public abstract unsafe void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryIdByNameINTEL")]
        public abstract void GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] Span<uint> queryId);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public abstract unsafe void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] uint* dataSize, [Flow(FlowDirection.Out)] uint* noCounters, [Flow(FlowDirection.Out)] uint* noInstances, [Flow(FlowDirection.Out)] uint* capsMask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetPerfQueryInfoINTEL")]
        public abstract void GetPerfQueryInfo([Flow(FlowDirection.In)] uint queryId, [Flow(FlowDirection.In)] uint queryNameLength, [Flow(FlowDirection.Out)] string queryName, [Flow(FlowDirection.Out)] Span<uint> dataSize, [Flow(FlowDirection.Out)] Span<uint> noCounters, [Flow(FlowDirection.Out)] Span<uint> noInstances, [Flow(FlowDirection.Out)] Span<uint> capsMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="queryHandle">
        /// To be added.
        /// </param>
        public unsafe uint CreatePerfQuery()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            CreatePerfQuery(queryId, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        public unsafe uint GetFirstPerfQueryId()
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetFirstPerfQueryId(&ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        /// <param name="nextQueryId">
        /// To be added.
        /// </param>
        public unsafe uint GetNextPerfQueryId()
        {
            const uint queryId = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GetNextPerfQueryId(queryId, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] char* queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="queryName">
        /// To be added.
        /// </param>
        /// <param name="queryId">
        /// To be added.
        /// </param>
        public unsafe uint GetPerfQueryIdByName([Flow(FlowDirection.Out)] string queryName)
        {
            // ReturnTypeOverloader
            uint ret = default;
            GetPerfQueryIdByName(queryName, &ret);
            return ret;
        }

        public IntelPerformanceQuery(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

