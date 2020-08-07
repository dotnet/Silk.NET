// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public enum DriverIdKHR
    {
        DriverIDAmdProprietary = 1,
        DriverIDAmdOpenSource = 2,
        DriverIDMesaRadv = 3,
        DriverIDNvidiaProprietary = 4,
        DriverIDIntelProprietaryWindows = 5,
        DriverIDIntelOpenSourceMesa = 6,
        DriverIDImaginationProprietary = 7,
        DriverIDQualcommProprietary = 8,
        DriverIDArmProprietary = 9,
        DriverIDGoogleSwiftshader = 10,
        DriverIDGgpProprietary = 11,
        DriverIDBroadcomProprietary = 12,
        DriverIDMesaLlvmpipe = 13,
        DriverIDMoltenvk = 14,
    }
}
