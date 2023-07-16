// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CMINVOKECOMMANDINFOEX"/> struct.</summary>
public static unsafe partial class CMINVOKECOMMANDINFOEXTests
{
    /// <summary>Validates that the <see cref = "CMINVOKECOMMANDINFOEX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CMINVOKECOMMANDINFOEX>(), Is.EqualTo(sizeof(CMINVOKECOMMANDINFOEX)));
    }

    /// <summary>Validates that the <see cref = "CMINVOKECOMMANDINFOEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CMINVOKECOMMANDINFOEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CMINVOKECOMMANDINFOEX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CMINVOKECOMMANDINFOEX), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(CMINVOKECOMMANDINFOEX), Is.EqualTo(64));
        }
    }
}