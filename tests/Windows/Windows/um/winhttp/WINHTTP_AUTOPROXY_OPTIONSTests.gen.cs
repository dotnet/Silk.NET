// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WINHTTP_AUTOPROXY_OPTIONS"/> struct.</summary>
public static unsafe partial class WINHTTP_AUTOPROXY_OPTIONSTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_AUTOPROXY_OPTIONS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_AUTOPROXY_OPTIONS>(), Is.EqualTo(sizeof(WINHTTP_AUTOPROXY_OPTIONS)));
    }

    /// <summary>Validates that the <see cref = "WINHTTP_AUTOPROXY_OPTIONS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_AUTOPROXY_OPTIONS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_AUTOPROXY_OPTIONS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINHTTP_AUTOPROXY_OPTIONS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WINHTTP_AUTOPROXY_OPTIONS), Is.EqualTo(24));
        }
    }
}