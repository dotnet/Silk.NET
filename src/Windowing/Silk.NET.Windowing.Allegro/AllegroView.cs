// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Drawing;
using Silk.NET.Allegro;
using Silk.NET.Core.Contexts;
using Silk.NET.Windowing.Internals;
using Al = Silk.NET.Allegro.Allegro;

namespace Silk.NET.Windowing.Allegro
{
    public class AllegroView : ViewImplementationBase
    {
        private Al _allegro; 
        public AllegroView(ViewOptions opts) : base(opts)
        {
            _allegro = AllegroProvider.Allegro.Value;

        }

        protected override Size CoreSize { get; }
        protected override IntPtr CoreHandle { get; }
        protected override void CoreInitialize(ViewOptions opts)
        {
            throw new NotImplementedException();
        }

        protected override void CoreReset()
        {
            throw new NotImplementedException();
        }

        public override IGLContext? GLContext { get; }
        public override IVkSurface? VkSurface { get; }
        public override bool IsClosing { get; }
        public override VideoMode VideoMode { get; }
        public override bool IsEventDriven { get; set; }
        public override void DoEvents()
        {
            throw new NotImplementedException();
        }

        public override void ContinueEvents()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }

        protected override void RegisterCallbacks()
        {
            throw new NotImplementedException();
        }

        protected override void UnregisterCallbacks()
        {
            throw new NotImplementedException();
        }

        public override event Action<Size> Resize;
        public override event Action Closing;
        public override event Action<bool> FocusChanged;
        public override Point PointToClient(Point point)
        {
            throw new NotImplementedException();
        }

        public override Point PointToScreen(Point point)
        {
            throw new NotImplementedException();
        }
    }
}
