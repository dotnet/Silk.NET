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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTDUPL_FRAME_INFO")]
    public unsafe partial struct OutduplFrameInfo
    {
        public OutduplFrameInfo
        (
            long? lastPresentTime = null,
            long? lastMouseUpdateTime = null,
            uint? accumulatedFrames = null,
            Silk.NET.Core.Bool32? rectsCoalesced = null,
            Silk.NET.Core.Bool32? protectedContentMaskedOut = null,
            OutduplPointerPosition? pointerPosition = null,
            uint? totalMetadataBufferSize = null,
            uint? pointerShapeBufferSize = null
        ) : this()
        {
            if (lastPresentTime is not null)
            {
                LastPresentTime = lastPresentTime.Value;
            }

            if (lastMouseUpdateTime is not null)
            {
                LastMouseUpdateTime = lastMouseUpdateTime.Value;
            }

            if (accumulatedFrames is not null)
            {
                AccumulatedFrames = accumulatedFrames.Value;
            }

            if (rectsCoalesced is not null)
            {
                RectsCoalesced = rectsCoalesced.Value;
            }

            if (protectedContentMaskedOut is not null)
            {
                ProtectedContentMaskedOut = protectedContentMaskedOut.Value;
            }

            if (pointerPosition is not null)
            {
                PointerPosition = pointerPosition.Value;
            }

            if (totalMetadataBufferSize is not null)
            {
                TotalMetadataBufferSize = totalMetadataBufferSize.Value;
            }

            if (pointerShapeBufferSize is not null)
            {
                PointerShapeBufferSize = pointerShapeBufferSize.Value;
            }
        }


        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "LastPresentTime")]
        public long LastPresentTime;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "LastMouseUpdateTime")]
        public long LastMouseUpdateTime;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "AccumulatedFrames")]
        public uint AccumulatedFrames;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "RectsCoalesced")]
        public Silk.NET.Core.Bool32 RectsCoalesced;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ProtectedContentMaskedOut")]
        public Silk.NET.Core.Bool32 ProtectedContentMaskedOut;

        [NativeName("Type", "DXGI_OUTDUPL_POINTER_POSITION")]
        [NativeName("Type.Name", "DXGI_OUTDUPL_POINTER_POSITION")]
        [NativeName("Name", "PointerPosition")]
        public OutduplPointerPosition PointerPosition;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "TotalMetadataBufferSize")]
        public uint TotalMetadataBufferSize;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PointerShapeBufferSize")]
        public uint PointerShapeBufferSize;
    }
}
