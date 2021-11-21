---
{
    "TableOfContents": {
        "Name": "SilkTouch: Slots & VTables",
        "Url": "silktouch-slots-vtables.html",
        "Metadata": {
            "AuthorGitHub": "HurricanKai",
            "DateTimeWritten": "27/11/2020 09:00"
        }
    }
}
---

# SilkTouch: Slots & VTables

Please read [the previous blog post](../silktouch-invokes-marshalling.html), which introduces SilkTouch and it's core features Invokes & Marshalling.

This time, we are going to talk about this little yet essential part of SilkTouch and Silk.NET as a whole. We ignored this last time for simplicity. `(CurrentVTable as GeneratedVTable).Load(721, "glGetDebugMessageLog")`.
The quick break down is this, first, we cast `CurrentVTable to GeneratedVTable` to allow inlining, because it isn't a virtual call anymore (`GeneratedVTable` is a private sealed class).
Then, besides the native name, we pass a slot to the `Load` method.

## VTables
A VTable is basically a "tiny" abstraction around `INativeContext` it's defined as:

```cs
public interface IVTable : IDisposable
{
    void Initialize(INativeContext ctx, int maxSlots);
    IntPtr Load(int slot, string entryPoint);
    void Purge();
}
```

Pretty simple, right?
You may wonder what `INativeContext` is, if you are unfamiliar with Silk.NET.Core it's designed as

```cs
public interface INativeContext : IDisposable
{
    IntPtr GetProcAddress(string proc, int? slot = default);
}
```

And is implemented by GLFW / SDL and some default / composite types, and provides platform specific information on loading native symbols. It also powers overrides (see addendum)

Note that `INativeContext` does not cache anything, it's asked to always call directly down to whatever loading mechanism it wraps. This is where `IVTable` comes in.

## ConcurrentDictionaryVTable
The "default" `IVTable` we used was `ConcurrentDictionaryVTable`, and while it's still there, we don't use it anymore. We only use the generated VTables from SilkTouch. But it still serves as a good example of the basic functionality here.

So, let's go back to our interface. First of all, we know we have to store the `INativeContext` somewhere, to later load from, then, we can already know the maximum amount of unique slots we are every going to be queried for, and while it's not necessary, we can put that in as the maximum capacity of our `ConcurrentDictionary` now, I think it's obvious by now that the key of that dictionary is going to be an `int` (a slot), and maybe that the value is going to be `IntPtr` (the address we get back from `INativeContext.GetProcAddress`). 

Next, the `Load` method, it's pretty simple, we just use the `GetOrAdd` method on our dictionary to either the the existing address, or load it from the `INativeContext` and then store it into the dictionary.

Last and also least important, `Purge`. First of all, `Purge` does not reset the Initialize params, the `INativeContext` and the number of slots stays the same! So in this implementation, it's just using `Clear()`.

## How SilkTouch does it

Now SilkTouch knows a lot more about the slots. Basically it's just a compile-time Dictionary. In a nutshell, we generate one field per `entrypoint` and use the `slot` to find the appropriate field. `Purge` is just Zeroing all those fields, and `Initialize` just stores the `_ctx`.

This allows the whole lookup to be inlined, which allows maximum performance. Now, at first you'd think this will result in just one huuuuge Load function, lot's of `if (slot == x) return _...;` now, that was much first approach to, I've then quickly learned that JIT does not care how hard you tell it to aggressively inline and optimize, it refuses to inline.

## Making JIT inline
Now, it's pretty simple, it's like a binary search, we just sort all the slots, and generate for that section of slots (at the beginning these are all the slots). We then look whether the section of slots is an odd amount of slots, if it is, we load the lowest removing it from the slot section. As a fallback, we put an unreachable throw helper + `return default`.

Then, we take the mid slot and split again and we do that over and over and over again, recursively. This may be a bit of a surprise, but that means the JIT is happy to inline the whole thing.Loading, in this case means checking whether the field that was found is `IntPtr.Zero` and if it is, call `_ctx.Load` otherwise, just return it.

## AOT (Ahead of Time Compilation)
I've recently added support for AOT into Silk.NET, and with it came the idea to add a feature to SilkTouch, preloading. Basically, what it does, it gets rid of all those branches in the loading, and preloads all addresses when `Initialize` is called. This means that `Load` call to the `IVTable` is as good as it gets. Right now we use the `Cdecl` calling convention in all cases, but that's not hard coded into SilkTouch, it's configurable per-method, this does mean some overhead. Also, every call we have a GC transition, but again, not much we can do about that. in the middle of the cdecl clutter and the GC entry/exit is our amazing `call rax` which, to my knowledge is the best we can do right now. (If you know any way to improve this please contact me)

Well yeah and that's kind of it. Thanks again, and if you're interested, I encourage you to look at the source yourself, see [https://github.com/dotnet/Silk.NET/blob/v2.0.0/src/Core/Silk.NET.SilkTouch/VTableGeneration.cs](https://github.com/dotnet/Silk.NET/blob/v2.0.0/src/Core/Silk.NET.SilkTouch/VTableGeneration.cs)

---

## Addendum: Overrides
So overrides are the solution to conditionally changing the `INativeContext` in some cases.

On some platforms, specifically iOS, it's required to statically link the entire application, so trying to load functions from "glfw3.dll" won't work, since it's linked into the application itself, which can only be circumvented using `__Internal` which can only be used from P/Invoke.
So we had to go back to using P/Invoke.

We didn't want to rely on P/Invoke marshalling, so all P/Invoke signatures are what you would expect to find in the invoke function pointer, the native types, names, etc.
Now, to override this, but only sometimes, SilkTouch generates an override, which is then put into a function `CreateDefaultContext`. It just compares a parameter with the condition given in the attribute, and then either creates one of the overrides, and then returns either the override, or the default context.
In the generated override, we just put all the P/Invoke definitions, and then a binary tree similar to the one used in VTables, returning the pointer to the correct P/Invoke definition.

And that's it, it's pretty short, but there's not much to it. Once again, check out the relevant code [https://github.com/dotnet/Silk.NET/blob/v2.0.0/src/Core/Silk.NET.SilkTouch/NativeContextOverrides/PInvokeNativeContextOverride.cs](https://github.com/dotnet/Silk.NET/blob/v2.0.0/src/Core/Silk.NET.SilkTouch/NativeContextOverrides/PInvokeNativeContextOverride.cs)
You'll kind of get to see this running if you get the iOS or Android demo (included in preview3) running, which both use the P/Invoke override (the latter due to loading bugs). iOS (and Android) support is still pretty experimental, so not yet full glory :)
