// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Contexts;

namespace Silk.NET.Jupyter
{
    internal class JupyterGLContext : IGLContext
    {
        public JupyterGLContext(IGLContextSource? source)
        {
            Source = source;
        }

        public void Dispose()
        {
            
        }

        public nint GetProcAddress(string proc, int? slot = default)
        {
            throw new System.NotImplementedException();
        }

        public nint Handle => throw new NotImplementedException();
        public IGLContextSource? Source { get; }
        public bool IsCurrent => throw new NotImplementedException();
        public void SwapInterval(int interval)
        {
            throw new System.NotImplementedException();
        }

        public void SwapBuffers()
        {
            throw new System.NotImplementedException();
        }

        public void MakeCurrent()
        {
            throw new System.NotImplementedException();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }
    }
}
