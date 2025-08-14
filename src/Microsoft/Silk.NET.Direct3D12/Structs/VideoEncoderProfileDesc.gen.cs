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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_PROFILE_DESC")]
    public unsafe partial struct VideoEncoderProfileDesc
    {
        public VideoEncoderProfileDesc
        (
            uint? dataSize = null,
            VideoEncoderProfileDescUnion? anonymous = null,
            VideoEncoderProfileH264* pH264Profile = null,
            VideoEncoderProfileHevc* pHEVCProfile = null,
            VideoEncoderAV1Profile* pAV1Profile = null
        ) : this()
        {
            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pH264Profile is not null)
            {
                PH264Profile = pH264Profile;
            }

            if (pHEVCProfile is not null)
            {
                PHEVCProfile = pHEVCProfile;
            }

            if (pAV1Profile is not null)
            {
                PAV1Profile = pAV1Profile;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12video_L6974_C5")]
        [NativeName("Name", "anonymous1")]
        public VideoEncoderProfileDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderProfileH264* PH264Profile
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PH264Profile;
        }
#else
        public VideoEncoderProfileH264* PH264Profile
        {
            get => Anonymous.PH264Profile;
            set => Anonymous.PH264Profile = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderProfileHevc* PHEVCProfile
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PHEVCProfile;
        }
#else
        public VideoEncoderProfileHevc* PHEVCProfile
        {
            get => Anonymous.PHEVCProfile;
            set => Anonymous.PHEVCProfile = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref VideoEncoderAV1Profile* PAV1Profile
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].PAV1Profile;
        }
#else
        public VideoEncoderAV1Profile* PAV1Profile
        {
            get => Anonymous.PAV1Profile;
            set => Anonymous.PAV1Profile = value;
        }
#endif

    }
}
