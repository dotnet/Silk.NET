// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Intrinsics
{
    [Flags]
    public enum WorkUnitFlags : uint
    {
        None = 0,
        Vector64 = 1 << 1,
        Vector128 = 1 << 2,
        Vector256 = 1 << 3,
        RegisterAvx = 1 << 4,
        RegisterAvx2 = 1 << 5,
        RegisterAvxAll = RegisterAvx | RegisterAvx2,
        RegisterSse = 1 << 6,
        RegisterSseX64 = 1 << 7,
        RegisterSse2 = 1 << 8,
        RegisterSse2X64 = 1 << 9,
        RegisterSse3 = 1 << 10,
        RegisterSse41 = 1 << 11,
        RegisterSse41X64 = 1 << 12,
        RegisterSseAll = RegisterSse | RegisterSse2 | RegisterSse3 | RegisterSse41,
        RegisterSseAll64 = RegisterSseX64 | RegisterSse2X64 | RegisterSse41X64,
        RegisterSseAllAny = RegisterSseAll | RegisterSseAll64,
        RegisterSsse3 = 1 << 13,
        RegisterArm = 1 << 14,
        RegisterSoftware = 1 << 15,
        TypeFloat = 1 << 16,
        TypeDouble = 1 << 17,
        TypeInt = 1 << 18,
        TypeUInt = 1 << 19,
        TypeLong = 1 << 20,
        TypeULong = 1 << 21,
        TypeShortAsInt = 1 << 22,
        TypeUShortAsUInt = 1 << 23,
        TypeHalfAsFloat = 1 << 24,
    }
}
