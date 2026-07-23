// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenCL;

public partial class Cl
{
    public const string ErrMultiplePlatformSingleObject =
        "CurrentPlatform cannot be changed once set, use another API object for additional platforms. For more "
        + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings";

    static Cl() => LoaderInterface.RegisterHook(Assembly.GetExecutingAssembly());

    public partial class StaticWrapper<T>
    {
        public PlatformIdHandle CurrentPlatform
        {
            get;
            set
            {
                if (field == value)
                {
                    return;
                }

                if (field != nullptr)
                {
                    throw new InvalidOperationException(ErrMultiplePlatformSingleObject);
                }

                field = value;
            }
        }

        public ICl Clone() => new StaticWrapper<T>();
    }

    public partial class ThisThread
    {
        public static partial void MakeCurrent(ICl ctx) => Underlying.Value = ctx;
    }

    public PlatformIdHandle CurrentPlatform
    {
        get;
        set
        {
            if (field == value)
            {
                return;
            }

            if (field != nullptr)
            {
                throw new InvalidOperationException(ErrMultiplePlatformSingleObject);
            }

            field = value;
        }
    }

    public static ICl Create()
    {
        var context = new NativeContext();
        var cl = new Cl(context);
        context.Cl = cl;

        return cl;
    }

    public unsafe ICl Clone()
    {
        var context = new NativeContext();
        var cl = new Cl(context);

        context.Cl = cl;

        cl.CurrentPlatform = CurrentPlatform;
        Array.Copy(_slots, cl._slots, _slots.Length);

        return cl;
    }

    private class NativeContext : INativeContext
    {
        public Cl Cl { get; set; } = null!;
        private ICl Icl => Cl;

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (functionName == "clGetExtensionFunctionAddressForPlatform")
            {
                return (delegate* unmanaged<PlatformIdHandle, sbyte*, void*>)
                    &GetExtensionFunctionAddressForPlatform;
            }

            return Icl.GetExtensionFunctionAddressForPlatform(Cl.CurrentPlatform, functionName);
        }

        [UnmanagedCallersOnly]
        private static unsafe void* GetExtensionFunctionAddressForPlatform(
            PlatformIdHandle instance,
            sbyte* name
        ) => DllImport.GetExtensionFunctionAddressForPlatform(instance, name);

        public void Dispose() { }
    }
}
