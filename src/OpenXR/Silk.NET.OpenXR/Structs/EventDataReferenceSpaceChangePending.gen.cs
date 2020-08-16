// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEventDataReferenceSpaceChangePending")]
    public unsafe partial struct EventDataReferenceSpaceChangePending
    {
        public EventDataReferenceSpaceChangePending
        (
            StructureType type = StructureType.TypeEventDataReferenceSpaceChangePending,
            void* next = default,
            Session session = default,
            ReferenceSpaceType referenceSpaceType = default,
            long changeTime = default,
            uint poseValid = default,
            Posef poseInPreviousSpace = default
        )
        {
            Type = type;
            Next = next;
            Session = session;
            ReferenceSpaceType = referenceSpaceType;
            ChangeTime = changeTime;
            PoseValid = poseValid;
            PoseInPreviousSpace = poseInPreviousSpace;
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
        [NativeName("Type", "XrSession")]
        [NativeName("Type.Name", "XrSession")]
        [NativeName("Name", "session")]
        public Session Session;
/// <summary></summary>
        [NativeName("Type", "XrReferenceSpaceType")]
        [NativeName("Type.Name", "XrReferenceSpaceType")]
        [NativeName("Name", "referenceSpaceType")]
        public ReferenceSpaceType ReferenceSpaceType;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "changeTime")]
        public long ChangeTime;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "poseValid")]
        public uint PoseValid;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "poseInPreviousSpace")]
        public Posef PoseInPreviousSpace;
    }
}
