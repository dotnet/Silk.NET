// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.
using System.Runtime.InteropServices;

namespace Silk.NET.GLFW;
public static unsafe partial class Glfw
{
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwInit();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwTerminate();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwInitHint(int hint, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwInitAllocator([NativeTypeName("const GLFWallocator *")] GLFWallocator* allocator);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetVersion(int* major, int* minor, int* rev);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetVersionString();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetError([NativeTypeName("const char **")] sbyte** description);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWerrorfun")]
    public static extern delegate* unmanaged<int, sbyte*, void> glfwSetErrorCallback([NativeTypeName("GLFWerrorfun")] delegate* unmanaged<int, sbyte*, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetPlatform();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwPlatformSupported(int platform);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWmonitor** glfwGetMonitors(int* count);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWmonitor* glfwGetPrimaryMonitor();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetMonitorPos(GLFWmonitor* monitor, int* xpos, int* ypos);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetMonitorWorkarea(GLFWmonitor* monitor, int* xpos, int* ypos, int* width, int* height);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetMonitorPhysicalSize(GLFWmonitor* monitor, int* widthMM, int* heightMM);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetMonitorContentScale(GLFWmonitor* monitor, float* xscale, float* yscale);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetMonitorName(GLFWmonitor* monitor);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetMonitorUserPointer(GLFWmonitor* monitor, void* pointer);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void* glfwGetMonitorUserPointer(GLFWmonitor* monitor);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWmonitorfun")]
    public static extern delegate* unmanaged<GLFWmonitor*, int, void> glfwSetMonitorCallback([NativeTypeName("GLFWmonitorfun")] delegate* unmanaged<GLFWmonitor*, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const GLFWvidmode *")]
    public static extern GLFWvidmode* glfwGetVideoModes(GLFWmonitor* monitor, int* count);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const GLFWvidmode *")]
    public static extern GLFWvidmode* glfwGetVideoMode(GLFWmonitor* monitor);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetGamma(GLFWmonitor* monitor, float gamma);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const GLFWgammaramp *")]
    public static extern GLFWgammaramp* glfwGetGammaRamp(GLFWmonitor* monitor);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetGammaRamp(GLFWmonitor* monitor, [NativeTypeName("const GLFWgammaramp *")] GLFWgammaramp* ramp);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwDefaultWindowHints();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWindowHint(int hint, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWindowHintString(int hint, [NativeTypeName("const char *")] sbyte* value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWwindow* glfwCreateWindow(int width, int height, [NativeTypeName("const char *")] sbyte* title, GLFWmonitor* monitor, GLFWwindow* share);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwDestroyWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwWindowShouldClose(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowShouldClose(GLFWwindow* window, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowTitle(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* title);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowIcon(GLFWwindow* window, int count, [NativeTypeName("const GLFWimage *")] GLFWimage* images);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetWindowPos(GLFWwindow* window, int* xpos, int* ypos);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowPos(GLFWwindow* window, int xpos, int ypos);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetWindowSize(GLFWwindow* window, int* width, int* height);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowSizeLimits(GLFWwindow* window, int minwidth, int minheight, int maxwidth, int maxheight);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowAspectRatio(GLFWwindow* window, int numer, int denom);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowSize(GLFWwindow* window, int width, int height);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetFramebufferSize(GLFWwindow* window, int* width, int* height);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetWindowFrameSize(GLFWwindow* window, int* left, int* top, int* right, int* bottom);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetWindowContentScale(GLFWwindow* window, float* xscale, float* yscale);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern float glfwGetWindowOpacity(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowOpacity(GLFWwindow* window, float opacity);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwIconifyWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwRestoreWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwMaximizeWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwShowWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwHideWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwFocusWindow(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwRequestWindowAttention(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWmonitor* glfwGetWindowMonitor(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowMonitor(GLFWwindow* window, GLFWmonitor* monitor, int xpos, int ypos, int width, int height, int refreshRate);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetWindowAttrib(GLFWwindow* window, int attrib);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowAttrib(GLFWwindow* window, int attrib, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetWindowUserPointer(GLFWwindow* window, void* pointer);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void* glfwGetWindowUserPointer(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowposfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetWindowPosCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowposfun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowsizefun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetWindowSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowsizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowclosefun")]
    public static extern delegate* unmanaged<GLFWwindow*, void> glfwSetWindowCloseCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowclosefun")] delegate* unmanaged<GLFWwindow*, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowrefreshfun")]
    public static extern delegate* unmanaged<GLFWwindow*, void> glfwSetWindowRefreshCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowrefreshfun")] delegate* unmanaged<GLFWwindow*, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowfocusfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowFocusCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowfocusfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowiconifyfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowIconifyCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowiconifyfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowmaximizefun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, void> glfwSetWindowMaximizeCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowmaximizefun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWframebuffersizefun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, int, void> glfwSetFramebufferSizeCallback(GLFWwindow* window, [NativeTypeName("GLFWframebuffersizefun")] delegate* unmanaged<GLFWwindow*, int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWwindowcontentscalefun")]
    public static extern delegate* unmanaged<GLFWwindow*, float, float, void> glfwSetWindowContentScaleCallback(GLFWwindow* window, [NativeTypeName("GLFWwindowcontentscalefun")] delegate* unmanaged<GLFWwindow*, float, float, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwPollEvents();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWaitEvents();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwWaitEventsTimeout(double timeout);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwPostEmptyEvent();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetInputMode(GLFWwindow* window, int mode);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetInputMode(GLFWwindow* window, int mode, int value);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwRawMouseMotionSupported();
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetKeyName(int key, int scancode);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetKeyScancode(int key);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetKey(GLFWwindow* window, int key);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetMouseButton(GLFWwindow* window, int button);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwGetCursorPos(GLFWwindow* window, double* xpos, double* ypos);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetCursorPos(GLFWwindow* window, double xpos, double ypos);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWcursor* glfwCreateCursor([NativeTypeName("const GLFWimage *")] GLFWimage* image, int xhot, int yhot);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWcursor* glfwCreateStandardCursor(int shape);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwDestroyCursor(GLFWcursor* cursor);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetCursor(GLFWwindow* window, GLFWcursor* cursor);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWkeyfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, int, int, int, void> glfwSetKeyCallback(GLFWwindow* window, [NativeTypeName("GLFWkeyfun")] delegate* unmanaged<GLFWwindow*, int, int, int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWcharfun")]
    public static extern delegate* unmanaged<GLFWwindow*, uint, void> glfwSetCharCallback(GLFWwindow* window, [NativeTypeName("GLFWcharfun")] delegate* unmanaged<GLFWwindow*, uint, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWcharmodsfun")]
    public static extern delegate* unmanaged<GLFWwindow*, uint, int, void> glfwSetCharModsCallback(GLFWwindow* window, [NativeTypeName("GLFWcharmodsfun")] delegate* unmanaged<GLFWwindow*, uint, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWmousebuttonfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, int, int, void> glfwSetMouseButtonCallback(GLFWwindow* window, [NativeTypeName("GLFWmousebuttonfun")] delegate* unmanaged<GLFWwindow*, int, int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWcursorposfun")]
    public static extern delegate* unmanaged<GLFWwindow*, double, double, void> glfwSetCursorPosCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorposfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWcursorenterfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, void> glfwSetCursorEnterCallback(GLFWwindow* window, [NativeTypeName("GLFWcursorenterfun")] delegate* unmanaged<GLFWwindow*, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWscrollfun")]
    public static extern delegate* unmanaged<GLFWwindow*, double, double, void> glfwSetScrollCallback(GLFWwindow* window, [NativeTypeName("GLFWscrollfun")] delegate* unmanaged<GLFWwindow*, double, double, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWdropfun")]
    public static extern delegate* unmanaged<GLFWwindow*, int, sbyte**, void> glfwSetDropCallback(GLFWwindow* window, [NativeTypeName("GLFWdropfun")] delegate* unmanaged<GLFWwindow*, int, sbyte**, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwJoystickPresent(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const float *")]
    public static extern float* glfwGetJoystickAxes(int jid, int* count);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const unsigned char *")]
    public static extern byte* glfwGetJoystickButtons(int jid, int* count);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const unsigned char *")]
    public static extern byte* glfwGetJoystickHats(int jid, int* count);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetJoystickName(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetJoystickGUID(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetJoystickUserPointer(int jid, void* pointer);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void* glfwGetJoystickUserPointer(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwJoystickIsGamepad(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWjoystickfun")]
    public static extern delegate* unmanaged<int, int, void> glfwSetJoystickCallback([NativeTypeName("GLFWjoystickfun")] delegate* unmanaged<int, int, void> callback);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwUpdateGamepadMappings([NativeTypeName("const char *")] sbyte* @string);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetGamepadName(int jid);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwGetGamepadState(int jid, GLFWgamepadstate* state);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetClipboardString(GLFWwindow* window, [NativeTypeName("const char *")] sbyte* @string);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glfwGetClipboardString(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern double glfwGetTime();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSetTime(double time);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong glfwGetTimerValue();
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("uint64_t")]
    public static extern ulong glfwGetTimerFrequency();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwMakeContextCurrent(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern GLFWwindow* glfwGetCurrentContext();
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSwapBuffers(GLFWwindow* window);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern void glfwSwapInterval(int interval);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwExtensionSupported([NativeTypeName("const char *")] sbyte* extension);
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("GLFWglproc")]
    public static extern delegate* unmanaged<void> glfwGetProcAddress([NativeTypeName("const char *")] sbyte* procname);
    [DllImport("glfw", ExactSpelling = true)]
    public static extern int glfwVulkanSupported();
    [DllImport("glfw", ExactSpelling = true)]
    [return: NativeTypeName("const char **")]
    public static extern sbyte** glfwGetRequiredInstanceExtensions([NativeTypeName("uint32_t *")] uint* count);
    [NativeTypeName("#define GLFW_VERSION_MAJOR 3")]
    public const int GLFW_VERSION_MAJOR = 3;
    [NativeTypeName("#define GLFW_VERSION_MINOR 4")]
    public const int GLFW_VERSION_MINOR = 4;
    [NativeTypeName("#define GLFW_VERSION_REVISION 0")]
    public const int GLFW_VERSION_REVISION = 0;
    [NativeTypeName("#define GLFW_TRUE 1")]
    public const int GLFW_TRUE = 1;
    [NativeTypeName("#define GLFW_FALSE 0")]
    public const int GLFW_FALSE = 0;
    [NativeTypeName("#define GLFW_RELEASE 0")]
    public const int GLFW_RELEASE = 0;
    [NativeTypeName("#define GLFW_PRESS 1")]
    public const int GLFW_PRESS = 1;
    [NativeTypeName("#define GLFW_REPEAT 2")]
    public const int GLFW_REPEAT = 2;
    [NativeTypeName("#define GLFW_HAT_CENTERED 0")]
    public const int GLFW_HAT_CENTERED = 0;
    [NativeTypeName("#define GLFW_HAT_UP 1")]
    public const int GLFW_HAT_UP = 1;
    [NativeTypeName("#define GLFW_HAT_RIGHT 2")]
    public const int GLFW_HAT_RIGHT = 2;
    [NativeTypeName("#define GLFW_HAT_DOWN 4")]
    public const int GLFW_HAT_DOWN = 4;
    [NativeTypeName("#define GLFW_HAT_LEFT 8")]
    public const int GLFW_HAT_LEFT = 8;
    [NativeTypeName("#define GLFW_HAT_RIGHT_UP (GLFW_HAT_RIGHT | GLFW_HAT_UP)")]
    public const int GLFW_HAT_RIGHT_UP = (2 | 1);
    [NativeTypeName("#define GLFW_HAT_RIGHT_DOWN (GLFW_HAT_RIGHT | GLFW_HAT_DOWN)")]
    public const int GLFW_HAT_RIGHT_DOWN = (2 | 4);
    [NativeTypeName("#define GLFW_HAT_LEFT_UP (GLFW_HAT_LEFT  | GLFW_HAT_UP)")]
    public const int GLFW_HAT_LEFT_UP = (8 | 1);
    [NativeTypeName("#define GLFW_HAT_LEFT_DOWN (GLFW_HAT_LEFT  | GLFW_HAT_DOWN)")]
    public const int GLFW_HAT_LEFT_DOWN = (8 | 4);
    [NativeTypeName("#define GLFW_KEY_UNKNOWN -1")]
    public const int GLFW_KEY_UNKNOWN = -1;
    [NativeTypeName("#define GLFW_KEY_SPACE 32")]
    public const int GLFW_KEY_SPACE = 32;
    [NativeTypeName("#define GLFW_KEY_APOSTROPHE 39")]
    public const int GLFW_KEY_APOSTROPHE = 39;
    [NativeTypeName("#define GLFW_KEY_COMMA 44")]
    public const int GLFW_KEY_COMMA = 44;
    [NativeTypeName("#define GLFW_KEY_MINUS 45")]
    public const int GLFW_KEY_MINUS = 45;
    [NativeTypeName("#define GLFW_KEY_PERIOD 46")]
    public const int GLFW_KEY_PERIOD = 46;
    [NativeTypeName("#define GLFW_KEY_SLASH 47")]
    public const int GLFW_KEY_SLASH = 47;
    [NativeTypeName("#define GLFW_KEY_0 48")]
    public const int GLFW_KEY_0 = 48;
    [NativeTypeName("#define GLFW_KEY_1 49")]
    public const int GLFW_KEY_1 = 49;
    [NativeTypeName("#define GLFW_KEY_2 50")]
    public const int GLFW_KEY_2 = 50;
    [NativeTypeName("#define GLFW_KEY_3 51")]
    public const int GLFW_KEY_3 = 51;
    [NativeTypeName("#define GLFW_KEY_4 52")]
    public const int GLFW_KEY_4 = 52;
    [NativeTypeName("#define GLFW_KEY_5 53")]
    public const int GLFW_KEY_5 = 53;
    [NativeTypeName("#define GLFW_KEY_6 54")]
    public const int GLFW_KEY_6 = 54;
    [NativeTypeName("#define GLFW_KEY_7 55")]
    public const int GLFW_KEY_7 = 55;
    [NativeTypeName("#define GLFW_KEY_8 56")]
    public const int GLFW_KEY_8 = 56;
    [NativeTypeName("#define GLFW_KEY_9 57")]
    public const int GLFW_KEY_9 = 57;
    [NativeTypeName("#define GLFW_KEY_SEMICOLON 59")]
    public const int GLFW_KEY_SEMICOLON = 59;
    [NativeTypeName("#define GLFW_KEY_EQUAL 61")]
    public const int GLFW_KEY_EQUAL = 61;
    [NativeTypeName("#define GLFW_KEY_A 65")]
    public const int GLFW_KEY_A = 65;
    [NativeTypeName("#define GLFW_KEY_B 66")]
    public const int GLFW_KEY_B = 66;
    [NativeTypeName("#define GLFW_KEY_C 67")]
    public const int GLFW_KEY_C = 67;
    [NativeTypeName("#define GLFW_KEY_D 68")]
    public const int GLFW_KEY_D = 68;
    [NativeTypeName("#define GLFW_KEY_E 69")]
    public const int GLFW_KEY_E = 69;
    [NativeTypeName("#define GLFW_KEY_F 70")]
    public const int GLFW_KEY_F = 70;
    [NativeTypeName("#define GLFW_KEY_G 71")]
    public const int GLFW_KEY_G = 71;
    [NativeTypeName("#define GLFW_KEY_H 72")]
    public const int GLFW_KEY_H = 72;
    [NativeTypeName("#define GLFW_KEY_I 73")]
    public const int GLFW_KEY_I = 73;
    [NativeTypeName("#define GLFW_KEY_J 74")]
    public const int GLFW_KEY_J = 74;
    [NativeTypeName("#define GLFW_KEY_K 75")]
    public const int GLFW_KEY_K = 75;
    [NativeTypeName("#define GLFW_KEY_L 76")]
    public const int GLFW_KEY_L = 76;
    [NativeTypeName("#define GLFW_KEY_M 77")]
    public const int GLFW_KEY_M = 77;
    [NativeTypeName("#define GLFW_KEY_N 78")]
    public const int GLFW_KEY_N = 78;
    [NativeTypeName("#define GLFW_KEY_O 79")]
    public const int GLFW_KEY_O = 79;
    [NativeTypeName("#define GLFW_KEY_P 80")]
    public const int GLFW_KEY_P = 80;
    [NativeTypeName("#define GLFW_KEY_Q 81")]
    public const int GLFW_KEY_Q = 81;
    [NativeTypeName("#define GLFW_KEY_R 82")]
    public const int GLFW_KEY_R = 82;
    [NativeTypeName("#define GLFW_KEY_S 83")]
    public const int GLFW_KEY_S = 83;
    [NativeTypeName("#define GLFW_KEY_T 84")]
    public const int GLFW_KEY_T = 84;
    [NativeTypeName("#define GLFW_KEY_U 85")]
    public const int GLFW_KEY_U = 85;
    [NativeTypeName("#define GLFW_KEY_V 86")]
    public const int GLFW_KEY_V = 86;
    [NativeTypeName("#define GLFW_KEY_W 87")]
    public const int GLFW_KEY_W = 87;
    [NativeTypeName("#define GLFW_KEY_X 88")]
    public const int GLFW_KEY_X = 88;
    [NativeTypeName("#define GLFW_KEY_Y 89")]
    public const int GLFW_KEY_Y = 89;
    [NativeTypeName("#define GLFW_KEY_Z 90")]
    public const int GLFW_KEY_Z = 90;
    [NativeTypeName("#define GLFW_KEY_LEFT_BRACKET 91")]
    public const int GLFW_KEY_LEFT_BRACKET = 91;
    [NativeTypeName("#define GLFW_KEY_BACKSLASH 92")]
    public const int GLFW_KEY_BACKSLASH = 92;
    [NativeTypeName("#define GLFW_KEY_RIGHT_BRACKET 93")]
    public const int GLFW_KEY_RIGHT_BRACKET = 93;
    [NativeTypeName("#define GLFW_KEY_GRAVE_ACCENT 96")]
    public const int GLFW_KEY_GRAVE_ACCENT = 96;
    [NativeTypeName("#define GLFW_KEY_WORLD_1 161")]
    public const int GLFW_KEY_WORLD_1 = 161;
    [NativeTypeName("#define GLFW_KEY_WORLD_2 162")]
    public const int GLFW_KEY_WORLD_2 = 162;
    [NativeTypeName("#define GLFW_KEY_ESCAPE 256")]
    public const int GLFW_KEY_ESCAPE = 256;
    [NativeTypeName("#define GLFW_KEY_ENTER 257")]
    public const int GLFW_KEY_ENTER = 257;
    [NativeTypeName("#define GLFW_KEY_TAB 258")]
    public const int GLFW_KEY_TAB = 258;
    [NativeTypeName("#define GLFW_KEY_BACKSPACE 259")]
    public const int GLFW_KEY_BACKSPACE = 259;
    [NativeTypeName("#define GLFW_KEY_INSERT 260")]
    public const int GLFW_KEY_INSERT = 260;
    [NativeTypeName("#define GLFW_KEY_DELETE 261")]
    public const int GLFW_KEY_DELETE = 261;
    [NativeTypeName("#define GLFW_KEY_RIGHT 262")]
    public const int GLFW_KEY_RIGHT = 262;
    [NativeTypeName("#define GLFW_KEY_LEFT 263")]
    public const int GLFW_KEY_LEFT = 263;
    [NativeTypeName("#define GLFW_KEY_DOWN 264")]
    public const int GLFW_KEY_DOWN = 264;
    [NativeTypeName("#define GLFW_KEY_UP 265")]
    public const int GLFW_KEY_UP = 265;
    [NativeTypeName("#define GLFW_KEY_PAGE_UP 266")]
    public const int GLFW_KEY_PAGE_UP = 266;
    [NativeTypeName("#define GLFW_KEY_PAGE_DOWN 267")]
    public const int GLFW_KEY_PAGE_DOWN = 267;
    [NativeTypeName("#define GLFW_KEY_HOME 268")]
    public const int GLFW_KEY_HOME = 268;
    [NativeTypeName("#define GLFW_KEY_END 269")]
    public const int GLFW_KEY_END = 269;
    [NativeTypeName("#define GLFW_KEY_CAPS_LOCK 280")]
    public const int GLFW_KEY_CAPS_LOCK = 280;
    [NativeTypeName("#define GLFW_KEY_SCROLL_LOCK 281")]
    public const int GLFW_KEY_SCROLL_LOCK = 281;
    [NativeTypeName("#define GLFW_KEY_NUM_LOCK 282")]
    public const int GLFW_KEY_NUM_LOCK = 282;
    [NativeTypeName("#define GLFW_KEY_PRINT_SCREEN 283")]
    public const int GLFW_KEY_PRINT_SCREEN = 283;
    [NativeTypeName("#define GLFW_KEY_PAUSE 284")]
    public const int GLFW_KEY_PAUSE = 284;
    [NativeTypeName("#define GLFW_KEY_F1 290")]
    public const int GLFW_KEY_F1 = 290;
    [NativeTypeName("#define GLFW_KEY_F2 291")]
    public const int GLFW_KEY_F2 = 291;
    [NativeTypeName("#define GLFW_KEY_F3 292")]
    public const int GLFW_KEY_F3 = 292;
    [NativeTypeName("#define GLFW_KEY_F4 293")]
    public const int GLFW_KEY_F4 = 293;
    [NativeTypeName("#define GLFW_KEY_F5 294")]
    public const int GLFW_KEY_F5 = 294;
    [NativeTypeName("#define GLFW_KEY_F6 295")]
    public const int GLFW_KEY_F6 = 295;
    [NativeTypeName("#define GLFW_KEY_F7 296")]
    public const int GLFW_KEY_F7 = 296;
    [NativeTypeName("#define GLFW_KEY_F8 297")]
    public const int GLFW_KEY_F8 = 297;
    [NativeTypeName("#define GLFW_KEY_F9 298")]
    public const int GLFW_KEY_F9 = 298;
    [NativeTypeName("#define GLFW_KEY_F10 299")]
    public const int GLFW_KEY_F10 = 299;
    [NativeTypeName("#define GLFW_KEY_F11 300")]
    public const int GLFW_KEY_F11 = 300;
    [NativeTypeName("#define GLFW_KEY_F12 301")]
    public const int GLFW_KEY_F12 = 301;
    [NativeTypeName("#define GLFW_KEY_F13 302")]
    public const int GLFW_KEY_F13 = 302;
    [NativeTypeName("#define GLFW_KEY_F14 303")]
    public const int GLFW_KEY_F14 = 303;
    [NativeTypeName("#define GLFW_KEY_F15 304")]
    public const int GLFW_KEY_F15 = 304;
    [NativeTypeName("#define GLFW_KEY_F16 305")]
    public const int GLFW_KEY_F16 = 305;
    [NativeTypeName("#define GLFW_KEY_F17 306")]
    public const int GLFW_KEY_F17 = 306;
    [NativeTypeName("#define GLFW_KEY_F18 307")]
    public const int GLFW_KEY_F18 = 307;
    [NativeTypeName("#define GLFW_KEY_F19 308")]
    public const int GLFW_KEY_F19 = 308;
    [NativeTypeName("#define GLFW_KEY_F20 309")]
    public const int GLFW_KEY_F20 = 309;
    [NativeTypeName("#define GLFW_KEY_F21 310")]
    public const int GLFW_KEY_F21 = 310;
    [NativeTypeName("#define GLFW_KEY_F22 311")]
    public const int GLFW_KEY_F22 = 311;
    [NativeTypeName("#define GLFW_KEY_F23 312")]
    public const int GLFW_KEY_F23 = 312;
    [NativeTypeName("#define GLFW_KEY_F24 313")]
    public const int GLFW_KEY_F24 = 313;
    [NativeTypeName("#define GLFW_KEY_F25 314")]
    public const int GLFW_KEY_F25 = 314;
    [NativeTypeName("#define GLFW_KEY_KP_0 320")]
    public const int GLFW_KEY_KP_0 = 320;
    [NativeTypeName("#define GLFW_KEY_KP_1 321")]
    public const int GLFW_KEY_KP_1 = 321;
    [NativeTypeName("#define GLFW_KEY_KP_2 322")]
    public const int GLFW_KEY_KP_2 = 322;
    [NativeTypeName("#define GLFW_KEY_KP_3 323")]
    public const int GLFW_KEY_KP_3 = 323;
    [NativeTypeName("#define GLFW_KEY_KP_4 324")]
    public const int GLFW_KEY_KP_4 = 324;
    [NativeTypeName("#define GLFW_KEY_KP_5 325")]
    public const int GLFW_KEY_KP_5 = 325;
    [NativeTypeName("#define GLFW_KEY_KP_6 326")]
    public const int GLFW_KEY_KP_6 = 326;
    [NativeTypeName("#define GLFW_KEY_KP_7 327")]
    public const int GLFW_KEY_KP_7 = 327;
    [NativeTypeName("#define GLFW_KEY_KP_8 328")]
    public const int GLFW_KEY_KP_8 = 328;
    [NativeTypeName("#define GLFW_KEY_KP_9 329")]
    public const int GLFW_KEY_KP_9 = 329;
    [NativeTypeName("#define GLFW_KEY_KP_DECIMAL 330")]
    public const int GLFW_KEY_KP_DECIMAL = 330;
    [NativeTypeName("#define GLFW_KEY_KP_DIVIDE 331")]
    public const int GLFW_KEY_KP_DIVIDE = 331;
    [NativeTypeName("#define GLFW_KEY_KP_MULTIPLY 332")]
    public const int GLFW_KEY_KP_MULTIPLY = 332;
    [NativeTypeName("#define GLFW_KEY_KP_SUBTRACT 333")]
    public const int GLFW_KEY_KP_SUBTRACT = 333;
    [NativeTypeName("#define GLFW_KEY_KP_ADD 334")]
    public const int GLFW_KEY_KP_ADD = 334;
    [NativeTypeName("#define GLFW_KEY_KP_ENTER 335")]
    public const int GLFW_KEY_KP_ENTER = 335;
    [NativeTypeName("#define GLFW_KEY_KP_EQUAL 336")]
    public const int GLFW_KEY_KP_EQUAL = 336;
    [NativeTypeName("#define GLFW_KEY_LEFT_SHIFT 340")]
    public const int GLFW_KEY_LEFT_SHIFT = 340;
    [NativeTypeName("#define GLFW_KEY_LEFT_CONTROL 341")]
    public const int GLFW_KEY_LEFT_CONTROL = 341;
    [NativeTypeName("#define GLFW_KEY_LEFT_ALT 342")]
    public const int GLFW_KEY_LEFT_ALT = 342;
    [NativeTypeName("#define GLFW_KEY_LEFT_SUPER 343")]
    public const int GLFW_KEY_LEFT_SUPER = 343;
    [NativeTypeName("#define GLFW_KEY_RIGHT_SHIFT 344")]
    public const int GLFW_KEY_RIGHT_SHIFT = 344;
    [NativeTypeName("#define GLFW_KEY_RIGHT_CONTROL 345")]
    public const int GLFW_KEY_RIGHT_CONTROL = 345;
    [NativeTypeName("#define GLFW_KEY_RIGHT_ALT 346")]
    public const int GLFW_KEY_RIGHT_ALT = 346;
    [NativeTypeName("#define GLFW_KEY_RIGHT_SUPER 347")]
    public const int GLFW_KEY_RIGHT_SUPER = 347;
    [NativeTypeName("#define GLFW_KEY_MENU 348")]
    public const int GLFW_KEY_MENU = 348;
    [NativeTypeName("#define GLFW_KEY_LAST GLFW_KEY_MENU")]
    public const int GLFW_KEY_LAST = 348;
    [NativeTypeName("#define GLFW_MOD_SHIFT 0x0001")]
    public const int GLFW_MOD_SHIFT = 0x0001;
    [NativeTypeName("#define GLFW_MOD_CONTROL 0x0002")]
    public const int GLFW_MOD_CONTROL = 0x0002;
    [NativeTypeName("#define GLFW_MOD_ALT 0x0004")]
    public const int GLFW_MOD_ALT = 0x0004;
    [NativeTypeName("#define GLFW_MOD_SUPER 0x0008")]
    public const int GLFW_MOD_SUPER = 0x0008;
    [NativeTypeName("#define GLFW_MOD_CAPS_LOCK 0x0010")]
    public const int GLFW_MOD_CAPS_LOCK = 0x0010;
    [NativeTypeName("#define GLFW_MOD_NUM_LOCK 0x0020")]
    public const int GLFW_MOD_NUM_LOCK = 0x0020;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_1 0")]
    public const int GLFW_MOUSE_BUTTON_1 = 0;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_2 1")]
    public const int GLFW_MOUSE_BUTTON_2 = 1;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_3 2")]
    public const int GLFW_MOUSE_BUTTON_3 = 2;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_4 3")]
    public const int GLFW_MOUSE_BUTTON_4 = 3;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_5 4")]
    public const int GLFW_MOUSE_BUTTON_5 = 4;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_6 5")]
    public const int GLFW_MOUSE_BUTTON_6 = 5;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_7 6")]
    public const int GLFW_MOUSE_BUTTON_7 = 6;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_8 7")]
    public const int GLFW_MOUSE_BUTTON_8 = 7;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LAST GLFW_MOUSE_BUTTON_8")]
    public const int GLFW_MOUSE_BUTTON_LAST = 7;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_LEFT GLFW_MOUSE_BUTTON_1")]
    public const int GLFW_MOUSE_BUTTON_LEFT = 0;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_RIGHT GLFW_MOUSE_BUTTON_2")]
    public const int GLFW_MOUSE_BUTTON_RIGHT = 1;
    [NativeTypeName("#define GLFW_MOUSE_BUTTON_MIDDLE GLFW_MOUSE_BUTTON_3")]
    public const int GLFW_MOUSE_BUTTON_MIDDLE = 2;
    [NativeTypeName("#define GLFW_JOYSTICK_1 0")]
    public const int GLFW_JOYSTICK_1 = 0;
    [NativeTypeName("#define GLFW_JOYSTICK_2 1")]
    public const int GLFW_JOYSTICK_2 = 1;
    [NativeTypeName("#define GLFW_JOYSTICK_3 2")]
    public const int GLFW_JOYSTICK_3 = 2;
    [NativeTypeName("#define GLFW_JOYSTICK_4 3")]
    public const int GLFW_JOYSTICK_4 = 3;
    [NativeTypeName("#define GLFW_JOYSTICK_5 4")]
    public const int GLFW_JOYSTICK_5 = 4;
    [NativeTypeName("#define GLFW_JOYSTICK_6 5")]
    public const int GLFW_JOYSTICK_6 = 5;
    [NativeTypeName("#define GLFW_JOYSTICK_7 6")]
    public const int GLFW_JOYSTICK_7 = 6;
    [NativeTypeName("#define GLFW_JOYSTICK_8 7")]
    public const int GLFW_JOYSTICK_8 = 7;
    [NativeTypeName("#define GLFW_JOYSTICK_9 8")]
    public const int GLFW_JOYSTICK_9 = 8;
    [NativeTypeName("#define GLFW_JOYSTICK_10 9")]
    public const int GLFW_JOYSTICK_10 = 9;
    [NativeTypeName("#define GLFW_JOYSTICK_11 10")]
    public const int GLFW_JOYSTICK_11 = 10;
    [NativeTypeName("#define GLFW_JOYSTICK_12 11")]
    public const int GLFW_JOYSTICK_12 = 11;
    [NativeTypeName("#define GLFW_JOYSTICK_13 12")]
    public const int GLFW_JOYSTICK_13 = 12;
    [NativeTypeName("#define GLFW_JOYSTICK_14 13")]
    public const int GLFW_JOYSTICK_14 = 13;
    [NativeTypeName("#define GLFW_JOYSTICK_15 14")]
    public const int GLFW_JOYSTICK_15 = 14;
    [NativeTypeName("#define GLFW_JOYSTICK_16 15")]
    public const int GLFW_JOYSTICK_16 = 15;
    [NativeTypeName("#define GLFW_JOYSTICK_LAST GLFW_JOYSTICK_16")]
    public const int GLFW_JOYSTICK_LAST = 15;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_A 0")]
    public const int GLFW_GAMEPAD_BUTTON_A = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_B 1")]
    public const int GLFW_GAMEPAD_BUTTON_B = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_X 2")]
    public const int GLFW_GAMEPAD_BUTTON_X = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_Y 3")]
    public const int GLFW_GAMEPAD_BUTTON_Y = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_BUMPER 4")]
    public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER 5")]
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_BACK 6")]
    public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_START 7")]
    public const int GLFW_GAMEPAD_BUTTON_START = 7;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_GUIDE 8")]
    public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LEFT_THUMB 9")]
    public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_RIGHT_THUMB 10")]
    public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_UP 11")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_RIGHT 12")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_DOWN 13")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_DPAD_LEFT 14")]
    public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_LAST GLFW_GAMEPAD_BUTTON_DPAD_LEFT")]
    public const int GLFW_GAMEPAD_BUTTON_LAST = 14;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CROSS GLFW_GAMEPAD_BUTTON_A")]
    public const int GLFW_GAMEPAD_BUTTON_CROSS = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_CIRCLE GLFW_GAMEPAD_BUTTON_B")]
    public const int GLFW_GAMEPAD_BUTTON_CIRCLE = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_SQUARE GLFW_GAMEPAD_BUTTON_X")]
    public const int GLFW_GAMEPAD_BUTTON_SQUARE = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_BUTTON_TRIANGLE GLFW_GAMEPAD_BUTTON_Y")]
    public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_X 0")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_Y 1")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_X 2")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_Y 3")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LEFT_TRIGGER 4")]
    public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER 5")]
    public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
    [NativeTypeName("#define GLFW_GAMEPAD_AXIS_LAST GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER")]
    public const int GLFW_GAMEPAD_AXIS_LAST = 5;
    [NativeTypeName("#define GLFW_NO_ERROR 0")]
    public const int GLFW_NO_ERROR = 0;
    [NativeTypeName("#define GLFW_NOT_INITIALIZED 0x00010001")]
    public const int GLFW_NOT_INITIALIZED = 0x00010001;
    [NativeTypeName("#define GLFW_NO_CURRENT_CONTEXT 0x00010002")]
    public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
    [NativeTypeName("#define GLFW_INVALID_ENUM 0x00010003")]
    public const int GLFW_INVALID_ENUM = 0x00010003;
    [NativeTypeName("#define GLFW_INVALID_VALUE 0x00010004")]
    public const int GLFW_INVALID_VALUE = 0x00010004;
    [NativeTypeName("#define GLFW_OUT_OF_MEMORY 0x00010005")]
    public const int GLFW_OUT_OF_MEMORY = 0x00010005;
    [NativeTypeName("#define GLFW_API_UNAVAILABLE 0x00010006")]
    public const int GLFW_API_UNAVAILABLE = 0x00010006;
    [NativeTypeName("#define GLFW_VERSION_UNAVAILABLE 0x00010007")]
    public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
    [NativeTypeName("#define GLFW_PLATFORM_ERROR 0x00010008")]
    public const int GLFW_PLATFORM_ERROR = 0x00010008;
    [NativeTypeName("#define GLFW_FORMAT_UNAVAILABLE 0x00010009")]
    public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
    [NativeTypeName("#define GLFW_NO_WINDOW_CONTEXT 0x0001000A")]
    public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
    [NativeTypeName("#define GLFW_CURSOR_UNAVAILABLE 0x0001000B")]
    public const int GLFW_CURSOR_UNAVAILABLE = 0x0001000B;
    [NativeTypeName("#define GLFW_FEATURE_UNAVAILABLE 0x0001000C")]
    public const int GLFW_FEATURE_UNAVAILABLE = 0x0001000C;
    [NativeTypeName("#define GLFW_FEATURE_UNIMPLEMENTED 0x0001000D")]
    public const int GLFW_FEATURE_UNIMPLEMENTED = 0x0001000D;
    [NativeTypeName("#define GLFW_PLATFORM_UNAVAILABLE 0x0001000E")]
    public const int GLFW_PLATFORM_UNAVAILABLE = 0x0001000E;
    [NativeTypeName("#define GLFW_FOCUSED 0x00020001")]
    public const int GLFW_FOCUSED = 0x00020001;
    [NativeTypeName("#define GLFW_ICONIFIED 0x00020002")]
    public const int GLFW_ICONIFIED = 0x00020002;
    [NativeTypeName("#define GLFW_RESIZABLE 0x00020003")]
    public const int GLFW_RESIZABLE = 0x00020003;
    [NativeTypeName("#define GLFW_VISIBLE 0x00020004")]
    public const int GLFW_VISIBLE = 0x00020004;
    [NativeTypeName("#define GLFW_DECORATED 0x00020005")]
    public const int GLFW_DECORATED = 0x00020005;
    [NativeTypeName("#define GLFW_AUTO_ICONIFY 0x00020006")]
    public const int GLFW_AUTO_ICONIFY = 0x00020006;
    [NativeTypeName("#define GLFW_FLOATING 0x00020007")]
    public const int GLFW_FLOATING = 0x00020007;
    [NativeTypeName("#define GLFW_MAXIMIZED 0x00020008")]
    public const int GLFW_MAXIMIZED = 0x00020008;
    [NativeTypeName("#define GLFW_CENTER_CURSOR 0x00020009")]
    public const int GLFW_CENTER_CURSOR = 0x00020009;
    [NativeTypeName("#define GLFW_TRANSPARENT_FRAMEBUFFER 0x0002000A")]
    public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
    [NativeTypeName("#define GLFW_HOVERED 0x0002000B")]
    public const int GLFW_HOVERED = 0x0002000B;
    [NativeTypeName("#define GLFW_FOCUS_ON_SHOW 0x0002000C")]
    public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;
    [NativeTypeName("#define GLFW_MOUSE_PASSTHROUGH 0x0002000D")]
    public const int GLFW_MOUSE_PASSTHROUGH = 0x0002000D;
    [NativeTypeName("#define GLFW_POSITION_X 0x0002000E")]
    public const int GLFW_POSITION_X = 0x0002000E;
    [NativeTypeName("#define GLFW_POSITION_Y 0x0002000F")]
    public const int GLFW_POSITION_Y = 0x0002000F;
    [NativeTypeName("#define GLFW_RED_BITS 0x00021001")]
    public const int GLFW_RED_BITS = 0x00021001;
    [NativeTypeName("#define GLFW_GREEN_BITS 0x00021002")]
    public const int GLFW_GREEN_BITS = 0x00021002;
    [NativeTypeName("#define GLFW_BLUE_BITS 0x00021003")]
    public const int GLFW_BLUE_BITS = 0x00021003;
    [NativeTypeName("#define GLFW_ALPHA_BITS 0x00021004")]
    public const int GLFW_ALPHA_BITS = 0x00021004;
    [NativeTypeName("#define GLFW_DEPTH_BITS 0x00021005")]
    public const int GLFW_DEPTH_BITS = 0x00021005;
    [NativeTypeName("#define GLFW_STENCIL_BITS 0x00021006")]
    public const int GLFW_STENCIL_BITS = 0x00021006;
    [NativeTypeName("#define GLFW_ACCUM_RED_BITS 0x00021007")]
    public const int GLFW_ACCUM_RED_BITS = 0x00021007;
    [NativeTypeName("#define GLFW_ACCUM_GREEN_BITS 0x00021008")]
    public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
    [NativeTypeName("#define GLFW_ACCUM_BLUE_BITS 0x00021009")]
    public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
    [NativeTypeName("#define GLFW_ACCUM_ALPHA_BITS 0x0002100A")]
    public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
    [NativeTypeName("#define GLFW_AUX_BUFFERS 0x0002100B")]
    public const int GLFW_AUX_BUFFERS = 0x0002100B;
    [NativeTypeName("#define GLFW_STEREO 0x0002100C")]
    public const int GLFW_STEREO = 0x0002100C;
    [NativeTypeName("#define GLFW_SAMPLES 0x0002100D")]
    public const int GLFW_SAMPLES = 0x0002100D;
    [NativeTypeName("#define GLFW_SRGB_CAPABLE 0x0002100E")]
    public const int GLFW_SRGB_CAPABLE = 0x0002100E;
    [NativeTypeName("#define GLFW_REFRESH_RATE 0x0002100F")]
    public const int GLFW_REFRESH_RATE = 0x0002100F;
    [NativeTypeName("#define GLFW_DOUBLEBUFFER 0x00021010")]
    public const int GLFW_DOUBLEBUFFER = 0x00021010;
    [NativeTypeName("#define GLFW_CLIENT_API 0x00022001")]
    public const int GLFW_CLIENT_API = 0x00022001;
    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MAJOR 0x00022002")]
    public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
    [NativeTypeName("#define GLFW_CONTEXT_VERSION_MINOR 0x00022003")]
    public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
    [NativeTypeName("#define GLFW_CONTEXT_REVISION 0x00022004")]
    public const int GLFW_CONTEXT_REVISION = 0x00022004;
    [NativeTypeName("#define GLFW_CONTEXT_ROBUSTNESS 0x00022005")]
    public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
    [NativeTypeName("#define GLFW_OPENGL_FORWARD_COMPAT 0x00022006")]
    public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
    [NativeTypeName("#define GLFW_CONTEXT_DEBUG 0x00022007")]
    public const int GLFW_CONTEXT_DEBUG = 0x00022007;
    [NativeTypeName("#define GLFW_OPENGL_DEBUG_CONTEXT GLFW_CONTEXT_DEBUG")]
    public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
    [NativeTypeName("#define GLFW_OPENGL_PROFILE 0x00022008")]
    public const int GLFW_OPENGL_PROFILE = 0x00022008;
    [NativeTypeName("#define GLFW_CONTEXT_RELEASE_BEHAVIOR 0x00022009")]
    public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
    [NativeTypeName("#define GLFW_CONTEXT_NO_ERROR 0x0002200A")]
    public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
    [NativeTypeName("#define GLFW_CONTEXT_CREATION_API 0x0002200B")]
    public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
    [NativeTypeName("#define GLFW_SCALE_TO_MONITOR 0x0002200C")]
    public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
    [NativeTypeName("#define GLFW_COCOA_RETINA_FRAMEBUFFER 0x00023001")]
    public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
    [NativeTypeName("#define GLFW_COCOA_FRAME_NAME 0x00023002")]
    public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
    [NativeTypeName("#define GLFW_COCOA_GRAPHICS_SWITCHING 0x00023003")]
    public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
    [NativeTypeName("#define GLFW_X11_CLASS_NAME 0x00024001")]
    public const int GLFW_X11_CLASS_NAME = 0x00024001;
    [NativeTypeName("#define GLFW_X11_INSTANCE_NAME 0x00024002")]
    public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
    [NativeTypeName("#define GLFW_WIN32_KEYBOARD_MENU 0x00025001")]
    public const int GLFW_WIN32_KEYBOARD_MENU = 0x00025001;
    [NativeTypeName("#define GLFW_WAYLAND_APP_ID 0x00026001")]
    public const int GLFW_WAYLAND_APP_ID = 0x00026001;
    [NativeTypeName("#define GLFW_NO_API 0")]
    public const int GLFW_NO_API = 0;
    [NativeTypeName("#define GLFW_OPENGL_API 0x00030001")]
    public const int GLFW_OPENGL_API = 0x00030001;
    [NativeTypeName("#define GLFW_OPENGL_ES_API 0x00030002")]
    public const int GLFW_OPENGL_ES_API = 0x00030002;
    [NativeTypeName("#define GLFW_NO_ROBUSTNESS 0")]
    public const int GLFW_NO_ROBUSTNESS = 0;
    [NativeTypeName("#define GLFW_NO_RESET_NOTIFICATION 0x00031001")]
    public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
    [NativeTypeName("#define GLFW_LOSE_CONTEXT_ON_RESET 0x00031002")]
    public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;
    [NativeTypeName("#define GLFW_OPENGL_ANY_PROFILE 0")]
    public const int GLFW_OPENGL_ANY_PROFILE = 0;
    [NativeTypeName("#define GLFW_OPENGL_CORE_PROFILE 0x00032001")]
    public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
    [NativeTypeName("#define GLFW_OPENGL_COMPAT_PROFILE 0x00032002")]
    public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
    [NativeTypeName("#define GLFW_CURSOR 0x00033001")]
    public const int GLFW_CURSOR = 0x00033001;
    [NativeTypeName("#define GLFW_STICKY_KEYS 0x00033002")]
    public const int GLFW_STICKY_KEYS = 0x00033002;
    [NativeTypeName("#define GLFW_STICKY_MOUSE_BUTTONS 0x00033003")]
    public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
    [NativeTypeName("#define GLFW_LOCK_KEY_MODS 0x00033004")]
    public const int GLFW_LOCK_KEY_MODS = 0x00033004;
    [NativeTypeName("#define GLFW_RAW_MOUSE_MOTION 0x00033005")]
    public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;
    [NativeTypeName("#define GLFW_CURSOR_NORMAL 0x00034001")]
    public const int GLFW_CURSOR_NORMAL = 0x00034001;
    [NativeTypeName("#define GLFW_CURSOR_HIDDEN 0x00034002")]
    public const int GLFW_CURSOR_HIDDEN = 0x00034002;
    [NativeTypeName("#define GLFW_CURSOR_DISABLED 0x00034003")]
    public const int GLFW_CURSOR_DISABLED = 0x00034003;
    [NativeTypeName("#define GLFW_CURSOR_CAPTURED 0x00034004")]
    public const int GLFW_CURSOR_CAPTURED = 0x00034004;
    [NativeTypeName("#define GLFW_ANY_RELEASE_BEHAVIOR 0")]
    public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_FLUSH 0x00035001")]
    public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
    [NativeTypeName("#define GLFW_RELEASE_BEHAVIOR_NONE 0x00035002")]
    public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
    [NativeTypeName("#define GLFW_NATIVE_CONTEXT_API 0x00036001")]
    public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
    [NativeTypeName("#define GLFW_EGL_CONTEXT_API 0x00036002")]
    public const int GLFW_EGL_CONTEXT_API = 0x00036002;
    [NativeTypeName("#define GLFW_OSMESA_CONTEXT_API 0x00036003")]
    public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_NONE 0x00037001")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_NONE = 0x00037001;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGL 0x00037002")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGL = 0x00037002;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_OPENGLES 0x00037003")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_OPENGLES = 0x00037003;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D9 0x00037004")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D9 = 0x00037004;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_D3D11 0x00037005")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_D3D11 = 0x00037005;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_VULKAN 0x00037007")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_VULKAN = 0x00037007;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE_METAL 0x00037008")]
    public const int GLFW_ANGLE_PLATFORM_TYPE_METAL = 0x00037008;
    [NativeTypeName("#define GLFW_WAYLAND_PREFER_LIBDECOR 0x00038001")]
    public const int GLFW_WAYLAND_PREFER_LIBDECOR = 0x00038001;
    [NativeTypeName("#define GLFW_WAYLAND_DISABLE_LIBDECOR 0x00038002")]
    public const int GLFW_WAYLAND_DISABLE_LIBDECOR = 0x00038002;
    [NativeTypeName("#define GLFW_ANY_POSITION 0x80000000")]
    public const uint GLFW_ANY_POSITION = 0x80000000;
    [NativeTypeName("#define GLFW_ARROW_CURSOR 0x00036001")]
    public const int GLFW_ARROW_CURSOR = 0x00036001;
    [NativeTypeName("#define GLFW_IBEAM_CURSOR 0x00036002")]
    public const int GLFW_IBEAM_CURSOR = 0x00036002;
    [NativeTypeName("#define GLFW_CROSSHAIR_CURSOR 0x00036003")]
    public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
    [NativeTypeName("#define GLFW_POINTING_HAND_CURSOR 0x00036004")]
    public const int GLFW_POINTING_HAND_CURSOR = 0x00036004;
    [NativeTypeName("#define GLFW_RESIZE_EW_CURSOR 0x00036005")]
    public const int GLFW_RESIZE_EW_CURSOR = 0x00036005;
    [NativeTypeName("#define GLFW_RESIZE_NS_CURSOR 0x00036006")]
    public const int GLFW_RESIZE_NS_CURSOR = 0x00036006;
    [NativeTypeName("#define GLFW_RESIZE_NWSE_CURSOR 0x00036007")]
    public const int GLFW_RESIZE_NWSE_CURSOR = 0x00036007;
    [NativeTypeName("#define GLFW_RESIZE_NESW_CURSOR 0x00036008")]
    public const int GLFW_RESIZE_NESW_CURSOR = 0x00036008;
    [NativeTypeName("#define GLFW_RESIZE_ALL_CURSOR 0x00036009")]
    public const int GLFW_RESIZE_ALL_CURSOR = 0x00036009;
    [NativeTypeName("#define GLFW_NOT_ALLOWED_CURSOR 0x0003600A")]
    public const int GLFW_NOT_ALLOWED_CURSOR = 0x0003600A;
    [NativeTypeName("#define GLFW_HRESIZE_CURSOR GLFW_RESIZE_EW_CURSOR")]
    public const int GLFW_HRESIZE_CURSOR = 0x00036005;
    [NativeTypeName("#define GLFW_VRESIZE_CURSOR GLFW_RESIZE_NS_CURSOR")]
    public const int GLFW_VRESIZE_CURSOR = 0x00036006;
    [NativeTypeName("#define GLFW_HAND_CURSOR GLFW_POINTING_HAND_CURSOR")]
    public const int GLFW_HAND_CURSOR = 0x00036004;
    [NativeTypeName("#define GLFW_CONNECTED 0x00040001")]
    public const int GLFW_CONNECTED = 0x00040001;
    [NativeTypeName("#define GLFW_DISCONNECTED 0x00040002")]
    public const int GLFW_DISCONNECTED = 0x00040002;
    [NativeTypeName("#define GLFW_JOYSTICK_HAT_BUTTONS 0x00050001")]
    public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;
    [NativeTypeName("#define GLFW_ANGLE_PLATFORM_TYPE 0x00050002")]
    public const int GLFW_ANGLE_PLATFORM_TYPE = 0x00050002;
    [NativeTypeName("#define GLFW_PLATFORM 0x00050003")]
    public const int GLFW_PLATFORM = 0x00050003;
    [NativeTypeName("#define GLFW_COCOA_CHDIR_RESOURCES 0x00051001")]
    public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;
    [NativeTypeName("#define GLFW_COCOA_MENUBAR 0x00051002")]
    public const int GLFW_COCOA_MENUBAR = 0x00051002;
    [NativeTypeName("#define GLFW_X11_XCB_VULKAN_SURFACE 0x00052001")]
    public const int GLFW_X11_XCB_VULKAN_SURFACE = 0x00052001;
    [NativeTypeName("#define GLFW_WAYLAND_LIBDECOR 0x00053001")]
    public const int GLFW_WAYLAND_LIBDECOR = 0x00053001;
    [NativeTypeName("#define GLFW_ANY_PLATFORM 0x00060000")]
    public const int GLFW_ANY_PLATFORM = 0x00060000;
    [NativeTypeName("#define GLFW_PLATFORM_WIN32 0x00060001")]
    public const int GLFW_PLATFORM_WIN32 = 0x00060001;
    [NativeTypeName("#define GLFW_PLATFORM_COCOA 0x00060002")]
    public const int GLFW_PLATFORM_COCOA = 0x00060002;
    [NativeTypeName("#define GLFW_PLATFORM_WAYLAND 0x00060003")]
    public const int GLFW_PLATFORM_WAYLAND = 0x00060003;
    [NativeTypeName("#define GLFW_PLATFORM_X11 0x00060004")]
    public const int GLFW_PLATFORM_X11 = 0x00060004;
    [NativeTypeName("#define GLFW_PLATFORM_NULL 0x00060005")]
    public const int GLFW_PLATFORM_NULL = 0x00060005;
    [NativeTypeName("#define GLFW_DONT_CARE -1")]
    public const int GLFW_DONT_CARE = -1;
}