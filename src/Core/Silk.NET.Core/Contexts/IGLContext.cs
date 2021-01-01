// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Contexts
{
    public interface IGLContext : INativeContext, IDisposable
    {
        nint Handle { get; }
        IGLContextSource? Source { get; }
        bool IsCurrent { get; }
        void SwapInterval(int interval);
        void SwapBuffers();
        void MakeCurrent();
        void Clear();
    }
}
