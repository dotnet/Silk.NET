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

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_device_integer_dot_product_acceleration_properties_khr")]
    public unsafe partial struct DeviceIntegerDotProductAccelerationPropertiesKhr
    {
        public DeviceIntegerDotProductAccelerationPropertiesKhr
        (
            bool? signedAccelerated = null,
            bool? unsignedAccelerated = null,
            bool? mixedSignednessAccelerated = null,
            bool? accumulatingSaturatingSignedAccelerated = null,
            bool? accumulatingSaturatingUnsignedAccelerated = null,
            bool? accumulatingSaturatingMixedSignednessAccelerated = null
        ) : this()
        {
            if (signedAccelerated is not null)
            {
                SignedAccelerated = signedAccelerated.Value;
            }

            if (unsignedAccelerated is not null)
            {
                UnsignedAccelerated = unsignedAccelerated.Value;
            }

            if (mixedSignednessAccelerated is not null)
            {
                MixedSignednessAccelerated = mixedSignednessAccelerated.Value;
            }

            if (accumulatingSaturatingSignedAccelerated is not null)
            {
                AccumulatingSaturatingSignedAccelerated = accumulatingSaturatingSignedAccelerated.Value;
            }

            if (accumulatingSaturatingUnsignedAccelerated is not null)
            {
                AccumulatingSaturatingUnsignedAccelerated = accumulatingSaturatingUnsignedAccelerated.Value;
            }

            if (accumulatingSaturatingMixedSignednessAccelerated is not null)
            {
                AccumulatingSaturatingMixedSignednessAccelerated = accumulatingSaturatingMixedSignednessAccelerated.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "signed_accelerated")]
        public bool SignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "unsigned_accelerated")]
        public bool UnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "mixed_signedness_accelerated")]
        public bool MixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "accumulating_saturating_signed_accelerated")]
        public bool AccumulatingSaturatingSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "accumulating_saturating_unsigned_accelerated")]
        public bool AccumulatingSaturatingUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "cl_bool")]
        [NativeName("Type.Name", "cl_bool")]
        [NativeName("Name", "accumulating_saturating_mixed_signedness_accelerated")]
        public bool AccumulatingSaturatingMixedSignednessAccelerated;
    }
}
