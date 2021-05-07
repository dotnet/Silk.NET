extern "C" __declspec(dllexport) void __cdecl Test1()
{

}

extern "C" __declspec(dllexport) int __cdecl Test2()
{
    return 5;
}

extern "C" __declspec(dllexport) int __cdecl Test3(char* bytes)
{
    return *bytes;
}

extern "C" __declspec(dllexport) int __cdecl Test5(char* bytes)
{
    return *bytes;
}

extern "C" __declspec(dllexport) int __cdecl Test6(short b)
{
    return b;
}

extern "C" __declspec(dllexport) int __cdecl Test7(int b)
{
    return b;
}