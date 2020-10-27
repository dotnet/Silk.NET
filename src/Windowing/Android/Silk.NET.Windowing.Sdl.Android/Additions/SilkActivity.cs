// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;
using Android.App;
using Android.Content.PM;
using Org.Libsdl.App;
using Silk.NET.Core.Native;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl.Android
{
    public abstract class SilkActivity : SDLActivity
    {
        public const ConfigChanges ConfigChangesFlags =
            ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize;
        
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        internal delegate void MainFunc();

        internal static SilkActivity Instance { get; private set; }
        internal static MainFunc CurrentMain { get; private set; }

        [DllImport("libmain.so", EntryPoint = "sdSetMain")]
        internal static extern void SetupMain(FuncPtr funcPtr);

        static SilkActivity()
        {
            CurrentMain = Main;
        }

        internal static unsafe void Main()
        {
            if (Instance is null)
            {
                throw new InvalidOperationException("No SilkActivity present.");
            }

            // SdlProvider.SetMainReady = true;
            Instance.Run();
            Instance = null;
        }

        public override unsafe void LoadLibraries()
        {
            base.LoadLibraries();
            if (!(Instance is null))
            {
                throw new InvalidOperationException("Only one SilkActivity may be present throughout the whole application.");
            }

            Instance = this;
            SetupMain(FuncPtr.Of(CurrentMain));
        }

        protected abstract void OnRun();

        private void Run()
        {
            OnRun();
        }
    }
}
