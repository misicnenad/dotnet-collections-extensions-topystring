﻿using System.Collections;
using System.Collections.Generic;

namespace Collections.Extensions.ToPyString
{
    internal class EnumerablePyStringConverter : BaseCollectionStringConverter
    {
        internal EnumerablePyStringConverter(IEnumerable source, IEnumerable<object> sourceContainers, string prefix)
            : base(source, sourceContainers, prefix, BracketType.Square)
        {
        }
    }
}