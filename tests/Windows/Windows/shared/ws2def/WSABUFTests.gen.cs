// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WSABUF"/> struct.</summary>
public static unsafe partial class WSABUFTests
{
    /// <summary>Validates that the <see cref = "WSABUF"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WSABUF>(), Is.EqualTo(sizeof(WSABUF)));
    }

    /// <summary>Validates that the <see cref = "WSABUF"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WSABUF).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WSABUF"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WSABUF), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WSABUF), Is.EqualTo(8));
        }
    }
}