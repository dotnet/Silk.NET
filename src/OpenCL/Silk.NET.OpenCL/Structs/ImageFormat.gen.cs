// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL
{
    public unsafe struct ImageFormat
    {
        public ImageFormat
        (
            uint imageChannelOrder = default,
            uint imageChannelDataType = default
        )
        {
           ImageChannelOrder = imageChannelOrder;
           ImageChannelDataType = imageChannelDataType;
        }

/// <summary></summary>
        public uint ImageChannelOrder;
/// <summary></summary>
        public uint ImageChannelDataType;
    }
}
