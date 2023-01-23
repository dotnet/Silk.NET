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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_ENCODER_ENCODEFRAME_INPUT_ARGUMENTS")]
    public unsafe partial struct VideoEncoderEncodeframeInputArguments
    {
        public VideoEncoderEncodeframeInputArguments
        (
            VideoEncoderSequenceControlDesc? sequenceControlDesc = null,
            VideoEncoderPictureControlDesc? pictureControlDesc = null,
            ID3D12Resource* pInputFrame = null,
            uint? inputFrameSubresource = null,
            uint? currentFrameBitstreamMetadataSize = null
        ) : this()
        {
            if (sequenceControlDesc is not null)
            {
                SequenceControlDesc = sequenceControlDesc.Value;
            }

            if (pictureControlDesc is not null)
            {
                PictureControlDesc = pictureControlDesc.Value;
            }

            if (pInputFrame is not null)
            {
                PInputFrame = pInputFrame;
            }

            if (inputFrameSubresource is not null)
            {
                InputFrameSubresource = inputFrameSubresource.Value;
            }

            if (currentFrameBitstreamMetadataSize is not null)
            {
                CurrentFrameBitstreamMetadataSize = currentFrameBitstreamMetadataSize.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_DESC")]
        [NativeName("Name", "SequenceControlDesc")]
        public VideoEncoderSequenceControlDesc SequenceControlDesc;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_PICTURE_CONTROL_DESC")]
        [NativeName("Name", "PictureControlDesc")]
        public VideoEncoderPictureControlDesc PictureControlDesc;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pInputFrame")]
        public ID3D12Resource* PInputFrame;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "InputFrameSubresource")]
        public uint InputFrameSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CurrentFrameBitstreamMetadataSize")]
        public uint CurrentFrameBitstreamMetadataSize;
    }
}
