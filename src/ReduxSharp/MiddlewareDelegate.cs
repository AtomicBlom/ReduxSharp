﻿using System;

namespace ReduxSharp
{
    /// <summary>
    /// A higher-order function that composes a dispatch function to return a new dispatch function.
    /// </summary>
    /// <typeparam name="TState">A type of root state tree</typeparam>
    /// <param name="store">A store</param>
    /// <param name="next">A dispatch function</param>
    /// <returns>A new dispatch function</returns>
    public delegate DispatchDelegate MiddlewareDelegate<TState>(IStore<TState> store, DispatchDelegate next);
}
