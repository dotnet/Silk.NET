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
    [NativeName("Name", "XrViveTrackerPathsHTCX")]
    public unsafe partial struct ViveTrackerPathsHTCX
    {
        public ViveTrackerPathsHTCX
        (
            StructureType? type = StructureType.TypeViveTrackerPathsHtcx,
            void* next = null,
            ulong? persistentPath = null,
            ulong? rolePath = null
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

            if (persistentPath is not null)
            {
                PersistentPath = persistentPath.Value;
            }

            if (rolePath is not null)
            {
                RolePath = rolePath.Value;
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
        [NativeName("Name", "persistentPath")]
        public ulong PersistentPath;
/// <summary></summary>
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "rolePath")]
        public ulong RolePath;
    }
}
