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
    [NativeName("Name", "XrBodyJointLocationsBD")]
    public unsafe partial struct BodyJointLocationsBD
    {
        public BodyJointLocationsBD
        (
            StructureType? type = StructureType.TypeBodyJointLocationsBD,
            void* next = null,
            uint? allJointPosesTracked = null,
            uint? jointLocationCount = null,
            BodyJointLocationBD* jointLocations = null
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

            if (allJointPosesTracked is not null)
            {
                AllJointPosesTracked = allJointPosesTracked.Value;
            }

            if (jointLocationCount is not null)
            {
                JointLocationCount = jointLocationCount.Value;
            }

            if (jointLocations is not null)
            {
                JointLocations = jointLocations;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "allJointPosesTracked")]
        public uint AllJointPosesTracked;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "jointLocationCount")]
        public uint JointLocationCount;
/// <summary></summary>
        [NativeName("Type", "XrBodyJointLocationBD*")]
        [NativeName("Type.Name", "XrBodyJointLocationBD")]
        [NativeName("Name", "jointLocations")]
        public BodyJointLocationBD* JointLocations;
    }
}
