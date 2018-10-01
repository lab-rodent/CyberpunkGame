﻿////////////////////////////////////////////////////////////////////////////////////////////////////
// About:   Finite State Machine by Jackson Dunstan
// Article: http://JacksonDunstan.com/articles/3137
// License: MIT
// Copyright © 2015 Jackson Dunstan
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the “Software”), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
////////////////////////////////////////////////////////////////////////////////////////////////////


using System;

/// <summary>
/// Event args that are dispatched when a state wants to transition to another state
/// </summary>
public class StateBeginExitEventArgs : EventArgs
{
    /// <summary>
    /// The state to transition to
    /// </summary>
    public IState NextState { get; private set; }

    /// <summary>
    /// The transition to use to get to the next state
    /// </summary>
    public IStateTransition Transition { get; private set; }

    /// <summary>
    /// Create the event args
    /// </summary>
    /// <param name="nextState">The state to transition to</param>
    /// <param name="transition">The transition to use to get to the next state</param>
    public StateBeginExitEventArgs(
        IState nextState,
        IStateTransition transition
    )
    {
        NextState = nextState;
        Transition = transition;
    }
}
