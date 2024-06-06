namespace Silk.NET.SDL;

public unsafe delegate int StorageInterfaceEnumerateDelegate(
    void* arg0,
    sbyte* arg1,
    EnumerateDirectoryCallback arg2,
    void* arg3
);
