﻿// --------------------------------------------------------------------------------------------
// <copyright file="ResultSetExtensions.cs" company="Effort Team">
//     Copyright (C) 2011-2013 Effort Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------

namespace Effort.Test.Internal.Queries
{
    using System;
#if !EFOLD
    using System.Data.Entity.Core.Objects;
#else
    using System.Data.Objects;
#endif
   
    internal static class QueryTesterExtensions
    {
        public static string CreateExpectedJsonCSharpResult<TResult, TObjectContext>(
            this IQueryTester<TObjectContext> tester,
            Func<TObjectContext, TResult> queryFactory)
            where TObjectContext : ObjectContext
        {
            return tester
                .CreateExpectedResult<TResult>(queryFactory)
                .ConvertToJsonSerializedCSharpString();
        }

        public static string CreateExpectedJsonCSharpResult<TResult, TObjectContext>(
            this IQueryTester<TObjectContext> tester,
            Func<TObjectContext, TResult> queryFactory,
            string dummy)
            where TObjectContext : ObjectContext
        {
            return tester
                .CreateExpectedResult<TResult>(queryFactory)
                .ConvertToJsonSerializedCSharpString();
        }

        public static string CreateExpectedJsonCSharpResult<TResult, TObjectContext>(
            this IQueryTester<TObjectContext> tester,
            Func<TObjectContext, TResult> queryFactory,
            string dummy1,
            bool dummy2)
            where TObjectContext : ObjectContext
        {
            return tester
                .CreateExpectedResult<TResult>(queryFactory)
                .ConvertToJsonSerializedCSharpString();
        }
    }
}
