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

namespace Silk.NET.OpenXR.Extensions.ML
{
    public static class MLLocalizationMapOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExportedLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* mapUuid, [Count(Count = 0)] Span<ExportedLocalizationMapML> map)
        {
            // SpanOverloader
            return thisApi.CreateExportedLocalizationMapML(session, mapUuid, ref map.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExportedLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UuidEXT> mapUuid, [Count(Count = 0)] ExportedLocalizationMapML* map)
        {
            // SpanOverloader
            return thisApi.CreateExportedLocalizationMapML(session, in mapUuid.GetPinnableReference(), map);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateExportedLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<UuidEXT> mapUuid, [Count(Count = 0)] Span<ExportedLocalizationMapML> map)
        {
            // SpanOverloader
            return thisApi.CreateExportedLocalizationMapML(session, in mapUuid.GetPinnableReference(), ref map.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExportedLocalizationMapDataML(this MLLocalizationMap thisApi, [Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetExportedLocalizationMapDataML(map, bufferCapacityInput, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExportedLocalizationMapDataML(this MLLocalizationMap thisApi, [Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer)
        {
            // SpanOverloader
            return thisApi.GetExportedLocalizationMapDataML(map, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExportedLocalizationMapDataML(this MLLocalizationMap thisApi, [Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // SpanOverloader
            return thisApi.GetExportedLocalizationMapDataML(map, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetExportedLocalizationMapDataML(this MLLocalizationMap thisApi, [Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] Span<uint> bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer)
        {
            // SpanOverloader
            return thisApi.GetExportedLocalizationMapDataML(map, bufferCapacityInput, ref bufferCountOutput.GetPinnableReference(), buffer);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapImportInfoML* importInfo, [Count(Count = 0)] Span<UuidEXT> mapUuid)
        {
            // SpanOverloader
            return thisApi.ImportLocalizationMapML(session, importInfo, ref mapUuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LocalizationMapImportInfoML> importInfo, [Count(Count = 0)] UuidEXT* mapUuid)
        {
            // SpanOverloader
            return thisApi.ImportLocalizationMapML(session, in importInfo.GetPinnableReference(), mapUuid);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result ImportLocalizationMapML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LocalizationMapImportInfoML> importInfo, [Count(Count = 0)] Span<UuidEXT> mapUuid)
        {
            // SpanOverloader
            return thisApi.ImportLocalizationMapML(session, in importInfo.GetPinnableReference(), ref mapUuid.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueryLocalizationMapsML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] Span<LocalizationMapML> maps)
        {
            // SpanOverloader
            return thisApi.QueryLocalizationMapsML(session, queryInfo, mapCapacityInput, mapCountOutput, ref maps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueryLocalizationMapsML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LocalizationMapQueryInfoBaseHeaderML> queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] LocalizationMapML* maps)
        {
            // SpanOverloader
            return thisApi.QueryLocalizationMapsML(session, in queryInfo.GetPinnableReference(), mapCapacityInput, mapCountOutput, maps);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result QueryLocalizationMapsML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<LocalizationMapQueryInfoBaseHeaderML> queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] Span<LocalizationMapML> maps)
        {
            // SpanOverloader
            return thisApi.QueryLocalizationMapsML(session, in queryInfo.GetPinnableReference(), mapCapacityInput, mapCountOutput, ref maps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result RequestMapLocalizationML(this MLLocalizationMap thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<MapLocalizationRequestInfoML> requestInfo)
        {
            // SpanOverloader
            return thisApi.RequestMapLocalizationML(session, in requestInfo.GetPinnableReference());
        }

    }
}

