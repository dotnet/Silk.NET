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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.ML
{
    [Extension("XR_ML_localization_map")]
    public unsafe partial class MLLocalizationMap : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_localization_map";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateExportedLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExportedLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* mapUuid, [Count(Count = 0)] ExportedLocalizationMapML* map);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateExportedLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExportedLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] UuidEXT* mapUuid, [Count(Count = 0)] ref ExportedLocalizationMapML map);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateExportedLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateExportedLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UuidEXT mapUuid, [Count(Count = 0)] ExportedLocalizationMapML* map);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateExportedLocalizationMapML", Convention = CallingConvention.Winapi)]
        public partial Result CreateExportedLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in UuidEXT mapUuid, [Count(Count = 0)] ref ExportedLocalizationMapML map);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyExportedLocalizationMapML", Convention = CallingConvention.Winapi)]
        public partial Result DestroyExportedLocalizationMapML([Count(Count = 0)] ExportedLocalizationMapML map);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnableLocalizationEventsML", Convention = CallingConvention.Winapi)]
        public partial Result EnableLocalizationEventsML([Count(Count = 0)] Session session, [Count(Count = 0)] LocalizationEnableEventsInfoML info);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetExportedLocalizationMapDataML", Convention = CallingConvention.Winapi)]
        public partial Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrImportLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapImportInfoML* importInfo, [Count(Count = 0)] UuidEXT* mapUuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrImportLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapImportInfoML* importInfo, [Count(Count = 0)] ref UuidEXT mapUuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrImportLocalizationMapML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result ImportLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LocalizationMapImportInfoML importInfo, [Count(Count = 0)] UuidEXT* mapUuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrImportLocalizationMapML", Convention = CallingConvention.Winapi)]
        public partial Result ImportLocalizationMapML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LocalizationMapImportInfoML importInfo, [Count(Count = 0)] ref UuidEXT mapUuid);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryLocalizationMapsML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] LocalizationMapML* maps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryLocalizationMapsML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] ref LocalizationMapML maps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryLocalizationMapsML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LocalizationMapQueryInfoBaseHeaderML queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] LocalizationMapML* maps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrQueryLocalizationMapsML", Convention = CallingConvention.Winapi)]
        public partial Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LocalizationMapQueryInfoBaseHeaderML queryInfo, [Count(Count = 0)] uint mapCapacityInput, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] ref LocalizationMapML maps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestMapLocalizationML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result RequestMapLocalizationML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MapLocalizationRequestInfoML* requestInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrRequestMapLocalizationML", Convention = CallingConvention.Winapi)]
        public partial Result RequestMapLocalizationML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MapLocalizationRequestInfoML requestInfo);

        /// <summary>To be documented.</summary>
        public unsafe Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetExportedLocalizationMapDataML(map, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetExportedLocalizationMapDataML([Count(Count = 0)] ExportedLocalizationMapML map, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetExportedLocalizationMapDataML(map, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] LocalizationMapQueryInfoBaseHeaderML* queryInfo, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] Span<LocalizationMapML> maps)
        {
            // ImplicitCountSpanOverloader
            return QueryLocalizationMapsML(session, queryInfo, (uint) maps.Length, mapCountOutput, ref maps.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueryLocalizationMapsML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LocalizationMapQueryInfoBaseHeaderML queryInfo, [Count(Count = 0)] uint mapCountOutput, [Count(Parameter = "mapCapacityInput")] Span<LocalizationMapML> maps)
        {
            // ImplicitCountSpanOverloader
            return QueryLocalizationMapsML(session, in queryInfo, (uint) maps.Length, mapCountOutput, ref maps.GetPinnableReference());
        }

        public MLLocalizationMap(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

