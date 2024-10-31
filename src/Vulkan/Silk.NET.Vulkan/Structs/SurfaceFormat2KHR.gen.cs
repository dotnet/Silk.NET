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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSurfaceFormat2KHR")]
    public unsafe partial struct SurfaceFormat2KHR : IChainStart
    {
        public SurfaceFormat2KHR
        (
            StructureType? sType = StructureType.SurfaceFormat2Khr,
            void* pNext = null,
            SurfaceFormatKHR? surfaceFormat = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (surfaceFormat is not null)
            {
                SurfaceFormat = surfaceFormat.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceFormatKHR")]
        [NativeName("Type.Name", "VkSurfaceFormatKHR")]
        [NativeName("Name", "surfaceFormat")]
        public SurfaceFormatKHR SurfaceFormat;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SurfaceFormat2Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref SurfaceFormat2KHR Chain(
            out SurfaceFormat2KHR capture)
        {
            capture = new SurfaceFormat2KHR(StructureType.SurfaceFormat2Khr);
            return ref capture;
        }
    }
}
