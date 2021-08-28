// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Android.App;
using Android.Content.PM;
using Android.Provider;
using Org.Libsdl.App;
using Silk.NET.Core.Loader;
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
        internal static extern void SetupMain(nint funcPtr);

        static SilkActivity()
        {
            SearchPathContainer.Platform = UnderlyingPlatform.Android;
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
            if (Instance is not null)
            {
                throw new InvalidOperationException("Only one SilkActivity may be present throughout the whole application.");
            }

            Instance = this;
            SetupMain(SilkMarshal.DelegateToPtr(CurrentMain));
        }

        public override void SetOrientationBis(int w, int h, bool resizable, string hint)
        {
            // do nothing, Silk.NET respects the OS and doesn't want to do any meddling the consumer can't control.
        }

        protected abstract void OnRun();

        private void Run()
        {
            OnRun();
        }
    }
}
