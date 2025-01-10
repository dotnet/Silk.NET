// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.headers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct.</summary>
public static unsafe partial class IHttpMediaTypeWithQualityHeaderValueTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IHttpMediaTypeWithQualityHeaderValue).GUID,
            Is.EqualTo(IID_IHttpMediaTypeWithQualityHeaderValue)
        );
    }

    /// <summary>Validates that the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IHttpMediaTypeWithQualityHeaderValue>(),
            Is.EqualTo(sizeof(IHttpMediaTypeWithQualityHeaderValue))
        );
    }

    /// <summary>Validates that the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHttpMediaTypeWithQualityHeaderValue).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IHttpMediaTypeWithQualityHeaderValue"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHttpMediaTypeWithQualityHeaderValue), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHttpMediaTypeWithQualityHeaderValue), Is.EqualTo(4));
        }
    }
}
