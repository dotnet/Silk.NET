// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum ErrorCode
    {
        NoError = 0x0,
        InvalidEnum = 0x500,
        InvalidValue = 0x501,
        InvalidOperation = 0x502,
        StackOverflow = 0x503,
        StackUnderflow = 0x504,
        OutOfMemory = 0x505,
        InvalidFramebufferOperation = 0x506,
        InvalidFramebufferOperationExt = 0x506,
        InvalidFramebufferOperationOes = 0x506,
        TableTooLargeExt = 0x8031,
        TableTooLarge = 0x8031,
        TextureTooLargeExt = 0x8065,
    }
}
