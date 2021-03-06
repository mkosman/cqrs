﻿using System;
using Xendor.QueryModel.Expressions.Converts.Exceptions;

namespace Xendor.QueryModel.Expressions.Converts
{
    internal class GuidFilterConvert : FilterConvert<Guid>
    {
        protected override Guid ToConvert(string value)
        {
            if (!Guid.TryParse(value, out var result))
            {
                throw new FilterConvertException(value, typeof(Guid));
            }
            return result;
        }
    }
}