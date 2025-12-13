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
    [Extension("XR_ML_facial_expression")]
    public unsafe partial class MLFacialExpression : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_ML_facial_expression";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialExpressionClientML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialExpressionClientML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionClientCreateInfoML* createInfo, [Count(Count = 0)] FacialExpressionClientML* facialExpressionClient);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialExpressionClientML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialExpressionClientML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionClientCreateInfoML* createInfo, [Count(Count = 0)] ref FacialExpressionClientML facialExpressionClient);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialExpressionClientML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateFacialExpressionClientML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialExpressionClientCreateInfoML createInfo, [Count(Count = 0)] FacialExpressionClientML* facialExpressionClient);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateFacialExpressionClientML", Convention = CallingConvention.Winapi)]
        public partial Result CreateFacialExpressionClientML([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialExpressionClientCreateInfoML createInfo, [Count(Count = 0)] ref FacialExpressionClientML facialExpressionClient);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyFacialExpressionClientML", Convention = CallingConvention.Winapi)]
        public partial Result DestroyFacialExpressionClientML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionBlendShapePropertiesML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] FacialExpressionBlendShapePropertiesML* blendShapes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionBlendShapePropertiesML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] ref FacialExpressionBlendShapePropertiesML blendShapes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionBlendShapePropertiesML", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialExpressionBlendShapeGetInfoML blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] FacialExpressionBlendShapePropertiesML* blendShapes);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetFacialExpressionBlendShapePropertiesML", Convention = CallingConvention.Winapi)]
        public partial Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialExpressionBlendShapeGetInfoML blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] ref FacialExpressionBlendShapePropertiesML blendShapes);

        /// <summary>To be documented.</summary>
        public unsafe Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, [Count(Parameter = "blendShapeCount")] Span<FacialExpressionBlendShapePropertiesML> blendShapes)
        {
            // ImplicitCountSpanOverloader
            return GetFacialExpressionBlendShapePropertiesML(facialExpressionClient, blendShapeGetInfo, (uint) blendShapes.Length, ref blendShapes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetFacialExpressionBlendShapePropertiesML([Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly FacialExpressionBlendShapeGetInfoML blendShapeGetInfo, [Count(Parameter = "blendShapeCount")] Span<FacialExpressionBlendShapePropertiesML> blendShapes)
        {
            // ImplicitCountSpanOverloader
            return GetFacialExpressionBlendShapePropertiesML(facialExpressionClient, in blendShapeGetInfo, (uint) blendShapes.Length, ref blendShapes.GetPinnableReference());
        }

        public MLFacialExpression(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

