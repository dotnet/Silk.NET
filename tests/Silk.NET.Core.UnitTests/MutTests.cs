using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Pointers;

namespace Silk.NET.Core.UnitTests;

public class MutTests
{
    [Test]
    public void SingleStringUtf8FromByteArray()
    {
        Mut<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromSpan()
    {
        Mut<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0").AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf8FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Mut<byte> thing = ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf16FromByteArray()
    {
        Mut<char> thing = STR_1.ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromSpan()
    {
        Mut<char> thing = STR_1.AsSpan().ToArray().AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf16FromRawPointer()
    {
        fixed (byte* ptr = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Mut<char> thing = (char*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf32FromByteArray()
    {
        Mut<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromSpan()
    {
        Mut<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf32FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Mut<uint> thing = (uint*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void NullIsNull()
    {
        Mut<nint> ptr = nullptr;
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Ref)));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.GetPinnableReference())));
        Assert.True((nint*) ptr is null);
        Assert.True((void*) ptr is null);
    }
}
