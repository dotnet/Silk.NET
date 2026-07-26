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
    [NativeName("Name", "XrSpatialEntityComponentDataSemanticBD")]
    public unsafe partial struct SpatialEntityComponentDataSemanticBD
    {
        public SpatialEntityComponentDataSemanticBD
        (
            StructureType? type = StructureType.TypeSpatialEntityComponentDataSemanticBD,
            void* next = null,
            uint? labelCapacityInput = null,
            uint? labelCountOutput = null,
            SemanticLabelBD* labels = null
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

            if (labelCapacityInput is not null)
            {
                LabelCapacityInput = labelCapacityInput.Value;
            }

            if (labelCountOutput is not null)
            {
                LabelCountOutput = labelCountOutput.Value;
            }

            if (labels is not null)
            {
                Labels = labels;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "labelCapacityInput")]
        public uint LabelCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "labelCountOutput")]
        public uint LabelCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrSemanticLabelBD*")]
        [NativeName("Type.Name", "XrSemanticLabelBD")]
        [NativeName("Name", "labels")]
        public SemanticLabelBD* Labels;
    }
}
