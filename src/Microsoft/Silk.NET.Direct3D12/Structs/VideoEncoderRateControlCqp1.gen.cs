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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RATE_CONTROL_CQP1")]
    public unsafe partial struct VideoEncoderRateControlCqp1
    {
        public VideoEncoderRateControlCqp1
        (
            uint? constantQPFullIntracodedFrame = null,
            uint? constantQPInterPredictedFramePrevRefOnly = null,
            uint? constantQPInterPredictedFrameBiDirectionalRef = null,
            uint? qualityVsSpeed = null
        ) : this()
        {
            if (constantQPFullIntracodedFrame is not null)
            {
                ConstantQPFullIntracodedFrame = constantQPFullIntracodedFrame.Value;
            }

            if (constantQPInterPredictedFramePrevRefOnly is not null)
            {
                ConstantQPInterPredictedFramePrevRefOnly = constantQPInterPredictedFramePrevRefOnly.Value;
            }

            if (constantQPInterPredictedFrameBiDirectionalRef is not null)
            {
                ConstantQPInterPredictedFrameBiDirectionalRef = constantQPInterPredictedFrameBiDirectionalRef.Value;
            }

            if (qualityVsSpeed is not null)
            {
                QualityVsSpeed = qualityVsSpeed.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantQP_FullIntracodedFrame")]
        public uint ConstantQPFullIntracodedFrame;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantQP_InterPredictedFrame_PrevRefOnly")]
        public uint ConstantQPInterPredictedFramePrevRefOnly;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ConstantQP_InterPredictedFrame_BiDirectionalRef")]
        public uint ConstantQPInterPredictedFrameBiDirectionalRef;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "QualityVsSpeed")]
        public uint QualityVsSpeed;
    }
}
