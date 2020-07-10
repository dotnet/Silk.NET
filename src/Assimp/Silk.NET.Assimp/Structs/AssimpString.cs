// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Silk.NET.Assimp
{
    partial struct AssimpString
    {
        public unsafe AssimpString(string from)
        {
            var bytes = Encoding.UTF8.GetBytes(from);
            if (bytes.Length > 1024)
            {
                throw new ArgumentException("String too long, maximum length is 1024 UTF-8 bytes.", nameof(from));
            }

            Length = (uint)bytes.Length;
            for (var i = 0; i < bytes.Length; i++)
            {
                Data[i] = bytes[i];
            }
        }

        public unsafe string AsString => Encoding.UTF8.GetString((byte*) Unsafe.AsPointer(ref Data[0]), (int) Length);
        public override string ToString() => AsString;
    }
}
