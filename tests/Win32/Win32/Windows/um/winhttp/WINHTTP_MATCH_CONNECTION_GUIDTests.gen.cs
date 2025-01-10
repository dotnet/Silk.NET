// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "WINHTTP_MATCH_CONNECTION_GUID"/> struct.</summary>
public static unsafe partial class WINHTTP_MATCH_CONNECTION_GUIDTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_MATCH_CONNECTION_GUID"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<WINHTTP_MATCH_CONNECTION_GUID>(),
            Is.EqualTo(sizeof(WINHTTP_MATCH_CONNECTION_GUID))
        );
    }

    /// <summary>Validates that the <see cref = "WINHTTP_MATCH_CONNECTION_GUID"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_MATCH_CONNECTION_GUID).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_MATCH_CONNECTION_GUID"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_MATCH_CONNECTION_GUID), Is.EqualTo(24));
    }
}
