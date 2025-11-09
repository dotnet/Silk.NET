// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL;

public partial class ALContext
{
    static ALContext() =>
        LoaderInterface.RegisterAlternativeName(
            "openal",
            "/System/Library/Frameworks/OpenAL.framework/OpenAL"
        );

    public unsafe partial class DllImport
    {
        [UnmanagedCallersOnly]
        internal static unsafe void* GetProcAddressTrampoline(
            DeviceHandle device,
            sbyte* funcname
        ) => GetProcAddress(device, funcname);

        public static partial sbyte MakeContextCurrentRaw(ContextHandle context) =>
            MakeContextCurrentInternal(context);

        public static partial DeviceHandle OpenDevice(sbyte* devicename) =>
            OpenDeviceInternal(devicename);
    }

    public partial class StaticWrapper<T>
    {
        public IALContext Clone() => new StaticWrapper<T>();
    }

    private Dictionary<ContextHandle, AL>? _contexts = null;
    private unsafe delegate* unmanaged<DeviceHandle, sbyte*, void*> _getProcAddress;

    public unsafe DeviceHandle CurrentDevice
    {
        get;
        set
        {
            if (field != nullptr)
            {
                throw new InvalidOperationException(
                    "CurrentDevice cannot be changed once set, use another API object for additional devices. For more "
                        + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings"
                );
            }

            _getProcAddress = null;
            field = value;
        }
    }

    private unsafe ALContext(INativeContext nativeContext, ALContext cloneFrom)
        : this(nativeContext)
    {
        _slots = new void*[cloneFrom._slots.Length];
#pragma warning disable CA2018
        Buffer.BlockCopy(cloneFrom._slots, 0, _slots, 0, _slots.Length);
#pragma warning restore CA2018
        _getProcAddress = cloneFrom._getProcAddress;
    }

    public IALContext Clone() => new ALContext(nativeContext, this);

    private class NativeContext : INativeContext
    {
        public ALContext ALC { get; set; } = null!;

        public void Dispose() => throw new NotImplementedException();

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (ALC._getProcAddress == null)
            {
                var getProcAddress = (delegate* unmanaged<DeviceHandle, sbyte*, void*>)
                    DllImport.GetProcAddress(ALC.CurrentDevice, "alcGetProcAddress2");
                ALC._getProcAddress =
                    getProcAddress == null ? &DllImport.GetProcAddressTrampoline : getProcAddress;
            }

            var fname =
                functionName.Length < 128
                    ? stackalloc byte[functionName.Length]
                    : new byte[functionName.Length];
            fname[Encoding.UTF8.GetBytes(functionName, fname)] = 0;
            fixed (byte* pFName = fname)
            {
                return ALC._getProcAddress(ALC.CurrentDevice, (sbyte*)pFName);
            }
        }
    }

    class AudioContext(ALContext alc, ContextHandle context) : INativeContext
    {
        private bool _direct;
        private Ptr _getProcAddress;

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (_getProcAddress == nullptr)
            {
                var dev = ((IALContext)alc).GetContextsDevice(context);
                _direct = ((IALContext)alc).IsExtensionPresent(dev, "AL_EXT_direct_context");
                _getProcAddress = _direct
                    ? ((IALContext)alc).GetProcAddress2(dev, "alGetProcAddressDirect")
                    : ((IALContext)alc).GetProcAddress(dev, "alGetProcAddress");
            }

            var fname =
                functionName.Length < 128
                    ? stackalloc byte[functionName.Length]
                    : new byte[functionName.Length];
            fname[Encoding.UTF8.GetBytes(functionName, fname)] = 0;
            fixed (byte* pFName = fname)
            {
                return _direct
                    ? ((delegate* unmanaged<ContextHandle, sbyte*, void*>)_getProcAddress)(
                        context,
                        (sbyte*)pFName
                    )
                    : ((delegate* unmanaged<sbyte*, void*>)_getProcAddress)((sbyte*)pFName);
            }
        }

        private void ReleaseUnmanagedResources() => ((IALContext)alc).DestroyContext(context);

        internal int RefCount = 0;

        private void Dispose(bool disposing)
        {
            if (Interlocked.Decrement(ref RefCount) > 0)
            {
                return;
            }

            if (disposing)
            {
                alc._contexts?.Remove(context);
            }

            ReleaseUnmanagedResources();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~AudioContext() => Dispose(false);
    }

    sbyte IALContext.MakeContextCurrentRaw(ContextHandle context)
    {
        var ret = MakeContextCurrentInternal(context);
        if (ret)
        {
            AL.ThisThread.MakeCurrent(GetOrCreateAL(context));
        }

        return ret;
    }

    private AL GetOrCreateAL(ContextHandle context)
    {
        var ret = (_contexts ??= []).TryGetValue(context, out var ctx)
            ? ctx
            : _contexts[context] = new AL(new AudioContext(this, context));
        Interlocked.Increment(ref ((AudioContext)ret.Context).RefCount);
        return ret;
    }

    public IAL CreateOpenAL(ContextHandle context) => GetOrCreateAL(context);

    public IAL CreateOpenAL(DeviceHandle device, Ref<int> attrList)
    {
        var ctx = CreateContext(device, attrList);
        return ctx == nullptr
            // TODO custom exception type
            ? throw new InvalidOperationException(
                $"alcCreateContext returned error: {(ErrorCode)GetError(device)}"
            )
            : CreateOpenAL(ctx);
    }

    public static IALContext Create() => Create(new NativeContext());

    unsafe DeviceHandle IALContext.OpenDevice(sbyte* devicename)
    {
        var ret = OpenDevice(devicename);
        if (ret != nullptr)
        {
            CurrentDevice = ret;
        }

        return ret;
    }
}
