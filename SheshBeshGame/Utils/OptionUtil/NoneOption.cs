﻿using System;

namespace SheshBeshGame.Utils.OptionUtil
{
    internal sealed class NoneOption<T> : Option<T>
    {
        public bool IsSome => false;
        public bool IsNone => true;
        public T ValueUnsafe { get { throw new NoneOptionException("Get Value on none option"); } }

        public Option<S> Map<S>(Func<T, S> map)
        {
            return new NoneOption<S>();
        }

        public Option<S> FlatMap<S>(Func<T, Option<S>> map)
        {
            return new NoneOption<S>();
        }

        public void Iter(Action<T> action)
        {
            return;
            
        }
    }
}
