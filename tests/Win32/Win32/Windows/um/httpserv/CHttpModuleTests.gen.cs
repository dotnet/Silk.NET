// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "CHttpModule"/> struct.</summary>
public static unsafe partial class CHttpModuleTests
{
    /// <summary>Validates that the <see cref = "CHttpModule"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CHttpModule>(), Is.EqualTo(sizeof(CHttpModule)));
    }

    /// <summary>Validates that the <see cref = "CHttpModule"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CHttpModule).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CHttpModule"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CHttpModule), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(CHttpModule), Is.EqualTo(4));
        }
    }
}
