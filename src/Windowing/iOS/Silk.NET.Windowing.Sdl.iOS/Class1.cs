using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Silk.NET.Core.Native;

namespace Silk.NET.Windowing.Sdl.iOS
{
    public static class SilkMobile
    {
        [DllImport("__Internal", EntryPoint = "SDL_UIKitRunApp")]
        public static extern unsafe void RunApp(int numArgs, byte** args, delegate* unmanaged[Cdecl]<int, byte**> callback);
            
        public static unsafe void RunApp(IReadOnlyList<string> args, delegate* unmanaged[Cdecl]<int, byte**> callback)
        {
            var argsPtr = SilkMarshal.MarshalStringArrayToPtr(args);
            RunApp(args.Count, (byte**)argsPtr, callback);
            SilkMarshal.FreeStringArrayPtr(argsPtr, args.Count);
        }

        public unsafe delegate void MainFunction(int numArgs, byte** args);
            
        public static unsafe void RunApp(int numArgs, byte** args, MainFunction callback)
        {
            var callbackPtr = (delegate* unmanaged[Cdecl]<int, byte**>)FuncPtr.Of(callback).Value;
            RunApp(numArgs, args, callbackPtr);
        }

        public static unsafe void RunApp(int numArgs, byte** args, Action<string[]> callback)
        {
            var callbackPtr = (delegate* unmanaged[Cdecl]<int, byte**>)FuncPtr.Of<MainFunction>(
                (numArgs, argsPtr) => callback(SilkMarshal.MarshalPtrToStringArray((IntPtr)argsPtr, numArgs))).Value;
            RunApp(numArgs, args, callbackPtr);
        }
            
        public static unsafe void RunApp(IReadOnlyList<string> args, MainFunction callback)
        {
            var argsPtr = SilkMarshal.MarshalStringArrayToPtr(args);
            var callbackPtr = (delegate* unmanaged[Cdecl]<int, byte**>)FuncPtr.Of(callback).Value;
            RunApp(args.Count, (byte**)argsPtr, callbackPtr);
            SilkMarshal.FreeStringArrayPtr(argsPtr, args.Count);
        }

        public static unsafe void RunApp(IReadOnlyList<string> args, Action<string[]> callback)
        {
            var argsPtr = SilkMarshal.MarshalStringArrayToPtr(args);
            var callbackPtr = (delegate* unmanaged[Cdecl]<int, byte**>)FuncPtr.Of<MainFunction>(
                (numArgs, argsPtr) => callback(SilkMarshal.MarshalPtrToStringArray((IntPtr)argsPtr, numArgs))).Value;
            RunApp(args.Count, (byte**)argsPtr, callbackPtr);
            SilkMarshal.FreeStringArrayPtr(argsPtr, args.Count);
        }
    }
}
