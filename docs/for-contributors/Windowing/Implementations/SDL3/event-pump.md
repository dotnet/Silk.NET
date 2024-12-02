# The Event Pump

The largest influence in the `ISurfaceApplication` design is the fact that for many platforms only the entry thread is
allowed to interact with the window manager (e.g. for the purposes of events). This creates a problem because rendering
is very much not single-threaded, nor are most use cases where the user has multiple windows. As such,
`ISurfaceApplication` gives the implementation freedom to decide what the most appropriate thread is to call into the
surface to raise events. This is further emphasised by the definition of `ISurfaceChildren` where the user can only
`Spawn` a surface, and not have a blocking call they can send off to their own thread. This allows the child windows to
use the same event thread and synchronization. This is likely inconvenient for rendering scenarios though
(e.g. for OpenGL where it's one thread per context/window, but all surfaces use the same thread by default...), for
which I expect that we'll add the ability to multithread for certain events in `SurfaceTimingOptions` or
`SurfaceTickOptions`. This however has been excluded from the initial 3.0 proposal.

Note that `SDL_AppEvent` is only guaranteed to be called on the event thread for events raised by the window
manager/operating system. As such, we always assume that those events are on the event thread when received and invoke
the window directly. For other events, we should be wary of concurrency. Note that I have absolutely no idea what this
means for things like our `Surface.Continue` method for `IsEventDriven` - right now this isn't implemented. Read more
here: https://github.com/libsdl-org/SDL/issues/11387
