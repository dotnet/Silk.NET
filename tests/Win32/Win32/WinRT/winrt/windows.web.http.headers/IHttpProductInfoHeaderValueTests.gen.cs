// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IHttpProductInfoHeaderValue"/> struct.</summary>
public static unsafe partial class IHttpProductInfoHeaderValueTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHttpProductInfoHeaderValue"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IHttpProductInfoHeaderValue).GUID,
            Is.EqualTo(IID_IHttpProductInfoHeaderValue)
        );
    }

    /// <summary>Validates that the <see cref = "IHttpProductInfoHeaderValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IHttpProductInfoHeaderValue>(),
            Is.EqualTo(sizeof(IHttpProductInfoHeaderValue))
        );
    }

    /// <summary>Validates that the <see cref = "IHttpProductInfoHeaderValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHttpProductInfoHeaderValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHttpProductInfoHeaderValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHttpProductInfoHeaderValue), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHttpProductInfoHeaderValue), Is.EqualTo(4));
        }
    }
}
