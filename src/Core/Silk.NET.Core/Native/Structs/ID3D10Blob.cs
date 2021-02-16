// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Text;

namespace Silk.NET.Core.Native
{
    public partial struct ID3D10Blob
    {
        public unsafe ReadOnlySpan<byte> Buffer => new ReadOnlySpan<byte>(GetBufferPointer(), (int) GetBufferSize());
        private unsafe string AsString => Encoding.UTF8.GetString((byte*) GetBufferPointer(), (int) GetBufferSize());
    }
}
