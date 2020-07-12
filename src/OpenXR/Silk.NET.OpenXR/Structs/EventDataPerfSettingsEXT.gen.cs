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
    public unsafe struct EventDataPerfSettingsEXT
    {
        public EventDataPerfSettingsEXT
        (
            StructureType type = StructureType.TypeEventDataPerfSettingsExt,
            void* next = default,
            PerfSettingsDomainEXT domain = default,
            PerfSettingsSubDomainEXT subDomain = default,
            PerfSettingsNotificationLevelEXT fromLevel = default,
            PerfSettingsNotificationLevelEXT toLevel = default
        )
        {
           Type = type;
           Next = next;
           Domain = domain;
           SubDomain = subDomain;
           FromLevel = fromLevel;
           ToLevel = toLevel;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public PerfSettingsDomainEXT Domain;
/// <summary></summary>
        public PerfSettingsSubDomainEXT SubDomain;
/// <summary></summary>
        public PerfSettingsNotificationLevelEXT FromLevel;
/// <summary></summary>
        public PerfSettingsNotificationLevelEXT ToLevel;
    }
}
