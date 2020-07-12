// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct EventDataReferenceSpaceChangePending
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Session Session;
/// <summary></summary>
        public ReferenceSpaceType ReferenceSpaceType;
/// <summary></summary>
        public long ChangeTime;
/// <summary></summary>
        public uint PoseValid;
/// <summary></summary>
        public Posef PoseInPreviousSpace;
    }
}
