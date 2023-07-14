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

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_combined_image_sampler")]
    public unsafe partial struct CombinedImageSampler
    {
        public CombinedImageSampler
        (
            uint? combinedId = null,
            uint? imageId = null,
            uint? samplerId = null
        ) : this()
        {
            if (combinedId is not null)
            {
                CombinedId = combinedId.Value;
            }

            if (imageId is not null)
            {
                ImageId = imageId.Value;
            }

            if (samplerId is not null)
            {
                SamplerId = samplerId.Value;
            }
        }


        [NativeName("Type", "spvc_variable_id")]
        [NativeName("Type.Name", "spvc_variable_id")]
        [NativeName("Name", "combined_id")]
        public uint CombinedId;

        [NativeName("Type", "spvc_variable_id")]
        [NativeName("Type.Name", "spvc_variable_id")]
        [NativeName("Name", "image_id")]
        public uint ImageId;

        [NativeName("Type", "spvc_variable_id")]
        [NativeName("Type.Name", "spvc_variable_id")]
        [NativeName("Name", "sampler_id")]
        public uint SamplerId;
    }
}
