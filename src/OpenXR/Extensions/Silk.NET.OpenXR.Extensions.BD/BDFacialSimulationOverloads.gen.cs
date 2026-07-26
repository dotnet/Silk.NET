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

namespace Silk.NET.OpenXR.Extensions.BD
{
    public static class BDFacialSimulationOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoBD* createInfo, [Count(Count = 0)] Span<FaceTrackerBD> tracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerBD(session, createInfo, ref tracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoBD> createInfo, [Count(Count = 0)] FaceTrackerBD* tracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerBD(session, in createInfo.GetPinnableReference(), tracker);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFaceTrackerBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FaceTrackerCreateInfoBD> createInfo, [Count(Count = 0)] Span<FaceTrackerBD> tracker)
        {
            // SpanOverloader
            return thisApi.CreateFaceTrackerBD(session, in createInfo.GetPinnableReference(), ref tracker.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateFacialSimulationModesBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<FacialSimulationModeBD> modes)
        {
            // SpanOverloader
            return thisApi.EnumerateFacialSimulationModesBD(session, modeCapacityInput, modeCountOutput, ref modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateFacialSimulationModesBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] Span<uint> modeCountOutput, [Count(Parameter = "modeCapacityInput")] FacialSimulationModeBD* modes)
        {
            // SpanOverloader
            return thisApi.EnumerateFacialSimulationModesBD(session, modeCapacityInput, ref modeCountOutput.GetPinnableReference(), modes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result EnumerateFacialSimulationModesBD(this BDFacialSimulation thisApi, [Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] Span<uint> modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<FacialSimulationModeBD> modes)
        {
            // SpanOverloader
            return thisApi.EnumerateFacialSimulationModesBD(session, modeCapacityInput, ref modeCountOutput.GetPinnableReference(), ref modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialSimulationDataBD(this BDFacialSimulation thisApi, [Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialSimulationDataGetInfoBD* info, [Count(Count = 0)] Span<FacialSimulationDataBD> facialData)
        {
            // SpanOverloader
            return thisApi.GetFacialSimulationDataBD(tracker, info, ref facialData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialSimulationDataBD(this BDFacialSimulation thisApi, [Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialSimulationDataGetInfoBD> info, [Count(Count = 0)] FacialSimulationDataBD* facialData)
        {
            // SpanOverloader
            return thisApi.GetFacialSimulationDataBD(tracker, in info.GetPinnableReference(), facialData);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialSimulationDataBD(this BDFacialSimulation thisApi, [Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialSimulationDataGetInfoBD> info, [Count(Count = 0)] Span<FacialSimulationDataBD> facialData)
        {
            // SpanOverloader
            return thisApi.GetFacialSimulationDataBD(tracker, in info.GetPinnableReference(), ref facialData.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialSimulationModeBD(this BDFacialSimulation thisApi, [Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0)] Span<FacialSimulationModeBD> mode)
        {
            // SpanOverloader
            return thisApi.GetFacialSimulationModeBD(tracker, ref mode.GetPinnableReference());
        }

    }
}

