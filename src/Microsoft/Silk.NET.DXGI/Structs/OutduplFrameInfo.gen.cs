// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            long lastPresentTime = default,
            long lastMouseUpdateTime = default,
            uint accumulatedFrames = default,
            int rectsCoalesced = default,
            int protectedContentMaskedOut = default,
            OutduplPointerPosition pointerPosition = default,
            uint totalMetadataBufferSize = default,
            uint pointerShapeBufferSize = default
        )
        {
            LastPresentTime = lastPresentTime;
            LastMouseUpdateTime = lastMouseUpdateTime;
            AccumulatedFrames = accumulatedFrames;
            RectsCoalesced = rectsCoalesced;
            ProtectedContentMaskedOut = protectedContentMaskedOut;
            PointerPosition = pointerPosition;
            TotalMetadataBufferSize = totalMetadataBufferSize;
            PointerShapeBufferSize = pointerShapeBufferSize;
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
        public int RectsCoalesced;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ProtectedContentMaskedOut")]
        public int ProtectedContentMaskedOut;

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
