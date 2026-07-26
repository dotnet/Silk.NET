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

namespace Silk.NET.OpenXR.Extensions.BD
{
    [Extension("XR_BD_facial_simulation")]
    public unsafe partial class BDFacialSimulation : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_BD_facial_simulation";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoBD* createInfo, [Count(Count = 0)] FaceTrackerBD* tracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FaceTrackerCreateInfoBD* createInfo, [Count(Count = 0)] ref FaceTrackerBD tracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFaceTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceTrackerCreateInfoBD createInfo, [Count(Count = 0)] FaceTrackerBD* tracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFaceTrackerBD", Convention = CallingConvention.Winapi)]
        public partial Result CreateFaceTrackerBD([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FaceTrackerCreateInfoBD createInfo, [Count(Count = 0)] ref FaceTrackerBD tracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFaceTrackerBD", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFaceTrackerBD([Count(Count = 0)] FaceTrackerBD tracker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateFacialSimulationModesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] FacialSimulationModeBD* modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateFacialSimulationModesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] ref FacialSimulationModeBD modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateFacialSimulationModesBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] FacialSimulationModeBD* modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrEnumerateFacialSimulationModesBD", Convention = CallingConvention.Winapi)]
        public partial Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] uint modeCapacityInput, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] ref FacialSimulationModeBD modes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialSimulationDataBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialSimulationDataGetInfoBD* info, [Count(Count = 0)] FacialSimulationDataBD* facialData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialSimulationDataBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialSimulationDataGetInfoBD* info, [Count(Count = 0)] ref FacialSimulationDataBD facialData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationDataBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialSimulationDataBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialSimulationDataGetInfoBD info, [Count(Count = 0)] FacialSimulationDataBD* facialData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationDataBD", Convention = CallingConvention.Winapi)]
        public partial Result GetFacialSimulationDataBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialSimulationDataGetInfoBD info, [Count(Count = 0)] ref FacialSimulationDataBD facialData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationModeBD", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialSimulationModeBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0)] FacialSimulationModeBD* mode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialSimulationModeBD", Convention = CallingConvention.Winapi)]
        public partial Result GetFacialSimulationModeBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0)] ref FacialSimulationModeBD mode);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetFacialSimulationModeBD", Convention = CallingConvention.Winapi)]
        public partial Result SetFacialSimulationModeBD([Count(Count = 0)] FaceTrackerBD tracker, [Count(Count = 0)] FacialSimulationModeBD mode);

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] uint* modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<FacialSimulationModeBD> modes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateFacialSimulationModesBD(session, (uint) modes.Length, modeCountOutput, ref modes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result EnumerateFacialSimulationModesBD([Count(Count = 0)] Session session, [Count(Count = 0)] ref uint modeCountOutput, [Count(Parameter = "modeCapacityInput")] Span<FacialSimulationModeBD> modes)
        {
            // ImplicitCountSpanOverloader
            return EnumerateFacialSimulationModesBD(session, (uint) modes.Length, ref modeCountOutput, ref modes.GetPinnableReference());
        }

        public BDFacialSimulation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

