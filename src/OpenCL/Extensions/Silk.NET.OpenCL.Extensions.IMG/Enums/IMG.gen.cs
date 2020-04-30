// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenCL.Extensions.IMG
{
    public enum IMG
    {
        MemUseUncachedCpuMemoryImg = 0x67108864,
        MemUseCachedCpuMemoryImg = unchecked((int)0x134217728),
        MemUseGrallocPtrImg = unchecked((int)0x268435456),
        CommandAcquireGrallocObjectsImg = 0x40D2,
        CommandReleaseGrallocObjectsImg = 0x40D3,
        GrallocResourceNotAcquiredImg = 0x40D4,
        NV21Img = 0x40D0,
        YV12Img = 0x40D1,
    }
}
