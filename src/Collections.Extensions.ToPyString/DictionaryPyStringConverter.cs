﻿using System.Collections;
using System.Collections.Generic;

namespace Collections.Extensions.ToPyString
{
    class DictionaryPyStringConverter : BaseCollectionPyStringConverter<IDictionary>
    {
        internal DictionaryPyStringConverter(IDictionary source, IEnumerable<object> sourceContainers, string prefix)
            : base(source, sourceContainers, prefix, BracketType.Braces)
        {
        }
    }
}
