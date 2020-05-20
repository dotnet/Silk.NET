// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.AMD
{
    public enum AMD
    {
        DeviceProfilingTimerOffsetAmd = 0x4036,
        DeviceTopologyAmd = 0x4037,
        DeviceBoardNameAmd = 0x4038,
        DeviceGlobalFreeMemoryAmd = 0x4039,
        DeviceSimdPerComputeUnitAmd = 0x4040,
        DeviceSimdWidthAmd = 0x4041,
        DeviceSimdInstructionWidthAmd = 0x4042,
        DeviceWavefrontWidthAmd = 0x4043,
        DeviceGlobalMemChannelsAmd = 0x4044,
        DeviceGlobalMemChannelBanksAmd = 0x4045,
        DeviceGlobalMemChannelBankWidthAmd = 0x4046,
        DeviceLocalMemSizePerComputeUnitAmd = 0x4047,
        DeviceLocalMemBanksAmd = 0x4048,
        DeviceThreadTraceSupportedAmd = 0x4049,
        DeviceGfxipMajorAmd = 0x404A,
        DeviceGfxipMinorAmd = 0x404B,
        DeviceAvailableAsyncQueuesAmd = 0x404C,
        DevicePreferredWorkGroupSizeAmd = 0x4030,
        DeviceMaxWorkGroupSizeAmd = 0x4031,
        DevicePreferredConstantBufferSizeAmd = 0x4033,
        DevicePcieIDAmd = 0x4034,
    }
}
