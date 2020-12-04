// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    public struct SecurityAttributes
    {
        public long NLength;
        public unsafe void* LpSecurityDescriptor;
        public byte BInheritHandle;
    }
}
