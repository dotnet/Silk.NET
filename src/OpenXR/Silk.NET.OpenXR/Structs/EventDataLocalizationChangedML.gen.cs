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
    [NativeName("Name", "XrEventDataLocalizationChangedML")]
    public unsafe partial struct EventDataLocalizationChangedML
    {
        public EventDataLocalizationChangedML
        (
            StructureType? type = StructureType.TypeEventDataLocalizationChangedML,
            void* next = null,
            Session? session = null,
            LocalizationMapStateML? state = null,
            LocalizationMapML? map = null,
            LocalizationMapConfidenceML? confidence = null,
            LocalizationMapErrorFlagsML? errorFlags = null
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

            if (session is not null)
            {
                Session = session.Value;
            }

            if (state is not null)
            {
                State = state.Value;
            }

            if (map is not null)
            {
                Map = map.Value;
            }

            if (confidence is not null)
            {
                Confidence = confidence.Value;
            }

            if (errorFlags is not null)
            {
                ErrorFlags = errorFlags.Value;
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
        [NativeName("Type", "XrSession")]
        [NativeName("Type.Name", "XrSession")]
        [NativeName("Name", "session")]
        public Session Session;
/// <summary></summary>
        [NativeName("Type", "XrLocalizationMapStateML")]
        [NativeName("Type.Name", "XrLocalizationMapStateML")]
        [NativeName("Name", "state")]
        public LocalizationMapStateML State;
/// <summary></summary>
        [NativeName("Type", "XrLocalizationMapML")]
        [NativeName("Type.Name", "XrLocalizationMapML")]
        [NativeName("Name", "map")]
        public LocalizationMapML Map;
/// <summary></summary>
        [NativeName("Type", "XrLocalizationMapConfidenceML")]
        [NativeName("Type.Name", "XrLocalizationMapConfidenceML")]
        [NativeName("Name", "confidence")]
        public LocalizationMapConfidenceML Confidence;
/// <summary></summary>
        [NativeName("Type", "XrLocalizationMapErrorFlagsML")]
        [NativeName("Type.Name", "XrLocalizationMapErrorFlagsML")]
        [NativeName("Name", "errorFlags")]
        public LocalizationMapErrorFlagsML ErrorFlags;
    }
}
