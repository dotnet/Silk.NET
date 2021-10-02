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
    [NativeName("Name", "XrActionCreateInfo")]
    public unsafe partial struct ActionCreateInfo
    {
        public ActionCreateInfo
        (
            StructureType? type = StructureType.TypeActionCreateInfo,
            void* next = null,
            ActionType? actionType = null,
            uint? countSubactionPaths = null,
            ulong* subactionPaths = null
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

            if (actionType is not null)
            {
                ActionType = actionType.Value;
            }

            if (countSubactionPaths is not null)
            {
                CountSubactionPaths = countSubactionPaths.Value;
            }

            if (subactionPaths is not null)
            {
                SubactionPaths = subactionPaths;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "actionName")]
        public fixed byte ActionName[64];
/// <summary></summary>
        [NativeName("Type", "XrActionType")]
        [NativeName("Type.Name", "XrActionType")]
        [NativeName("Name", "actionType")]
        public ActionType ActionType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "countSubactionPaths")]
        public uint CountSubactionPaths;
/// <summary></summary>
        [NativeName("Type", "XrPath*")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "subactionPaths")]
        public ulong* SubactionPaths;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "localizedActionName")]
        public fixed byte LocalizedActionName[128];
    }
}
