// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Core.Native
{
    public interface IVTable : IDisposable
    {
        void Initialize(INativeContext ctx, int maxSlots);
        nint Load(int slot, string entryPoint);
        void Purge();
    }
}
