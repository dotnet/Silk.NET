// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenCL.Extensions.QCOM
{
    public enum QCOM
    {
        MemAndroidNativeBufferHostPtrQCom = 0x40C6,
        MemExtHostPtrQCom = unchecked((int)0x536870912),
        DeviceExtMemPaddingInBytesQCom = 0x40A0,
        DevicePageSizeQCom = 0x40A1,
        ImageRowAlignmentQCom = 0x40A2,
        ImageSliceAlignmentQCom = 0x40A3,
        MemHostUncachedQCom = 0x40A4,
        MemHostWritebackQCom = 0x40A5,
        MemHostWritethroughQCom = 0x40A6,
        MemHostWriteCombiningQCom = 0x40A7,
        MemHostIocoherentQCom = 0x40A9,
        MemIonHostPtrQCom = 0x40A8,
    }
}
