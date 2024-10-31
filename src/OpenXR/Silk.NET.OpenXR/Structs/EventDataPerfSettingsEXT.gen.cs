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
    [NativeName("Name", "XrEventDataPerfSettingsEXT")]
    public unsafe partial struct EventDataPerfSettingsEXT
    {
        public EventDataPerfSettingsEXT
        (
            StructureType? type = StructureType.TypeEventDataPerfSettingsExt,
            void* next = null,
            PerfSettingsDomainEXT? domain = null,
            PerfSettingsSubDomainEXT? subDomain = null,
            PerfSettingsNotificationLevelEXT? fromLevel = null,
            PerfSettingsNotificationLevelEXT? toLevel = null
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

            if (domain is not null)
            {
                Domain = domain.Value;
            }

            if (subDomain is not null)
            {
                SubDomain = subDomain.Value;
            }

            if (fromLevel is not null)
            {
                FromLevel = fromLevel.Value;
            }

            if (toLevel is not null)
            {
                ToLevel = toLevel.Value;
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
