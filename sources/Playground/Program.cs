// See https://aka.ms/new-console-template for more information

// TODO bool-like

using Silk.NET.GLFW;

if (Glfw.Init() == 0)
{
    throw new Exception("failed to init");
}

var window = Glfw.CreateWindow(1280, 720, "Hello Window!", nullptr, nullptr);
if (window == nullptr)
{
    // TODO const correctness
    ConstPtr<sbyte> error = nullptr;
    if (Glfw.GetError(error.AsPtr2D()) == 0 || error == nullptr)
    {
        throw new Exception("failed to create window and failed to get error");
    }

    throw new Exception($"failed to create window: {error}");
}

while (Glfw.WindowShouldClose(window) == 0)
{
    Glfw.PollEvents();
}

Glfw.DestroyWindow(window);
Glfw.Terminate();
