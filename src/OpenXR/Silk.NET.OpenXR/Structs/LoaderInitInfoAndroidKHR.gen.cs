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
    [NativeName("Name", "XrLoaderInitInfoAndroidKHR")]
    public unsafe partial struct LoaderInitInfoAndroidKHR
    {
        public LoaderInitInfoAndroidKHR
        (
            StructureType? type = StructureType.TypeLoaderInitInfoAndroidKhr,
            void* next = null,
            void* applicationVM = null,
            void* applicationContext = null
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

            if (applicationVM is not null)
            {
                ApplicationVM = applicationVM;
            }

            if (applicationContext is not null)
            {
                ApplicationContext = applicationContext;
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
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationVM")]
        public void* ApplicationVM;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "applicationContext")]
        public void* ApplicationContext;
    }
}
