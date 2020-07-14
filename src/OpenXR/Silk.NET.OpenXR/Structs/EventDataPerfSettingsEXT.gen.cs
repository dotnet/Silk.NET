// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrEventDataPerfSettingsEXT")]
    public unsafe partial struct EventDataPerfSettingsEXT
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
        [NativeName("Type", "XrPerfSettingsDomainEXT")]
        [NativeName("Type.Name", "XrPerfSettingsDomainEXT")]
        [NativeName("Name", "domain")]
        public PerfSettingsDomainEXT Domain;
/// <summary></summary>
        [NativeName("Type", "XrPerfSettingsSubDomainEXT")]
        [NativeName("Type.Name", "XrPerfSettingsSubDomainEXT")]
        [NativeName("Name", "subDomain")]
        public PerfSettingsSubDomainEXT SubDomain;
/// <summary></summary>
        [NativeName("Type", "XrPerfSettingsNotificationLevelEXT")]
        [NativeName("Type.Name", "XrPerfSettingsNotificationLevelEXT")]
        [NativeName("Name", "fromLevel")]
        public PerfSettingsNotificationLevelEXT FromLevel;
/// <summary></summary>
        [NativeName("Type", "XrPerfSettingsNotificationLevelEXT")]
        [NativeName("Type.Name", "XrPerfSettingsNotificationLevelEXT")]
        [NativeName("Name", "toLevel")]
        public PerfSettingsNotificationLevelEXT ToLevel;
    }
}
