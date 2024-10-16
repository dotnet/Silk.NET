# Future Improvements

Initially when we were having design discussions around Silk.NET 3.0's Windowing API, we wanted to introduce a
lower-level API upon which our high-level API. The idea being that this would be an extensible API for which there would
be lower implementation friction and delegating common boilerplate code to a common higher-level implementation i.e.
there's very little work for us to do in mapping our API into new backends. This would functionally be a PAL, but the
details of this would depend on the actual requirements we derive as part of designing this API. Ultimately it was
determined that this work was simply out-of-scope for the initial 3.0 release as the extensibility benefits emerging
from having a lower-level API was determined to not be a requirement for the initial release, and was not included in
the original Working Group approved software development plan.

To ensure that such a lower-level API could be developed in the future, the `ISurfaceProvider` interface has been added,
the idea being that this would be implemented (possible by a default interface method) by the low-level API and there
would just be a common `Surface<TBackend>` returned by `ISurfaceProvider.Create` where `TBackend` is an implementation
of the low-level API. The `ITypeChain` type was also introduced to ensure we could have extensible configuration for
this model as well, so everything should be in place for us to investigate this in a minor release.

We're well aware this sounds very similar to what our friends at OpenTK are planning for 5.0, for much of the same
reasons. Indeed we still have community members who are also OpenTK community members that were advocating for it for
this reason. It's great to consider this sort of prior art, the sharing of insights and lifting eachother up is what
makes open-source amazing after all. We should also consider how other libraries like SDL and GLFW handle this
internally. Much like OpenTK, there is motivation for adding a lower-level API to Silk.NET to reduce the implementation
friction in adding more windowing backends as we believe esoteric platforms like mobile could be served well by them.
Unlike OpenTK, for desktop there's less appetite due to the shear number of platforms that would cause a lot of
maintenance effort - OpenTK 4.0 moved to use GLFW because of this, and most of the issues logged before this were
regarding its per-platform custom implementations, whereas Silk.NET 3.0 is keen to optimise for maintainability and
delegating maintenance effort to more expert sources (as we have done for SilkTouch by using ClangSharp's P/Invoke
Generator) like SDL is part of this so we can focus on crafting the best user experience specific to our project. Hence
why even if we would add this lower-level API, unlike OpenTK 5.0 I don't think we'd use it to implement desktop
windowing ourselves. But that can change after the initial release, and in any case having this lower-level API would be
useful.

When reviewing OpenTK specifically, their API design is indeed sound however the mechanisms by which it was exposed to
the higher-level API left a lot to be desired. Namely, using a dictionary of enums to implementations did not feel like
the best way to do this. There are likely more intelligent things we can do with the type system to make these patterns
more JIT friendly and also more extensible - having an enum enumerating the component types requires the extensibility
model to be defined in a way that is contrary to how the type system works e.g. to define components that are extensions
beyond our standard set. It was also deemed to be desirable to use `static abstract`s for this sort of low-level API,
which does help towards JIT friendliness, but this needn't prejudice any future efforts towards these goals - this was
just an idea.

Ultimately, to make our solution more write-once-run-everywhere, the API design philosophy behind the `Surface`
type was primarily to make it seem like a modular "component bag" e.g. `window.OpenGL` for OpenGL-specific
functionality, rather than having specific APIs always exposed as part of the standard interface but only valid for
usage in specific circumstances. The `IView` separation in 2.X achieved what we wanted somewhat, but this again left a
lot to be desired given that writing against `IView` instead of `IWindow` is contrary to what most users were doing
(this is also likely a symptom of being an afterthought introduced quite late into the 1.0 Preview cycle). By using this
design philosophy, our users have to get used to not assuming that functionality is available, meaning that users are
encouraged to write in a way that is portable instead of them having to go out of their way by writing against `IView`
as in 1.X and 2.X.

As for the extensibility goals (i.e. additional components being defined on top of our standard API), my hope was to
eventually have a `GetComponent` API on `Surface` which things like `window.OpenGL` were defined on top of. This has
been excluded from the 3.0 initial release, but we could in theory add something like this without the PAL concepts in
this document being implemented - a component-based architecture for our high-level API and a component-based
architecture for our low-level API can be developed independently. An example of why we might want this is a virtual
reality extension that manages the creation of OpenXR bindings from a surface, but this is just one example. It is
possible that "extension everything" might make this easier on the user while also making it easier for us (e.g.
extension everything defining an `window.OpenXR` property that implicitly checks the component can be created or
whatever, `DependentHandle` can probably used for this if we wanted or we could just use `window is IMyComponent` -
again these are all just ideas, this is just to demonstrate the idea of the API shape). Way earlier in 3.0's development
we were discussing the use of `IDynamicInterfaceCastable`, but the Silk.NET team were not able to implement support for
this in the Mono runtime in an acceptable timeframe and complexity level. All of these details depend on how and if we
make it possible to attach components to existing implementations without requiring modification of the original
backend. I would quite like this to be the case, but again it depends on the nature of the high-level component-based
architecture and/or the low-level component-based architecture i.e. where is the extensibility point.

As much as we didn't continue down the path illustrated in this document, it was certainly explored somewhat before we
decided it wasn't needed for 3.0 (engineers like to overengineer, go figure). The first exploration was essentially a
static dependency injection API i.e. a [`IHluComponentRegistry`](https://github.com/dotnet/Silk.NET/blob/56af8e1b34dc41a43de10dff45d09d25f12e8e57/sources/Core/Core/Abstractions/IHluComponentRegistry.cs)
provides components (these can be changed together for extensibility) that configures a [`Surface`](https://github.com/dotnet/Silk.NET/blob/56af8e1b34dc41a43de10dff45d09d25f12e8e57/sources/Windowing/Common/Surface.cs)
(well, a [`IHluComponentHost`](https://github.com/dotnet/Silk.NET/blob/56af8e1b34dc41a43de10dff45d09d25f12e8e57/sources/Core/Core/Abstractions/IHluComponentHost.cs)
which `Surface` implements) with the components. There was also some [source generator magic](https://github.com/dotnet/Silk.NET/blob/56af8e1b34dc41a43de10dff45d09d25f12e8e57/sources/Core/Analyzers/HluSourceGenerator.Hosts.cs)
explored to make this more JIT friendly, but that itself had some downsides e.g. one object being an implementation type
of multiple component types had two references stored in the surface. These problems aren't insurmountable but
ultimately it was determined that making an entire dependency injection API just for this was a bit silly.

After this attempt at implementing these concepts, another attempt was made that encompassed the low-level API desired
to reduce implementation friction. Essentially, [`ISurfaceHost`](https://github.com/dotnet/Silk.NET/blob/129d4957ce1058252723add2f6890fb53f234432/sources/Windowing/Common/Hosting/ISurfaceHost.cs)
had a bunch of lower-level APIs as `static abstract`s that essentially boiled down to "get a property, set a property"
on surface objects or surface requests. Didn't quite get round to implementing the "additional component" extensibility
concepts described but this could likely be done using type chaining and essentially changing those get/set property
methods to accept a generic "property type", but again these are just ideas - this was never realised or prototyped.
This was progressing well enough, and had some decent benefits as well like centralising all the [multi-threading logic](https://github.com/dotnet/Silk.NET/blob/129d4957ce1058252723add2f6890fb53f234432/sources/Windowing/Common/Hosting/MultiThreadedSurfaceHost%601.cs)
at the lowest level of implementation.

All in all, there's a lot of benefits to having a modular, component-based, and extensible approach to designing our
windowing API and this is definitely something we're keen to pursue. But for now, we determined that for the 3.0 initial
release we only needed to do this for the user-facing API (as per the goals stated in the SDP to make the API more
encouraging of write-once-run-everywhere) and as much as we want to fulfill that `GetComponent` extensibility vision to
allow extensions of our standard API set, that also isn't needed for the initial release. Nonetheless, it was key to
ensure we had enough jumping off points to ensure this can be implemented in the future, and also to implement the
lower-level, implementation-facing API to make our life easier if we did want to add more backends outside of SDL.
