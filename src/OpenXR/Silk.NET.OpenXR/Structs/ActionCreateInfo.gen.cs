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
    public unsafe struct ActionCreateInfo
    {
        public ActionCreateInfo
        (
            StructureType type = StructureType.TypeActionCreateInfo,
            void* next = default,
            ActionType actionType = default,
            uint countSubactionPaths = default,
            ulong* subactionPaths = default
        )
        {
           Type = type;
           Next = next;
           ActionType = actionType;
           CountSubactionPaths = countSubactionPaths;
           SubactionPaths = subactionPaths;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
        /// <summary></summary>
       public fixed byte ActionName[64];
/// <summary></summary>
        public ActionType ActionType;
/// <summary></summary>
        public uint CountSubactionPaths;
/// <summary></summary>
        public ulong* SubactionPaths;
        /// <summary></summary>
       public fixed byte LocalizedActionName[128];
    }
}
