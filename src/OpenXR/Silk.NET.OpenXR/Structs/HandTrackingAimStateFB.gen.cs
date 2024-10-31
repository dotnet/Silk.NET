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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandTrackingAimStateFB")]
    public unsafe partial struct HandTrackingAimStateFB
    {
        public HandTrackingAimStateFB
        (
            StructureType? type = StructureType.TypeHandTrackingAimStateFB,
            void* next = null,
            HandTrackingAimFlagsFB? status = null,
            Posef? aimPose = null,
            float? pinchStrengthIndex = null,
            float? pinchStrengthMiddle = null,
            float? pinchStrengthRing = null,
            float? pinchStrengthLittle = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (status is not null)
            {
                Status = status.Value;
            }

            if (aimPose is not null)
            {
                AimPose = aimPose.Value;
            }

            if (pinchStrengthIndex is not null)
            {
                PinchStrengthIndex = pinchStrengthIndex.Value;
            }

            if (pinchStrengthMiddle is not null)
            {
                PinchStrengthMiddle = pinchStrengthMiddle.Value;
            }

            if (pinchStrengthRing is not null)
            {
                PinchStrengthRing = pinchStrengthRing.Value;
            }

            if (pinchStrengthLittle is not null)
            {
                PinchStrengthLittle = pinchStrengthLittle.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrHandTrackingAimFlagsFB")]
        [NativeName("Type.Name", "XrHandTrackingAimFlagsFB")]
        [NativeName("Name", "status")]
        public HandTrackingAimFlagsFB Status;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "aimPose")]
        public Posef AimPose;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pinchStrengthIndex")]
        public float PinchStrengthIndex;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pinchStrengthMiddle")]
        public float PinchStrengthMiddle;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pinchStrengthRing")]
        public float PinchStrengthRing;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pinchStrengthLittle")]
        public float PinchStrengthLittle;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
