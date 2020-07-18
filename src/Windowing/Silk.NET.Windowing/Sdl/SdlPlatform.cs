// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Sdl
{
    internal class SdlPlatform : IWindowPlatform
    {
        public IWindow CreateWindow(WindowOptions opts)
        {
            throw new System.NotImplementedException();
        }

        public bool IsViewOnly { get; }
        public bool IsApplicable { get; }
        public IView GetView(ViewOptions? opts = null)
        {
            throw new System.NotImplementedException();
        }

        public void ClearContexts()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<IMonitor> GetMonitors()
        {
            throw new System.NotImplementedException();
        }

        public IMonitor GetMainMonitor()
        {
            throw new System.NotImplementedException();
        }
    }
}
