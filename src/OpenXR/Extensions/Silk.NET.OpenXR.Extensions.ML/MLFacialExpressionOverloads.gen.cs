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
    public static class MLFacialExpressionOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialExpressionClientML(this MLFacialExpression thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionClientCreateInfoML* createInfo, [Count(Count = 0)] Span<FacialExpressionClientML> facialExpressionClient)
        {
            // SpanOverloader
            return thisApi.CreateFacialExpressionClientML(session, createInfo, ref facialExpressionClient.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialExpressionClientML(this MLFacialExpression thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialExpressionClientCreateInfoML> createInfo, [Count(Count = 0)] FacialExpressionClientML* facialExpressionClient)
        {
            // SpanOverloader
            return thisApi.CreateFacialExpressionClientML(session, in createInfo.GetPinnableReference(), facialExpressionClient);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result CreateFacialExpressionClientML(this MLFacialExpression thisApi, [Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialExpressionClientCreateInfoML> createInfo, [Count(Count = 0)] Span<FacialExpressionClientML> facialExpressionClient)
        {
            // SpanOverloader
            return thisApi.CreateFacialExpressionClientML(session, in createInfo.GetPinnableReference(), ref facialExpressionClient.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialExpressionBlendShapePropertiesML(this MLFacialExpression thisApi, [Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] FacialExpressionBlendShapeGetInfoML* blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] Span<FacialExpressionBlendShapePropertiesML> blendShapes)
        {
            // SpanOverloader
            return thisApi.GetFacialExpressionBlendShapePropertiesML(facialExpressionClient, blendShapeGetInfo, blendShapeCount, ref blendShapes.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialExpressionBlendShapePropertiesML(this MLFacialExpression thisApi, [Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialExpressionBlendShapeGetInfoML> blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] FacialExpressionBlendShapePropertiesML* blendShapes)
        {
            // SpanOverloader
            return thisApi.GetFacialExpressionBlendShapePropertiesML(facialExpressionClient, in blendShapeGetInfo.GetPinnableReference(), blendShapeCount, blendShapes);
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetFacialExpressionBlendShapePropertiesML(this MLFacialExpression thisApi, [Count(Count = 0)] FacialExpressionClientML facialExpressionClient, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<FacialExpressionBlendShapeGetInfoML> blendShapeGetInfo, [Count(Count = 0)] uint blendShapeCount, [Count(Parameter = "blendShapeCount")] Span<FacialExpressionBlendShapePropertiesML> blendShapes)
        {
            // SpanOverloader
            return thisApi.GetFacialExpressionBlendShapePropertiesML(facialExpressionClient, in blendShapeGetInfo.GetPinnableReference(), blendShapeCount, ref blendShapes.GetPinnableReference());
        }

    }
}

