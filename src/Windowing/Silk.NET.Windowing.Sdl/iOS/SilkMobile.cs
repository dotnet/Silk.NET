using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.SDL;

namespace Silk.NET.Windowing.Sdl.iOS
{
    [Obsolete(
        "Upon its graduation from experimental status in Silk.NET 2.22, SilkMobile is now implicit behaviour when " +
        "calling IView.Run. SilkMobile should no longer be used and its continued usage may cause unexpected " +
        "behaviour (e.g. with Game Center integration)."
    )]
    public static class SilkMobile
    {
        static SilkMobile()
        {
            SearchPathContainer.Platform = UnderlyingPlatform.IOS;
        }

        public static bool IsRunning { get; private set; }

        private static MainFunction? CurrentMain { get; set; }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        [MonoPInvokeCallback]
        public unsafe delegate void MainFunction(int numArgs, byte** args);

        [DllImport("__Internal", EntryPoint = "SDL_UIKitRunApp")]
        private static extern unsafe void CoreRunApp(int numArgs, byte** args, nint callback);

        public static unsafe void RunApp(int numArgs, byte** args, nint callback)
        {
            BeginRun();
            CoreRunApp(numArgs, args, callback);
            EndRun();
        }

        public static unsafe void RunApp(IReadOnlyList<string> args, nint callback)
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

        public static unsafe void RunApp(int numArgs, byte** args, System.Action<string[]> callback)
        {
            BeginRun();
            CurrentMain = (inNumArgs, argsPtr) => callback(SilkMarshal.PtrToStringArray((nint)argsPtr, inNumArgs));
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

        public static unsafe void RunApp(IReadOnlyList<string> args, System.Action<string[]> callback)
        {
            BeginRun();
            var argsPtr = SilkMarshal.StringArrayToPtr(args);
            CurrentMain = (numArgs, inArgsPtr) => callback(SilkMarshal.PtrToStringArray((nint)inArgsPtr, numArgs));
            CoreRunApp(args.Count, (byte**)argsPtr, GetCallMainPtr());
            CurrentMain = null;
            SilkMarshal.Free(argsPtr);
            EndRun();
        }

        [UnmanagedCallersOnly(CallConvs = new[]{typeof(CallConvCdecl)})]
        private static unsafe int CallMain(int numArgs, byte** args)
        {
            CurrentMain!(numArgs, args);
            return 0; // We screwed up when originally adding this...
        }

        private static unsafe nint GetCallMainPtr()
            => (PfnMainFunc)(delegate* unmanaged[Cdecl]<int, byte**, int>) &CallMain;

        private static void BeginRun()
        {
            if (IsRunning)
            {
                throw new System.InvalidOperationException("App already running.");
            }

            SdlWindowing.RegisterPlatform();
            IsRunning = true;
        }

        private static void EndRun() => IsRunning = false;

        // We need to keep Microsoft.iOS.dll from being linked out, and to do that we need to reference MainFunction
        // which references MonoPInvokeCallback which is in Microsoft.iOS.dll.
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
        private static unsafe void Dummy() => Marshal.GetFunctionPointerForDelegate<MainFunction>((_, _) => {});
    }
}
