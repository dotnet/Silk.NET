using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.Windowing.Sdl.iOS
{
    public static class SilkMobile
    {
        static SilkMobile()
        {
            SearchPathContainer.Platform = UnderlyingPlatform.IOS;
        }
        
        private static bool _running;
        private static MainFunction? CurrentMain { get; set; }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public unsafe delegate void MainFunction(int numArgs, byte** args);
        [DllImport("__Internal", EntryPoint = "SDL_UIKitRunApp")]
        private static extern unsafe void CoreRunApp(int numArgs, byte** args, IntPtr callback);
            
        public static unsafe void RunApp(int numArgs, byte** args, IntPtr callback)
        {
            BeginRun();
            CoreRunApp(numArgs, args, callback);
            EndRun();
        }

        public static unsafe void RunApp(IReadOnlyList<string> args, IntPtr callback)
        {
            BeginRun();
            var argsPtr = SilkMarshal.StringArrayToPtr(args);
            CoreRunApp(args.Count, (byte**)argsPtr, callback);
            SilkMarshal.Free(argsPtr);
            EndRun();
        }
            
        public static unsafe void RunApp(int numArgs, byte** args, MainFunction callback)
        {
            BeginRun();
            CurrentMain = callback;
            CoreRunApp(numArgs, args, GetCallMainPtr());
            CurrentMain = null;
            EndRun();
        }

        public static unsafe void RunApp(int numArgs, byte** args, Action<string[]> callback)
        {
            BeginRun();
            CurrentMain = (inNumArgs, argsPtr) => callback(SilkMarshal.PtrToStringArray((IntPtr)argsPtr, inNumArgs));
            CoreRunApp(numArgs, args, GetCallMainPtr());
            CurrentMain = null;
            EndRun();
        }

        public static unsafe void RunApp(IReadOnlyList<string> args, MainFunction callback)
        {
            BeginRun();
            var argsPtr = SilkMarshal.StringArrayToPtr(args);
            CurrentMain = callback;
            CoreRunApp(args.Count, (byte**)argsPtr, GetCallMainPtr());
            CurrentMain = null;
            SilkMarshal.Free(argsPtr);
            EndRun();
        }

        public static unsafe void RunApp(IReadOnlyList<string> args, Action<string[]> callback)
        {
            BeginRun();
            var argsPtr = SilkMarshal.StringArrayToPtr(args);
            CurrentMain = (numArgs, inArgsPtr) => callback(SilkMarshal.PtrToStringArray((IntPtr)inArgsPtr, numArgs));
            CoreRunApp(args.Count, (byte**)argsPtr, GetCallMainPtr());
            CurrentMain = null;
            SilkMarshal.Free(argsPtr);
            EndRun();
        }

        [MonoPInvokeCallback(typeof(MainFunction))]
        private static unsafe void CallMain(int numArgs, byte** args) => CurrentMain!(numArgs, args);
        
        private static unsafe IntPtr GetCallMainPtr()
            => Marshal.GetFunctionPointerForDelegate((MainFunction) CallMain);

        private static void BeginRun()
        {
            if (_running)
            {
                throw new InvalidOperationException("App already running.");
            }

            SdlWindowing.RegisterPlatform();
            _running = true;
        }

        private static void EndRun() => _running = false;
    }
}
