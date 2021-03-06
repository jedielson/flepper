﻿using System;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class ValuesExtensions
    {
        public static object InsertQuotationMarksIfDateOrString(this object value)
        {
            if (value is string || value is DateTime) return $"'{value}'";

            return value;
        }
    }
}