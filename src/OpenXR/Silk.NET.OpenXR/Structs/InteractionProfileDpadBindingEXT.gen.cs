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
    [NativeName("Name", "XrInteractionProfileDpadBindingEXT")]
    public unsafe partial struct InteractionProfileDpadBindingEXT
    {
        public InteractionProfileDpadBindingEXT
        (
            StructureType? type = StructureType.TypeInteractionProfileDpadBindingExt,
            void* next = null,
            ulong? binding = null,
            ActionSet? actionSet = null,
            float? forceThreshold = null,
            float? forceThresholdReleased = null,
            float? centerRegion = null,
            float? wedgeAngle = null,
            uint? isSticky = null,
            HapticBaseHeader* onHaptic = null,
            HapticBaseHeader* offHaptic = null
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

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (actionSet is not null)
            {
                ActionSet = actionSet.Value;
            }

            if (forceThreshold is not null)
            {
                ForceThreshold = forceThreshold.Value;
            }

            if (forceThresholdReleased is not null)
            {
                ForceThresholdReleased = forceThresholdReleased.Value;
            }

            if (centerRegion is not null)
            {
                CenterRegion = centerRegion.Value;
            }

            if (wedgeAngle is not null)
            {
                WedgeAngle = wedgeAngle.Value;
            }

            if (isSticky is not null)
            {
                IsSticky = isSticky.Value;
            }

            if (onHaptic is not null)
            {
                OnHaptic = onHaptic;
            }

            if (offHaptic is not null)
            {
                OffHaptic = offHaptic;
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
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "binding")]
        public ulong Binding;
/// <summary></summary>
        [NativeName("Type", "XrActionSet")]
        [NativeName("Type.Name", "XrActionSet")]
        [NativeName("Name", "actionSet")]
        public ActionSet ActionSet;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "forceThreshold")]
        public float ForceThreshold;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "forceThresholdReleased")]
        public float ForceThresholdReleased;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "centerRegion")]
        public float CenterRegion;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "wedgeAngle")]
        public float WedgeAngle;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isSticky")]
        public uint IsSticky;
/// <summary></summary>
        [NativeName("Type", "XrHapticBaseHeader*")]
        [NativeName("Type.Name", "XrHapticBaseHeader")]
        [NativeName("Name", "onHaptic")]
        public HapticBaseHeader* OnHaptic;
/// <summary></summary>
        [NativeName("Type", "XrHapticBaseHeader*")]
        [NativeName("Type.Name", "XrHapticBaseHeader")]
        [NativeName("Name", "offHaptic")]
        public HapticBaseHeader* OffHaptic;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
