// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Intrinsics
{
    [Flags]
    public enum WorkUnitFlags
    {
        None = 0,
        Vector64 = 1 << 1,
        Vector128 = 1 << 2,
        Vector256 = 1 << 3,
        RegisterAvx = 1 << 4, 
        RegisterAvx2 = 1 << 5, 
        RegisterSse41 = 1 << 6, 
        RegisterArm = 1 << 7,
        RegisterSoftware = 1 << 8,
        TypeFloat = 1 << 9,
        TypeDouble = 1 << 10,
    }
}
