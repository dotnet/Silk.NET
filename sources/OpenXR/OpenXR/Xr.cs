using System.Reflection;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenXR;

public partial class Xr
{
    public const string ErrMultipleInstanceSingleObject =
        "CurrentInstance cannot be changed once set, use another API object for additional instances. For more "
        + "info, see https://dotnet.github.io/Silk.NET/docs/v3/silk.net/static-vs-instance-bindings";

    public unsafe partial class DllImport
    {
        public static partial Result CreateInstance(
            InstanceCreateInfo* createInfo,
            InstanceHandle* instance
        ) => CreateInstanceInternal(createInfo, instance);
    }

    public partial class StaticWrapper<T>
    {
        public InstanceHandle CurrentInstance
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
                    throw new InvalidOperationException(ErrMultipleInstanceSingleObject);
                }

                field = value;
            }
        }

        public IXr Clone() => new StaticWrapper<T>();
    }

    public partial class ThisThread
    {
        private static partial IXr ContextFactory() => Create();
    }

    public InstanceHandle CurrentInstance
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
                throw new InvalidOperationException(ErrMultipleInstanceSingleObject);
            }

            field = value;
        }
    }

    public static IXr Create()
    {
        var context = new NativeContext();
        var xr = new Xr(context);
        context.Xr = xr;

        return xr;
    }

    public unsafe IXr Clone()
    {
        var context = new NativeContext();
        var xr = new Xr(context);

        context.Xr = xr;

        xr.CurrentInstance = CurrentInstance;
        Array.Copy(_slots, xr._slots, _slots.Length);

        return xr;
    }

    unsafe Result IXr.CreateInstance(InstanceCreateInfo* createInfo, InstanceHandle* instance)
    {
        var result = CreateInstanceInternal(createInfo, instance);
        if (result == Result.Success)
        {
            CurrentInstance = *instance;
        }

        return result;
    }

    private class NativeContext : INativeContext
    {
        public Xr Xr { get; set; } = null!;
        private IXr Ixr => Xr;

        public unsafe void* LoadFunction(string functionName, string libraryNameHint)
        {
            if (functionName == "xrGetInstanceProcAddr")
            {
                return (delegate* unmanaged<InstanceHandle, sbyte*, VoidFunction*, Result>)
                    &GetInstanceProcAddr;
            }

            VoidFunction* function = default;
            var result = Ixr.GetInstanceProcAddr(Xr.CurrentInstance, functionName, function);
            if (result != Result.Success)
            {
                return null;
            }

            return function->Handle;
        }

        [UnmanagedCallersOnly]
        private static unsafe Result GetInstanceProcAddr(
            InstanceHandle instance,
            sbyte* name,
            VoidFunction* function
        ) => DllImport.GetInstanceProcAddr(instance, name, function);

        public void Dispose() { }
    }
}
