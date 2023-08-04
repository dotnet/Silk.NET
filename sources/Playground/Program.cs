// See https://aka.ms/new-console-template for more information

using static Silk.NET.GLFW.Glfw;

// TODO bool-like
if (glfwInit() == 0)
{
    throw new Exception("failed to init");
}

var window = glfwCreateWindow(1280, 720, "Hello Window!", nullptr, nullptr);
if (window == nullptr)
{
    // TODO const correctness
    ConstPtr<sbyte> error = nullptr;
    if (glfwGetError(error.AsPtr2D()) == 0 || error == nullptr)
    {
        throw new Exception("failed to create window and failed to get error");
    }

    throw new Exception($"failed to create window: {error}");
}

while (glfwWindowShouldClose(window) == 0)
{
    glfwPollEvents();
}

glfwDestroyWindow(window);
glfwTerminate();
