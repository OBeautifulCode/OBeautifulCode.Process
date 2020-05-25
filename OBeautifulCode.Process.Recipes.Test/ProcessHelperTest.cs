// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProcessHelperTest.cs" company="OBeautifulCode">
//   Copyright (c) OBeautifulCode 2018. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace OBeautifulCode.Process.Recipes.Test
{
    using System;

    using FluentAssertions;

    using OBeautifulCode.Process.Recipes;
    using Xunit;

    public static class ProcessHelperTest
    {
        [Fact]
        public static void GetRunningProcess___Should_not_return_null___When_called()
        {
            // arrange

            // act
            var actual = ProcessHelper.GetRunningProcess();

            // assert
            actual.Should().NotBeNull();
        }

        [Fact]
        public static void Name___Should_throw_ArgumentNullException___When_parameter_process_is_null()
        {
            // arrange

            // act
            var actual = Record.Exception(() => ProcessHelper.GetName(null));

            // assert
            actual.Should().BeOfType<ArgumentNullException>();
            actual.Message.Should().Contain("process");
        }

        [Fact]
        public static void Name___Should_not_return_null_or_white_space___When_called()
        {
            // arrange

            // act
            var actual = ProcessHelper.GetRunningProcess().GetName();

            // assert
            actual.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public static void FilePath___Should_throw_ArgumentNullException___When_parameter_process_is_null()
        {
            // arrange

            // act
            var actual = Record.Exception(() => ProcessHelper.GetFilePath(null));

            // assert
            actual.Should().BeOfType<ArgumentNullException>();
            actual.Message.Should().Contain("process");
        }

        [Fact]
        public static void FilePath___Should_not_return_null_or_white_space___When_called()
        {
            // arrange

            // act
            var actual = ProcessHelper.GetRunningProcess().GetFilePath();

            // assert
            actual.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public static void FileVersion___Should_throw_ArgumentNullException___When_parameter_process_is_null()
        {
            // arrange

            // act
            var actual = Record.Exception(() => ProcessHelper.GetFileVersion(null));

            // assert
            actual.Should().BeOfType<ArgumentNullException>();
            actual.Message.Should().Contain("process");
        }

        [Fact]
        public static void FileVersion___Should_not_return_null_or_white_space___When_called()
        {
            // arrange

            // act
            var actual = ProcessHelper.GetRunningProcess().GetFileVersion();

            // assert
            actual.Should().NotBeNullOrWhiteSpace();
        }

        [Fact]
        public static void ProductVersion___Should_throw_ArgumentNullException___When_parameter_process_is_null()
        {
            // arrange

            // act
            var actual = Record.Exception(() => ProcessHelper.GetProductVersion(null));

            // assert
            actual.Should().BeOfType<ArgumentNullException>();
            actual.Message.Should().Contain("process");
        }

        [Fact]
        public static void ProductVersion___Should_not_return_null_or_white_space___When_called()
        {
            // arrange

            // act
            var actual = ProcessHelper.GetRunningProcess().GetProductVersion();

            // assert
            actual.Should().NotBeNullOrWhiteSpace();
        }
    }
}
