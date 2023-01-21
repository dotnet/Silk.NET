# Summary

Using the managed `Silk.NET.Vulkan.Chain` and its generically-typed descendants can be unwieldy in the specific case of recieving chains
with known starting element(s) but potential unknown later elements, e.g. a `SwapchainCreateInfoKHR` which may or may not have an
`ImageCreateInfo` later in the chain. If use of the managed chain api is desired in this case, the untyped `Chain` type must be used
and the result of its indexer cast to the desired chain start type. This, combined with the public api surface on ``Chain`2`` being
a strict superset of ``Chain`1`` etc., a polymorphic interface is desired for handling variable-size chains.

# Contributors

- [Khitiara](https://github.com/Khitiara)

# Current Status

- [x] Proposed
- [x] Discussed with API Review Board (ARB)
- [x] Approved
- [ ] Implemented

# Design Decisions

- This is mainly useful in cases where the managed api and its automatic management of chain memory is desired. The unmanaged non-generic API
  already supports this use-case, so this function is mainly beneficial as method return types where chain extensions may not be known ahead of
  time, and thus `out` parameters for all unmanaged chain elements are not suitable.

# Proposed API

A series of generic interfaces are created to accompany the generic `Chain<...>` classes:

```csharp
public unsafe interface IChain<TChain> : IDisposable
     where TChain : unmanaged,  IChainable {
    public BaseInStructure* HeadPtr { get; }
    public TChain Head { get; set; }
}

public unsafe interface IChain<TChain, T1> : IChain<TChain>
     where TChain : unmanaged, IChainable
     where T1 : unmanaged, IChainable {
    public BaseInStructure* Item1Ptr { get; }
    public T1 Item1 { get; set; }
}

public unsafe interface IChain<TChain, T1, T2> : IChain<TChain, T1>
     where TChain : unmanaged, IChainable
     where T1 : unmanaged, IChainable
     where T2 : unmanaged, IChainable {
    public BaseInStructure* Item2Ptr { get; }
    public T2 Item2 { get; set; }
}

...
```

and the existing generic `Chain<...>` types are modified to implement these new interfaces:

```csharp
public unsafe sealed class Chain<TChain> : Chain, IEquatable<Chain<TChain>>, IChain<TChain>
    where TChain : unmanaged, IChainable {
    ...
}

public unsafe sealed class Chain<TChain, T1> : Chain, IEquatable<Chain<TChain, T1>>, IChain<TChain, T1>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable {
    ...    
}

public unsafe sealed class Chain<TChain, T1, T2> : Chain, IEquatable<Chain<TChain, T1, T2>>, IChain<TChain, T1, T2>
    where TChain : unmanaged, IChainable
    where T1 : unmanaged,  IChainable
    where T2 : unmanaged,  IChainable {
    ...
}

...
```

Usage:

```csharp
public IChain<ImageCreateInfo> DeduceImageCreateInfo(IChain<SwapchainCreateInfoKHR> swapchainCreateInfo) {
    ImageCreateInfo createInfo = ...;

    // condition here used for example - a TryFind extension or similar may be desirable in the long term
    if (swapchainCreateInfo is Chain<SwapchainCreateInfoKHR>(_, formatListCreateInfo)) {
        // Chain<TChain, T1> : IChain<TChain, T1> : IChain<TChain>
        return Chain.Create(createInfo, formatListCreateInfo); 
    }
    
    // Chain<TChain> : IChain<TChain>
    return Chain.Create(createInfo);
}

...

public void Foo() {
    SwapchainCreateInfoKHR sci = ...;
    using IChain<ImageCreateInfo> ici = DeduceImageCreateInfo(sci);
    ReadOnlySpan<Format> fmts = ici switch {
        Chain<ImageCreateInfo, ImageFormatListCreateInfo>(_, var formatList) => 
            new ReadOnlySpan<Format>(formatList.PViewFormats, (int)formatList.ViewFormatCount).ToArray(),
        Chain<ImageCreateInfo>(var i) => stackalloc[] { i.Format }
    }
}
```
